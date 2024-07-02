namespace ProiectBD
{
    partial class FormAdaugareConsoles
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
            this.txtPrice_day = new System.Windows.Forms.TextBox();
            this.lblPrice_day = new System.Windows.Forms.Label();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.btnAdaugaConsola = new System.Windows.Forms.Button();
            this.btnModificaConsola = new System.Windows.Forms.Button();
            this.lblValidate = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderManufacturer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAvailable = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrice_day = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice_day)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrice_day);
            this.groupBox2.Controls.Add(this.lblPrice_day);
            this.groupBox2.Controls.Add(this.txtAvailable);
            this.groupBox2.Controls.Add(this.lblAvailable);
            this.groupBox2.Controls.Add(this.btnAdaugaConsola);
            this.groupBox2.Controls.Add(this.btnModificaConsola);
            this.groupBox2.Controls.Add(this.lblValidate);
            this.groupBox2.Controls.Add(this.txtManufacturer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblManufacturer);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(425, 345);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adaugare consola";
            // 
            // txtPrice_day
            // 
            this.txtPrice_day.Location = new System.Drawing.Point(151, 186);
            this.txtPrice_day.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice_day.Name = "txtPrice_day";
            this.txtPrice_day.Size = new System.Drawing.Size(219, 22);
            this.txtPrice_day.TabIndex = 16;
            // 
            // lblPrice_day
            // 
            this.lblPrice_day.AutoSize = true;
            this.lblPrice_day.Location = new System.Drawing.Point(29, 189);
            this.lblPrice_day.Name = "lblPrice_day";
            this.lblPrice_day.Size = new System.Drawing.Size(62, 16);
            this.lblPrice_day.TabIndex = 15;
            this.lblPrice_day.Text = "Pret pe zi";
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(151, 145);
            this.txtAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(219, 22);
            this.txtAvailable.TabIndex = 14;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(29, 148);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(74, 16);
            this.lblAvailable.TabIndex = 13;
            this.lblAvailable.Text = "Valabilitate";
            // 
            // btnAdaugaConsola
            // 
            this.btnAdaugaConsola.Location = new System.Drawing.Point(151, 261);
            this.btnAdaugaConsola.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugaConsola.Name = "btnAdaugaConsola";
            this.btnAdaugaConsola.Size = new System.Drawing.Size(100, 28);
            this.btnAdaugaConsola.TabIndex = 8;
            this.btnAdaugaConsola.Text = "Adauga";
            this.btnAdaugaConsola.UseVisualStyleBackColor = true;
            this.btnAdaugaConsola.Click += new System.EventHandler(this.btnAdaugaConsola_Click_1);
            // 
            // btnModificaConsola
            // 
            this.btnModificaConsola.Location = new System.Drawing.Point(151, 261);
            this.btnModificaConsola.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificaConsola.Name = "btnModificaConsola";
            this.btnModificaConsola.Size = new System.Drawing.Size(100, 28);
            this.btnModificaConsola.TabIndex = 12;
            this.btnModificaConsola.Text = "Modifica";
            this.btnModificaConsola.UseVisualStyleBackColor = true;
            this.btnModificaConsola.Click += new System.EventHandler(this.btnModificaConsola_Click);
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.Location = new System.Drawing.Point(178, 306);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(0, 16);
            this.lblValidate.TabIndex = 11;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(151, 64);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(219, 22);
            this.txtManufacturer.TabIndex = 10;
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
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(29, 67);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 16);
            this.lblManufacturer.TabIndex = 6;
            this.lblManufacturer.Text = "Producator";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(29, 109);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(59, 16);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Cantitate";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 31);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nume";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(151, 106);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(219, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 22);
            this.txtName.TabIndex = 0;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderManufacturer
            // 
            this.errorProviderManufacturer.ContainerControl = this;
            // 
            // errorProviderQuantity
            // 
            this.errorProviderQuantity.ContainerControl = this;
            // 
            // errorProviderAvailable
            // 
            this.errorProviderAvailable.ContainerControl = this;
            // 
            // errorProviderPrice_day
            // 
            this.errorProviderPrice_day.ContainerControl = this;
            // 
            // FormAdaugareConsoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 371);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormAdaugareConsoles";
            this.Text = "FormAdaugareConsoles";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice_day)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdaugaConsola;
        private System.Windows.Forms.Button btnModificaConsola;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtPrice_day;
        private System.Windows.Forms.Label lblPrice_day;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderManufacturer;
        private System.Windows.Forms.ErrorProvider errorProviderQuantity;
        private System.Windows.Forms.ErrorProvider errorProviderAvailable;
        private System.Windows.Forms.ErrorProvider errorProviderPrice_day;
    }
}