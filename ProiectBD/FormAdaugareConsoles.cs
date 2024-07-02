using LibrarieModele;

using NivelAccesDate;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectBD
{
    public partial class FormAdaugareConsoles : Form
    {
        private readonly AdministrareConsole administrareConsole = new AdministrareConsole();
        private readonly FormConsoles formConsoles;

        Consola consola;
        Button currentButton;

        public FormAdaugareConsoles(Consola c = null, FormConsoles form = null)
        {
            if (form != null)
            {
                formConsoles = form;
            }
            InitializeComponent();
            if (c != null)
            {
                this.consola = c;
                PopulateFields();
                currentButton = btnModificaConsola;
                currentButton.Visible = true;
                btnAdaugaConsola.Visible = false;
            }
            else
            {
                currentButton = btnAdaugaConsola;
                currentButton.Visible = true;
                btnModificaConsola.Visible = false;
            }
        }

        public void PopulateFields()
        {
            if (consola != null)
            {
                txtName.Text = consola.Name;
                txtManufacturer.Text = consola.Manufacturer;
                txtQuantity.Text = consola.Quantity.ToString();
                txtAvailable.Text = consola.Available.ToString();
                txtPrice_day.Text = consola.PriceDay.ToString();
            }
        }

        private bool ValidateName()
        {
            bool valid = true;
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 3 || txtName.Text.Length > 30)
            {
                valid = false;
                errorProviderName.SetError(txtName, "Name cannot be empty and must be between 3 and 30 characters.");
            }
            else
            {
                errorProviderName.SetError(txtName, ""); // Clear error if valid
            }
            return valid;
        }

        private bool ValidateManufacturer()
        {
            bool valid = true;
            if (string.IsNullOrWhiteSpace(txtManufacturer.Text) || txtManufacturer.Text.Length < 3 || txtManufacturer.Text.Length > 30)
            {
                valid = false;
                errorProviderManufacturer.SetError(txtManufacturer, "Manufacturer cannot be empty and must be between 3 and 30 characters.");
            }
            else
            {
                errorProviderManufacturer.SetError(txtManufacturer, ""); // Clear error if valid
            }
            return valid;
        }

        private bool ValidateAvailable()
        {
            bool valid = true;

            if (!int.TryParse(txtAvailable.Text, out int available) || available < 0)
            {
                valid = false;
                errorProviderAvailable.SetError(txtAvailable, "Available units must be a non-negative integer.");
            }
            else if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                valid = false;
                errorProviderAvailable.SetError(txtQuantity, "Quantity must be a non-negative integer.");
            }
            else if (available > quantity)
            {
                valid = false;
                errorProviderAvailable.SetError(txtAvailable, "Available units must be less than the quantity.");
            }
            else
            {
                errorProviderAvailable.SetError(txtAvailable, ""); // Clear error if valid
            }

            return valid;
        }

        private bool ValidatePriceDay()
        {
            bool valid = true;
            if (!decimal.TryParse(txtPrice_day.Text, out decimal priceDay) || priceDay <= 0)
            {
                valid = false;
                errorProviderPrice_day.SetError(txtPrice_day, "Price per day must be a positive decimal.");
            }
            else
            {
                errorProviderPrice_day.SetError(txtPrice_day, ""); // Clear error if valid
            }
            return valid;
        }

        private bool ValidateAll()
        {
            bool isNameValid = ValidateName();
            bool isManufacturerValid = ValidateManufacturer();
            bool isAvailableValid = ValidateAvailable();
            bool isPriceDayValid = ValidatePriceDay();

            return isNameValid && isManufacturerValid && isAvailableValid && isPriceDayValid;
        }

        private void btnAdaugaConsola_Click_1(object sender, EventArgs e)
        {
            if (!ValidateAll())
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                return;
            }

            string name = txtName.Text.Trim();
            string manufacturer = txtManufacturer.Text.Trim();
            int quantity = int.Parse(txtQuantity.Text.Trim());
            int available = int.Parse(txtAvailable.Text.Trim());
            decimal priceDay = decimal.Parse(txtPrice_day.Text.Trim());

            Consola consola = new Consola(name, manufacturer, quantity, available, priceDay);

            bool success = administrareConsole.AddConsola(consola);

            if (success)
            {
                lblValidate.Text = "Success";
                lblValidate.ForeColor = Color.Green;
                MessageBox.Show("Console added successfully.");
                if (formConsoles != null)
                {
                    List<Consola> consoles_list = administrareConsole.GetConsole();
                    formConsoles.dataGridUpdate(consoles_list);
                }
                this.Close();
            }
            else
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                MessageBox.Show("An error occurred while adding the console.");
            }
        }

        private void btnModificaConsola_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                return;
            }

            string name = txtName.Text.Trim();
            string manufacturer = txtManufacturer.Text.Trim();
            int quantity = int.Parse(txtQuantity.Text.Trim());
            int available = int.Parse(txtAvailable.Text.Trim());
            decimal priceDay = decimal.Parse(txtPrice_day.Text.Trim());

            consola.Name = name;
            consola.Manufacturer = manufacturer;
            consola.Quantity = quantity;
            consola.Available = available;
            consola.PriceDay = priceDay;

            bool success = administrareConsole.UpdateConsola(consola);

            if (success)
            {
                lblValidate.Text = "Success";
                lblValidate.ForeColor = Color.Green;
                MessageBox.Show("Console modified successfully.");
                if (formConsoles != null)
                {
                    List<Consola> consoles_list = administrareConsole.GetConsole();
                    formConsoles.dataGridUpdate(consoles_list);
                }
                this.Close();
            }
            else
            {
                lblValidate.Text = "Error";
                lblValidate.ForeColor = Color.Red;
                MessageBox.Show("An error occurred while modifying the console.");
            }
        }
    }
}
