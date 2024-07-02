namespace ProiectBD
{
    partial class FormClients
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
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.lblNumar = new System.Windows.Forms.Label();
            this.errorProviderDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDeleteClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClients
            // 
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.emailColumn,
            this.phoneColumn});
            this.dataGridClients.Location = new System.Drawing.Point(58, 46);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.RowHeadersWidth = 51;
            this.dataGridClients.RowTemplate.Height = 24;
            this.dataGridClients.Size = new System.Drawing.Size(812, 309);
            this.dataGridClients.TabIndex = 0;
            //this.dataGridClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClients_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id client";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.Width = 63;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Nume";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 142;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.Width = 192;
            // 
            // phoneColumn
            // 
            this.phoneColumn.HeaderText = "Telefon";
            this.phoneColumn.MinimumWidth = 6;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.Width = 142;
            // 
            // btnAddClients
            // 
            this.btnAddClients.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddClients.Location = new System.Drawing.Point(684, 390);
            this.btnAddClients.Name = "btnAddClients";
            this.btnAddClients.Size = new System.Drawing.Size(186, 33);
            this.btnAddClients.TabIndex = 1;
            this.btnAddClients.Text = "Adauga/modifica client";
            this.btnAddClients.UseVisualStyleBackColor = true;
            this.btnAddClients.Click += new System.EventHandler(this.btnAddClients_Click);
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
            // btnDeleteClient
            // 
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteClient.Location = new System.Drawing.Point(684, 439);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(186, 33);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Sterge client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 556);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.lblNumar);
            this.Controls.Add(this.btnAddClients);
            this.Controls.Add(this.dataGridClients);
            this.Name = "FormClients";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.Button btnAddClients;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.ErrorProvider errorProviderDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.Button btnDeleteClient;
    }
}