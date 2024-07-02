using LibrarieModele;
using NivelAccesDate;
using System.Windows.Forms;
using System;
using System.IO;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Collections.Generic;

namespace ProiectBD
{
    partial class FormAdaugareClients : Form
    {
        private readonly AdministrareClienti administrareClienti = new AdministrareClienti();
        private readonly FormClients formClients;

        string outputPath = "C:\\Users\\Liviu\\source\\repos\\ProiectBD\\ProiectBD\\log.txt";
        Client client;
        Button currentButton;
      

        public FormAdaugareClients(Client cl = null,FormClients form = null)
        {
            if (form != null)
            {
                formClients = form;
            }
            InitializeComponent();
            if (cl != null)
            {
                this.client = cl;
                PopulateFields();
                currentButton = btnModifica;
                currentButton.Visible = true;
                btnAdaugaClient.Visible = false;
            }
            else
            {
                currentButton = btnAdaugaClient;
                currentButton.Visible = false;
                btnAdaugaClient.Visible = true;
            }

            
        }
        public void PopulateFields()
        {
            if (client != null)
            {
                txtEmail.Text = client.Email;
                txtName.Text = client.Name;
                txtPhone.Text = client.Phone;
            }
        }

        private bool ValidateName()
        {
            bool validN = true;
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 3 || txtName.Text.Length > 30)
            {
                validN = false;
                errorProviderNume.SetError(txtName, "Name cannot be empty and must be less than 30 characters.");
            }
            else
            {
                errorProviderNume.SetError(txtName, ""); // Clear error if valid
            }
            return validN;
        }

        private bool ValidateEmail()
        {
            bool validE = true;
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text.Length < 12 || txtEmail.Text.Length > 50 || !System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                validE = false;
                errorProviderEmail.SetError(txtEmail, "Email must be 12-50 characters long and in a valid format.");
            }
            else
            {
                var existingClient = administrareClienti.GetClientByEmail(txtEmail.Text);
                //File.WriteAllText("C:\\Users\\Liviu\\source\\repos\\ProiectBD\\ProiectBD\\log.txt", existingClient.Email); 
                if (existingClient != null)
                {
                    validE = false;
                    errorProviderEmail.SetError(txtEmail, "Email already exists.");
                }
                else
                {
                    errorProviderEmail.SetError(txtEmail, ""); // Clear error if valid
                }
            }
            return validE;
        }

        private bool ValidatePhone()
        {
            bool validP = true;
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length < 10 || txtPhone.Text.Length > 20 || !System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "^\\d+$"))
            {
                validP = false;
                errorProviderPhone.SetError(txtPhone, "Phone number must be between 10 and 20 digits only");
            }
            else
            {
                errorProviderPhone.SetError(txtPhone, ""); // Clear error if valid
            }
            return validP;
        }

        private bool ValidateAll()
        {
            bool isNameValid = ValidateName();
            bool isEmailValid = ValidateEmail();
            bool isPhoneValid = ValidatePhone();

            return isNameValid && isEmailValid && isPhoneValid;
        }

        private bool ValidateAllUpdate()
        {
            bool isNameValid = ValidateName();
            bool isPhoneValid = ValidatePhone();

            return isNameValid && isPhoneValid;
        }

        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            //File.WriteAllText("C:\\Users\\Liviu\\source\\repos\\ProiectBD\\ProiectBD\\log.txt", (validN && validE && validP).ToString());
            if (!(ValidateAll()))
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                //MessageBox.Show("Please fix the errors before submitting.");
                return;
            }

            // Gather data from the form
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // Create a new Client object
            Client client = new Client(name, email, phone);

            // Add the client to the database
            bool success = administrareClienti.AddClient(client);

            if (success)
            {
                lblValidate.Text = "Succes";
                lblValidate.ForeColor = Color.Green;
                MessageBox.Show("Client added successfully.");
                if (formClients != null)
                {
                    List<Client> clients_list = administrareClienti.GetClients();
                    formClients.dataGridUpdate(clients_list);
                }
                this.Close();
            }
            else
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                MessageBox.Show("An error occurred while adding the client.");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            bool validN = true;
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 3 || txtName.Text.Length > 30)
            {
                validN = false;
                errorProviderNume.SetError(txtName, "Name cannot be empty and must be less than 30 characters.");
            }
            else
            {
                errorProviderNume.SetError(txtName, ""); // Clear error if valid
            }

            bool validE = true;
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text.Length < 12 || txtEmail.Text.Length > 50 || !System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                validE = false;
                errorProviderEmail.SetError(txtEmail, "Email must be 12-50 characters long and in a valid format.");
            }
            else
            {
                errorProviderEmail.SetError(txtEmail, ""); // Clear error if valid
            }

            bool validP = true;
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length < 10 || txtPhone.Text.Length > 20 || !System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "^\\d+$"))
            {
                validP = false;
                errorProviderPhone.SetError(txtPhone, "Phone number must be between 10 and 20 digits only");
            }
            else
            {
                errorProviderPhone.SetError(txtPhone, ""); // Clear error if valid
            }

            //File.WriteAllText("C:\\Users\\Liviu\\source\\repos\\ProiectBD\\ProiectBD\\log.txt", (validN && validE && validP).ToString());
            if (!(validN && validE && validP))
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                //MessageBox.Show("Please fix the errors before submitting.");
                return;
            }

            // Gather data from the form
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // Create a new Client object
            //Client client = new Client(name, email, phone);
            client.Email = email;
            client.Phone = phone;
            client.Name = name;
            // Add the client to the database
            bool success = administrareClienti.UpdateClient(client);

            if (success)
            {
                lblValidate.Text = "Succes";
                lblValidate.ForeColor = Color.Green;
                MessageBox.Show("Client modified successfully.");
                if (formClients != null)
                {
                    List<Client> clients_list = administrareClienti.GetClients();
                    formClients.dataGridUpdate(clients_list);
                }
                this.Close();
            }
            else
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                MessageBox.Show("An error occurred while modifying the client.");
            }
            // Refresh the DataGridView
        }
    }
}
