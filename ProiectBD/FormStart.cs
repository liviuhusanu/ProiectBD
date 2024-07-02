using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibrarieModele;
using NivelAccesDate;

namespace ProiectBD
{
    public partial class FormStart : Form
    {
        private Form activeForm;
        public FormStart()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClients(), sender);
            lblTitle.Text = "Clienti";
        }

        private void btnConsoles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsoles(), sender);
            lblTitle.Text = "Console";
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRentals(), sender);
            lblTitle.Text = "Inchirieri";
        }

        private void btnRentalsDetails_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRentalsDetails(), sender);
            lblTitle.Text = "Detalii Inchirieri";
        }

        private void btnAddClients_Click(object sender, EventArgs e)
        {
        }
    }
}
