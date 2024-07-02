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
using NivelAccesDate;
using System.Xml.Linq;

namespace ProiectBD
{
    public partial class FormClients : Form
    {
        AdministrareClienti administrareClienti = new AdministrareClienti();
        FormAdaugareClients formAdaugare;
       


        public FormClients()
        {
            InitializeComponent();
        }

        public void dataGridUpdate(List<Client> c)
        {
            c = c.OrderBy(client => client.IdClient != 0 ? client.IdClient : int.MaxValue).ToList();

            dataGridClients.Rows.Clear();

            foreach (var client in c)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridClients,
                    client.IdClient,
                    client.Name,
                    client.Email,
                    client.Phone
                );
                row.Tag = client;
                dataGridClients.Rows.Add(row);
            }
        }

        private Client GetClientFromSelectedRow()
        {
            if (dataGridClients.SelectedRows.Count == 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dataGridClients.SelectedRows[0];

            Client cl = selectedRow.Tag as Client;
            return cl;
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            List<Client> clients_list = administrareClienti.GetClients();
            dataGridUpdate(clients_list);
        }

        private bool IsRowSelected()
        {
            return dataGridClients.SelectedRows.Count > 0;
        }

        private void btnAddClients_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                formAdaugare = new FormAdaugareClients(GetClientFromSelectedRow(),this);
                formAdaugare.ShowDialog();
            }
            else
            {
                formAdaugare = new FormAdaugareClients(null, this);
                formAdaugare.ShowDialog();
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                errorProviderDelete.Clear();
                bool success = administrareClienti.DeleteClient(GetClientFromSelectedRow().IdClient);
                if (success)
                {
                    MessageBox.Show("Client deleted successfully.");

                    List<Client> clients_list = administrareClienti.GetClients();
                    dataGridUpdate(clients_list);
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the client.");
                }
            }
            else
            {
                errorProviderDelete.SetError(btnDeleteClient, "Select a client.");
            }
        }
    }
}
