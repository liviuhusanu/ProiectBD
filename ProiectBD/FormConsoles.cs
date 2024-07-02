using LibrarieModele;
using NivelAccesDate;

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
    public partial class FormConsoles : Form
    {
        AdministrareConsole administrareConsole = new AdministrareConsole();
        FormAdaugareConsoles formAdaugare;

        public FormConsoles()
        {
            InitializeComponent();
        }

        public void dataGridUpdate(List<Consola> c)
        {
            c = c.OrderBy(consola => consola.IdConsole != 0 ? consola.IdConsole : int.MaxValue).ToList();

            dataGridConsoles.Rows.Clear();
            foreach (var consola in c)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridConsoles,
                    consola.IdConsole,
                    consola.Name,
                    consola.Manufacturer,
                    consola.Quantity,
                    consola.Available,
                    consola.PriceDay
                    );
                row.Tag = consola;
                dataGridConsoles.Rows.Add(row);
            }
        }
        private Consola GetConsolaFromSelectedRow()
        {
            if (dataGridConsoles.SelectedRows.Count == 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dataGridConsoles.SelectedRows[0];

            Consola c = selectedRow.Tag as Consola;
            return c;
        }

        private void FormConsoles_Load(object sender, EventArgs e)
        {
            List<Consola> consoles_list = administrareConsole.GetConsole();
            dataGridUpdate(consoles_list);
        }

        private bool IsRowSelected()
        {
            return dataGridConsoles.SelectedRows.Count > 0;
        }

        private void btnAddConsola_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                formAdaugare = new FormAdaugareConsoles(GetConsolaFromSelectedRow(), this);
                formAdaugare.ShowDialog();
            }
            else
            {
                formAdaugare = new FormAdaugareConsoles(null, this);
                formAdaugare.ShowDialog();
            }
        }

        private void btnDeleteConsola_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                errorProviderDelete.Clear();
                bool success = administrareConsole.DeleteConsola(GetConsolaFromSelectedRow().IdConsole);
                if (success)
                {
                    MessageBox.Show("Console deleted successfully.");

                    List<Consola> console_list = administrareConsole.GetConsole();
                    dataGridUpdate(console_list);
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the console.");
                }
            }
            else
            {
                errorProviderDelete.SetError(btnDeleteConsola, "Select a console.");
            }

        }
    }
}
