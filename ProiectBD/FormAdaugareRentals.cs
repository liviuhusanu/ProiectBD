using LibrarieModele;

using NivelAccesDate;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProiectBD
{
    partial class FormAdaugareRentals : Form
    {
        private readonly AdministrareRentals administrareRentals = new AdministrareRentals();
        private readonly AdministrareClienti administrareClienti = new AdministrareClienti();
        private readonly FormRentals formRentals;
        private Rental rental;

        public FormAdaugareRentals(Rental rental = null, FormRentals form = null)
        {
            InitializeComponent();
            comboBoxStatus.Items.AddRange(new string[] { "active", "completed", "canceled" });

            if (!chkReturnDateSpecified.Checked)
            {
                chkReturnDateSpecified_CheckedChanged(this, EventArgs.Empty);
            }

            // Set default selection
            comboBoxStatus.SelectedIndex = 0;
            formRentals = form;

            var clients = administrareClienti.GetClients();
            comboBoxClients.DataSource = clients;
            comboBoxClients.DisplayMember = "Name";
            //comboBoxClients.ValueMember = "Id";

            if (rental != null)
            {
                this.rental = rental;
                PopulateFields();
                comboBoxClients.Enabled = false;
                btnAdaugaRental.Visible = false;
                btnModificaRental.Visible = true;
            }
            else
            {
                btnAdaugaRental.Visible = true;
                btnModificaRental.Visible = false;
            }
        }

        private void PopulateFields()
        {
            int index = -1;
            if (rental != null)
            {
                foreach(var item in comboBoxClients.Items)
                {
                    if(item is Client client)
                    {
                        index = comboBoxClients.FindStringExact(rental.Client.Name);
                        comboBoxClients.SelectedIndex = index;
                        break;
                    }
                }
                //comboBoxClients.SelectedValue = rental.Client;
                dateTimeRental.Value = rental.RentalDate;
                if (rental.ReturnDate.HasValue)
                {
                    chkReturnDateSpecified.Checked = true;
                    dateTimeReturn.Value = rental.ReturnDate.Value;
                    dateTimeReturn.Enabled = true;
                }
                else
                {
                    chkReturnDateSpecified.Checked = false;
                    dateTimeReturn.Enabled = false;
                }
                comboBoxStatus.SelectedItem = rental.Status;
            }
        }

        private bool ValidateClient()
        {
            bool valid = comboBoxClients.SelectedIndex != -1;
            if (!valid)
                errorProviderName.SetError(comboBoxClients, "Please select a client.");
            else
                errorProviderName.SetError(comboBoxClients, "");
            return valid;
        }

        private bool ValidateAll()
        {
            bool isClientValid = ValidateClient();
            return isClientValid;
        }

        private void btnAdaugaRental_Click_1(object sender, EventArgs e)
        {
            if (!ValidateAll())
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                return;
            }

            var selectedClient = comboBoxClients.SelectedItem as Client;
            int clientId = selectedClient.IdClient;
            DateTime rentalDate = dateTimeRental.Value;
            DateTime? returnDate = chkReturnDateSpecified.Checked ? dateTimeReturn.Value : (DateTime?)null;
            string status = comboBoxStatus.SelectedItem.ToString();

            Rental rental = new Rental(selectedClient, rentalDate, returnDate, status); // Assuming PriceTotal is 0 by default
            //File.WriteAllText("C:\\Users\\Liviu\\source\\repos\\ProiectBD\\ProiectBD\\log.txt", rental.ToString());

            bool success = administrareRentals.AddRental(rental);

            if (success)
            {
                lblValidate.Text = "Success";
                lblValidate.ForeColor = Color.Green;
                MessageBox.Show("Rental added successfully.");
                if (formRentals != null)
                {
                    List<Rental> rental_list = administrareRentals.GetRentals(true);
                    formRentals.dataGridUpdate(rental_list);
                }
                this.Close();
            }
            else
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                MessageBox.Show("An error occurred while adding the rental.");
            }
        }

        private void btnModificaRental_Click_1(object sender, EventArgs e)
        {
            if (!ValidateAll())
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                return;
            }

            var selectedClient = comboBoxClients.SelectedItem as Client;
            int clientId = selectedClient.IdClient;
            DateTime rentalDate = dateTimeRental.Value;
            DateTime? returnDate = chkReturnDateSpecified.Checked ? dateTimeReturn.Value : (DateTime?)null;
            string status = comboBoxStatus.SelectedItem.ToString();

            rental.IdClient = clientId;
            rental.RentalDate = rentalDate;
            rental.ReturnDate = returnDate;
            rental.Status = status;

            bool success = administrareRentals.UpdateRental(rental);

            if (success)
            {
                lblValidate.Text = "Success";
                lblValidate.ForeColor = Color.Green;
                MessageBox.Show("Rental modified successfully.");
                if (formRentals != null)
                {
                    List<Rental> rental_list = administrareRentals.GetRentals(true);
                    formRentals.dataGridUpdate(rental_list);
                }
                this.Close();
            }
            else
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                MessageBox.Show("An error occurred while modifying the rental.");
            }
        }

        private void chkReturnDateSpecified_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeReturn.Enabled = chkReturnDateSpecified.Checked;
        }
    }
}
