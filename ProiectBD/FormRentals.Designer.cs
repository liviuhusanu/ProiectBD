namespace ProiectBD
{
    partial class FormRentals
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
            this.dataGridRentals = new System.Windows.Forms.DataGridView();
            this.id_rentalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rental_dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumar = new System.Windows.Forms.Label();
            this.errorProviderDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddRental = new System.Windows.Forms.Button();
            this.btnDeleteRental = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRentals
            // 
            this.dataGridRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rentalColumn,
            this.nameColumn,
            this.rental_dateColumn,
            this.return_dateColumn,
            this.statusColumn,
            this.price_totalColumn});
            this.dataGridRentals.Location = new System.Drawing.Point(58, 46);
            this.dataGridRentals.Name = "dataGridRentals";
            this.dataGridRentals.RowHeadersWidth = 51;
            this.dataGridRentals.RowTemplate.Height = 24;
            this.dataGridRentals.Size = new System.Drawing.Size(812, 309);
            this.dataGridRentals.TabIndex = 0;
            // 
            // id_rentalColumn
            // 
            this.id_rentalColumn.HeaderText = "Id inchiriere";
            this.id_rentalColumn.MinimumWidth = 6;
            this.id_rentalColumn.Name = "id_rentalColumn";
            this.id_rentalColumn.Width = 54;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Nume client";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 100;
            // 
            // rental_dateColumn
            // 
            this.rental_dateColumn.HeaderText = "Data inchiriere";
            this.rental_dateColumn.MinimumWidth = 6;
            this.rental_dateColumn.Name = "rental_dateColumn";
            this.rental_dateColumn.Width = 120;
            // 
            // return_dateColumn
            // 
            this.return_dateColumn.HeaderText = "Data returnare";
            this.return_dateColumn.MinimumWidth = 6;
            this.return_dateColumn.Name = "return_dateColumn";
            this.return_dateColumn.Width = 120;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Stare comanda";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.Width = 80;
            // 
            // price_totalColumn
            // 
            this.price_totalColumn.HeaderText = "Pretul comenzii";
            this.price_totalColumn.MinimumWidth = 6;
            this.price_totalColumn.Name = "price_totalColumn";
            this.price_totalColumn.Width = 65;
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
            // btnAddRental
            // 
            this.btnAddRental.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddRental.Location = new System.Drawing.Point(655, 391);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(215, 33);
            this.btnAddRental.TabIndex = 4;
            this.btnAddRental.Text = "Adauga/modifica inchiriere";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnDeleteRental
            // 
            this.btnDeleteRental.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteRental.Location = new System.Drawing.Point(655, 436);
            this.btnDeleteRental.Name = "btnDeleteRental";
            this.btnDeleteRental.Size = new System.Drawing.Size(215, 33);
            this.btnDeleteRental.TabIndex = 5;
            this.btnDeleteRental.Text = "Sterge inchiriere";
            this.btnDeleteRental.UseVisualStyleBackColor = true;
            this.btnDeleteRental.Click += new System.EventHandler(this.btnDeleteRental_Click_1);
            // 
            // FormRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 500);
            this.Controls.Add(this.btnDeleteRental);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.lblNumar);
            this.Controls.Add(this.dataGridRentals);
            this.Name = "FormRentals";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormRentals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRentals;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.ErrorProvider errorProviderDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rentalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rental_dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_totalColumn;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Button btnDeleteRental;
    }
}