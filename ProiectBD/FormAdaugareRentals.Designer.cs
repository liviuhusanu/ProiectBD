namespace ProiectBD
{
    partial class FormAdaugareRentals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkReturnDateSpecified = new System.Windows.Forms.CheckBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeRental = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdaugaRental = new System.Windows.Forms.Button();
            this.btnModificaRental = new System.Windows.Forms.Button();
            this.lblValidate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxClients);
            this.groupBox2.Controls.Add(this.chkReturnDateSpecified);
            this.groupBox2.Controls.Add(this.comboBoxStatus);
            this.groupBox2.Controls.Add(this.dateTimeReturn);
            this.groupBox2.Controls.Add(this.dateTimeRental);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.btnAdaugaRental);
            this.groupBox2.Controls.Add(this.btnModificaRental);
            this.groupBox2.Controls.Add(this.lblValidate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblRentalDate);
            this.groupBox2.Controls.Add(this.lblReturnDate);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(425, 345);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adaugare consola";
            // 
            // chkReturnDateSpecified
            // 
            this.chkReturnDateSpecified.AutoSize = true;
            this.chkReturnDateSpecified.Location = new System.Drawing.Point(387, 108);
            this.chkReturnDateSpecified.Name = "chkReturnDateSpecified";
            this.chkReturnDateSpecified.Size = new System.Drawing.Size(18, 17);
            this.chkReturnDateSpecified.TabIndex = 18;
            this.chkReturnDateSpecified.UseVisualStyleBackColor = true;
            this.chkReturnDateSpecified.CheckedChanged += new System.EventHandler(this.chkReturnDateSpecified_CheckedChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(151, 145);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(219, 24);
            this.comboBoxStatus.TabIndex = 17;
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Location = new System.Drawing.Point(151, 104);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(219, 22);
            this.dateTimeReturn.TabIndex = 16;
            // 
            // dateTimeRental
            // 
            this.dateTimeRental.Location = new System.Drawing.Point(151, 62);
            this.dateTimeRental.Name = "dateTimeRental";
            this.dateTimeRental.Size = new System.Drawing.Size(219, 22);
            this.dateTimeRental.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(29, 148);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(99, 16);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Stare comanda";
            // 
            // btnAdaugaRental
            // 
            this.btnAdaugaRental.Location = new System.Drawing.Point(151, 261);
            this.btnAdaugaRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugaRental.Name = "btnAdaugaRental";
            this.btnAdaugaRental.Size = new System.Drawing.Size(100, 28);
            this.btnAdaugaRental.TabIndex = 8;
            this.btnAdaugaRental.Text = "Adauga";
            this.btnAdaugaRental.UseVisualStyleBackColor = true;
            this.btnAdaugaRental.Click += new System.EventHandler(this.btnAdaugaRental_Click_1);
            // 
            // btnModificaRental
            // 
            this.btnModificaRental.Location = new System.Drawing.Point(151, 261);
            this.btnModificaRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificaRental.Name = "btnModificaRental";
            this.btnModificaRental.Size = new System.Drawing.Size(100, 28);
            this.btnModificaRental.TabIndex = 12;
            this.btnModificaRental.Text = "Modifica";
            this.btnModificaRental.UseVisualStyleBackColor = true;
            this.btnModificaRental.Click += new System.EventHandler(this.btnModificaRental_Click_1);
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.Location = new System.Drawing.Point(178, 306);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 16);
            this.lblValidate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 9;
            this.label5.Visible = false;
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Location = new System.Drawing.Point(29, 67);
            this.lblRentalDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(93, 16);
            this.lblRentalDate.TabIndex = 6;
            this.lblRentalDate.Text = "Data inchiriere";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(29, 109);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(92, 16);
            this.lblReturnDate.TabIndex = 5;
            this.lblReturnDate.Text = "Data returnare";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 31);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nume client";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderStatus
            // 
            this.errorProviderStatus.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(151, 23);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(219, 24);
            this.comboBoxClients.TabIndex = 19;
            // 
            // FormAdaugareRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 370);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormAdaugareRentals";
            this.Text = "FormAdaugareRentals";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAdaugaRental;
        private System.Windows.Forms.Button btnModificaRental;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderStatus;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.DateTimePicker dateTimeRental;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.CheckBox chkReturnDateSpecified;
        private System.Windows.Forms.ComboBox comboBoxClients;
    }
}