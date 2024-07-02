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
    public partial class FormRentals : Form
    {
        AdministrareRentals administrareRentals = new AdministrareRentals();
        FormAdaugareRentals formAdaugare;

        public FormRentals()
        {
            InitializeComponent();
        }

        public void dataGridUpdate(List<Rental> r)
        {
            r = r.OrderBy(rental => rental.IdRental != 0 ? rental.IdRental : int.MaxValue).ToList();

            dataGridRentals.Rows.Clear();
            foreach (var rental in r)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridRentals,
                    rental.IdRental,
                    rental.Client.Name,
                    rental.RentalDate,
                    rental.ReturnDate,
                    rental.Status,
                    rental.PriceTotal
                    );
                row.Tag = rental;
                dataGridRentals.Rows.Add(row);
            }
        }

        private Rental GetRentalFromSelectedRow()
        {
            if (dataGridRentals.SelectedRows.Count == 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dataGridRentals.SelectedRows[0];

            Rental r = selectedRow.Tag as Rental;
            return r;
        }

        private void FormRentals_Load(object sender, EventArgs e)
        {
            List<Rental> rentals_list = administrareRentals.GetRentals(true);
            dataGridUpdate(rentals_list);
        }

        private bool IsRowSelected()
        {
            return dataGridRentals.SelectedRows.Count > 0;
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                formAdaugare = new FormAdaugareRentals(GetRentalFromSelectedRow(), this);
                formAdaugare.ShowDialog();
            }
            else
            {
                formAdaugare = new FormAdaugareRentals(null, this);
                formAdaugare.ShowDialog();
            }
        }

        private void btnDeleteRental_Click_1(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                errorProviderDelete.Clear();
                bool success = administrareRentals.DeleteRental(GetRentalFromSelectedRow().IdRental);
                if (success)
                {
                    MessageBox.Show("Rental deleted successfully.");

                    List<Rental> rental_list = administrareRentals.GetRentals(true);
                    dataGridUpdate(rental_list);
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the rental.");
                }
            }
            else
            {
                errorProviderDelete.SetError(btnDeleteRental, "Select a rental.");
            }
        }
    }
}
