
namespace AsociacionCivil
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPartner = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.mbtnInsert = new MaterialSkin.Controls.MaterialButton();
            this.asociacioncivilDataSet = new AsociacionCivil.asociacioncivilDataSet();
            this.reciboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reciboTableAdapter = new AsociacionCivil.asociacioncivilDataSetTableAdapters.reciboTableAdapter();
            this.recfolioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importepesosmxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeletraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socrfcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlSelection);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnPartner);
            this.pnlMenu.Controls.Add(this.btnReceipt);
            this.pnlMenu.Controls.Add(this.pnlUsername);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(248, 710);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlSelection.Location = new System.Drawing.Point(0, 238);
            this.pnlSelection.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(4, 123);
            this.pnlSelection.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 658);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(248, 52);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.Leave += new System.EventHandler(this.btnLogout_Leave);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 346);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(248, 52);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Configuracion";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 294);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(248, 52);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administradores";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            this.btnAdmin.Leave += new System.EventHandler(this.btnAdmin_Leave);
            // 
            // btnPartner
            // 
            this.btnPartner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartner.FlatAppearance.BorderSize = 0;
            this.btnPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartner.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner.ForeColor = System.Drawing.Color.White;
            this.btnPartner.Location = new System.Drawing.Point(0, 242);
            this.btnPartner.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartner.Name = "btnPartner";
            this.btnPartner.Size = new System.Drawing.Size(248, 52);
            this.btnPartner.TabIndex = 1;
            this.btnPartner.Text = "Socios";
            this.btnPartner.UseVisualStyleBackColor = true;
            this.btnPartner.Click += new System.EventHandler(this.btnPartner_Click);
            this.btnPartner.Leave += new System.EventHandler(this.btnPartner_Leave);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Location = new System.Drawing.Point(0, 190);
            this.btnReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(248, 52);
            this.btnReceipt.TabIndex = 1;
            this.btnReceipt.Text = "Recibos";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            this.btnReceipt.Leave += new System.EventHandler(this.btnReceipt_Leave);
            // 
            // pnlUsername
            // 
            this.pnlUsername.Controls.Add(this.lblText);
            this.pnlUsername.Controls.Add(this.lblUsername);
            this.pnlUsername.Controls.Add(this.picUser);
            this.pnlUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsername.Location = new System.Drawing.Point(0, 0);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(248, 190);
            this.pnlUsername.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Silver;
            this.lblText.Location = new System.Drawing.Point(73, 143);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(96, 15);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Texto Usuario";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(85, 119);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Usuario";
            // 
            // picUser
            // 
            this.picUser.Image = global::AsociacionCivil.Properties.Resources.memes;
            this.picUser.Location = new System.Drawing.Point(80, 27);
            this.picUser.Margin = new System.Windows.Forms.Padding(4);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(84, 78);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(287, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Recibos";
            // 
            // dgvTable
            // 
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recfolioDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.importepesosmxDataGridViewTextBoxColumn,
            this.importeletraDataGridViewTextBoxColumn,
            this.percodigoDataGridViewTextBoxColumn,
            this.socrfcDataGridViewTextBoxColumn});
            this.dgvTable.DataSource = this.reciboBindingSource;
            this.dgvTable.Location = new System.Drawing.Point(259, 143);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.Size = new System.Drawing.Size(996, 458);
            this.dgvTable.TabIndex = 2;
            // 
            // mbtnInsert
            // 
            this.mbtnInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnInsert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnInsert.Depth = 0;
            this.mbtnInsert.HighEmphasis = true;
            this.mbtnInsert.Icon = null;
            this.mbtnInsert.Location = new System.Drawing.Point(1035, 87);
            this.mbtnInsert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnInsert.Name = "mbtnInsert";
            this.mbtnInsert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnInsert.Size = new System.Drawing.Size(90, 36);
            this.mbtnInsert.TabIndex = 3;
            this.mbtnInsert.Text = "Insertar";
            this.mbtnInsert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnInsert.UseAccentColor = false;
            this.mbtnInsert.UseVisualStyleBackColor = true;
            // 
            // asociacioncivilDataSet
            // 
            this.asociacioncivilDataSet.DataSetName = "asociacioncivilDataSet";
            this.asociacioncivilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reciboBindingSource
            // 
            this.reciboBindingSource.DataMember = "recibo";
            this.reciboBindingSource.DataSource = this.asociacioncivilDataSet;
            // 
            // reciboTableAdapter
            // 
            this.reciboTableAdapter.ClearBeforeFill = true;
            // 
            // recfolioDataGridViewTextBoxColumn
            // 
            this.recfolioDataGridViewTextBoxColumn.DataPropertyName = "rec_folio";
            this.recfolioDataGridViewTextBoxColumn.HeaderText = "rec_folio";
            this.recfolioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recfolioDataGridViewTextBoxColumn.Name = "recfolioDataGridViewTextBoxColumn";
            this.recfolioDataGridViewTextBoxColumn.Width = 125;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "estatus";
            this.estatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // importepesosmxDataGridViewTextBoxColumn
            // 
            this.importepesosmxDataGridViewTextBoxColumn.DataPropertyName = "importe_pesos_mx";
            this.importepesosmxDataGridViewTextBoxColumn.HeaderText = "importe_pesos_mx";
            this.importepesosmxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importepesosmxDataGridViewTextBoxColumn.Name = "importepesosmxDataGridViewTextBoxColumn";
            this.importepesosmxDataGridViewTextBoxColumn.Width = 125;
            // 
            // importeletraDataGridViewTextBoxColumn
            // 
            this.importeletraDataGridViewTextBoxColumn.DataPropertyName = "importe_letra";
            this.importeletraDataGridViewTextBoxColumn.HeaderText = "importe_letra";
            this.importeletraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importeletraDataGridViewTextBoxColumn.Name = "importeletraDataGridViewTextBoxColumn";
            this.importeletraDataGridViewTextBoxColumn.Width = 125;
            // 
            // percodigoDataGridViewTextBoxColumn
            // 
            this.percodigoDataGridViewTextBoxColumn.DataPropertyName = "per_codigo";
            this.percodigoDataGridViewTextBoxColumn.HeaderText = "per_codigo";
            this.percodigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.percodigoDataGridViewTextBoxColumn.Name = "percodigoDataGridViewTextBoxColumn";
            this.percodigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // socrfcDataGridViewTextBoxColumn
            // 
            this.socrfcDataGridViewTextBoxColumn.DataPropertyName = "soc_rfc";
            this.socrfcDataGridViewTextBoxColumn.HeaderText = "soc_rfc";
            this.socrfcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.socrfcDataGridViewTextBoxColumn.Name = "socrfcDataGridViewTextBoxColumn";
            this.socrfcDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 710);
            this.Controls.Add(this.mbtnInsert);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPartner;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvTable;
        private MaterialSkin.Controls.MaterialButton mbtnInsert;
        private asociacioncivilDataSet asociacioncivilDataSet;
        private System.Windows.Forms.BindingSource reciboBindingSource;
        private asociacioncivilDataSetTableAdapters.reciboTableAdapter reciboTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recfolioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importepesosmxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeletraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socrfcDataGridViewTextBoxColumn;
    }
}

