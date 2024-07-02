namespace ProiectBD
{
    partial class FormConsoles
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
            this.dataGridConsoles = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_dayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumar = new System.Windows.Forms.Label();
            this.errorProviderDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddConsola = new System.Windows.Forms.Button();
            this.btnDeleteConsola = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsoles
            // 
            this.dataGridConsoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.manufacturerColumn,
            this.quantityColumn,
            this.availableColumn,
            this.price_dayColumn});
            this.dataGridConsoles.Location = new System.Drawing.Point(58, 46);
            this.dataGridConsoles.Name = "dataGridConsoles";
            this.dataGridConsoles.RowHeadersWidth = 51;
            this.dataGridConsoles.RowTemplate.Height = 24;
            this.dataGridConsoles.Size = new System.Drawing.Size(812, 309);
            this.dataGridConsoles.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id consola";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.Width = 59;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Nume";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 120;
            // 
            // manufacturerColumn
            // 
            this.manufacturerColumn.HeaderText = "Producator";
            this.manufacturerColumn.MinimumWidth = 6;
            this.manufacturerColumn.Name = "manufacturerColumn";
            this.manufacturerColumn.Width = 120;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Cantitate totala";
            this.quantityColumn.MinimumWidth = 6;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 80;
            // 
            // availableColumn
            // 
            this.availableColumn.HeaderText = "Valabile";
            this.availableColumn.MinimumWidth = 6;
            this.availableColumn.Name = "availableColumn";
            this.availableColumn.Width = 80;
            // 
            // price_dayColumn
            // 
            this.price_dayColumn.HeaderText = "Pretul pe zi";
            this.price_dayColumn.MinimumWidth = 6;
            this.price_dayColumn.Name = "price_dayColumn";
            this.price_dayColumn.Width = 80;
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
            // btnAddConsola
            // 
            this.btnAddConsola.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddConsola.Location = new System.Drawing.Point(676, 390);
            this.btnAddConsola.Name = "btnAddConsola";
            this.btnAddConsola.Size = new System.Drawing.Size(194, 33);
            this.btnAddConsola.TabIndex = 3;
            this.btnAddConsola.Text = "Adauga/modifica consola";
            this.btnAddConsola.UseVisualStyleBackColor = true;
            this.btnAddConsola.Click += new System.EventHandler(this.btnAddConsola_Click);
            // 
            // btnDeleteConsola
            // 
            this.btnDeleteConsola.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteConsola.Location = new System.Drawing.Point(676, 436);
            this.btnDeleteConsola.Name = "btnDeleteConsola";
            this.btnDeleteConsola.Size = new System.Drawing.Size(194, 33);
            this.btnDeleteConsola.TabIndex = 4;
            this.btnDeleteConsola.Text = "Sterge consola";
            this.btnDeleteConsola.UseVisualStyleBackColor = true;
            this.btnDeleteConsola.Click += new System.EventHandler(this.btnDeleteConsola_Click);
            // 
            // FormConsoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 500);
            this.Controls.Add(this.btnDeleteConsola);
            this.Controls.Add(this.btnAddConsola);
            this.Controls.Add(this.lblNumar);
            this.Controls.Add(this.dataGridConsoles);
            this.Name = "FormConsoles";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormConsoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsoles;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.ErrorProvider errorProviderDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_dayColumn;
        private System.Windows.Forms.Button btnAddConsola;
        private System.Windows.Forms.Button btnDeleteConsola;
    }
}