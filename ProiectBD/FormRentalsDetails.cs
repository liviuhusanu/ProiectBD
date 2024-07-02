using LibrarieModele;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD
{
    public partial class FormRentalsDetails : Form
    {
        AdministrareRentalsDetails administrareRentalsDetails = new AdministrareRentalsDetails();

        public FormRentalsDetails()
        {
            InitializeComponent();
        }

        private void dataGridUpdate(List<RentalDetails> rd)
        {
            dataGridRentalsDetails.Rows.Clear();
            foreach (var rental in rd)
            {
                dataGridRentalsDetails.Rows.Add(new object[] { rental.IdRentalDetails, rental.IdRental, rental.Consola.Name, rental.Quantity });
            }
        }

        private void FormRentalsDetails_Load(object sender, EventArgs e)
        {
            List<RentalDetails> rentalDetails_list = administrareRentalsDetails.GetRentalsDetails(true);
            dataGridUpdate(rentalDetails_list);
        }
    }
}
