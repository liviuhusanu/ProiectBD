namespace ProiectBD
{
    partial class FormRentalsDetails
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
            this.dataGridRentalsDetails = new System.Windows.Forms.DataGridView();
            this.id_rentaldetailsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rentalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.console_nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumar = new System.Windows.Forms.Label();
            this.errorProviderDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddRentalDet = new System.Windows.Forms.Button();
            this.btnDeleteRentalDet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentalsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRentalsDetails
            // 
            this.dataGridRentalsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRentalsDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rentaldetailsColumn,
            this.id_rentalColumn,
            this.console_nameColumn,
            this.quantityColumn});
            this.dataGridRentalsDetails.Location = new System.Drawing.Point(58, 46);
            this.dataGridRentalsDetails.Name = "dataGridRentalsDetails";
            this.dataGridRentalsDetails.RowHeadersWidth = 51;
            this.dataGridRentalsDetails.RowTemplate.Height = 24;
            this.dataGridRentalsDetails.Size = new System.Drawing.Size(812, 309);
            this.dataGridRentalsDetails.TabIndex = 0;
            // 
            // id_rentaldetailsColumn
            // 
            this.id_rentaldetailsColumn.HeaderText = "Id detalii inchiriere";
            this.id_rentaldetailsColumn.MinimumWidth = 6;
            this.id_rentaldetailsColumn.Name = "id_rentaldetailsColumn";
            this.id_rentaldetailsColumn.Width = 113;
            // 
            // id_rentalColumn
            // 
            this.id_rentalColumn.HeaderText = "Id inchiriere";
            this.id_rentalColumn.MinimumWidth = 6;
            this.id_rentalColumn.Name = "id_rentalColumn";
            this.id_rentalColumn.Width = 142;
            // 
            // console_nameColumn
            // 
            this.console_nameColumn.HeaderText = "Consola";
            this.console_nameColumn.MinimumWidth = 6;
            this.console_nameColumn.Name = "console_nameColumn";
            this.console_nameColumn.Width = 142;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Cantitate";
            this.quantityColumn.MinimumWidth = 6;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 142;
            // 
            // lblNumar
            // 
            this.lblNumar.AutoSize = true;
            this.lblNumar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumar.Location = new System.Drawing.Point(720, 436);
            this.lblNumar.Name = "lblNumar";
            this.lblNumar.Size = new System.Drawing.Size(0, 17);
            this.lblNumar.TabIndex = 2;
            // 
            // errorProviderDelete
            // 
            this.errorProviderDelete.ContainerControl = this;
            // 
            // btnAddRentalDet
            // 
            this.btnAddRentalDet.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddRentalDet.Location = new System.Drawing.Point(655, 391);
            this.btnAddRentalDet.Name = "btnAddRentalDet";
            this.btnAddRentalDet.Size = new System.Drawing.Size(215, 33);
            this.btnAddRentalDet.TabIndex = 5;
            this.btnAddRentalDet.Text = "Adauga/modifica detalii";
            this.btnAddRentalDet.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRentalDet
            // 
            this.btnDeleteRentalDet.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteRentalDet.Location = new System.Drawing.Point(655, 436);
            this.btnDeleteRentalDet.Name = "btnDeleteRentalDet";
            this.btnDeleteRentalDet.Size = new System.Drawing.Size(215, 33);
            this.btnDeleteRentalDet.TabIndex = 6;
            this.btnDeleteRentalDet.Text = "Sterge detalii";
            this.btnDeleteRentalDet.UseVisualStyleBackColor = true;
            // 
            // FormRentalsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 500);
            this.Controls.Add(this.btnDeleteRentalDet);
            this.Controls.Add(this.btnAddRentalDet);
            this.Controls.Add(this.lblNumar);
            this.Controls.Add(this.dataGridRentalsDetails);
            this.Name = "FormRentalsDetails";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormRentalsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentalsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRentalsDetails;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.ErrorProvider errorProviderDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rentaldetailsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rentalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn console_nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.Button btnAddRentalDet;
        private System.Windows.Forms.Button btnDeleteRentalDet;
    }
}