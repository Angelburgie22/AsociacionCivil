
namespace AsociacionCivil
{
    partial class Admin
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.mbtnAssignUser = new MaterialSkin.Controls.MaterialButton();
            this.mbtnUpdateAdmin = new MaterialSkin.Controls.MaterialButton();
            this.mbtnInsertNewAdmin = new MaterialSkin.Controls.MaterialButton();
            this.asociacioncivilDataSet = new AsociacionCivil.asociacioncivilDataSet();
            this.administradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administradorTableAdapter = new AsociacionCivil.asociacioncivilDataSetTableAdapters.administradorTableAdapter();
            this.admidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admrfcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidomatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechasalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admidDataGridViewTextBoxColumn,
            this.admrfcDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidopatDataGridViewTextBoxColumn,
            this.apellidomatDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.calleDataGridViewTextBoxColumn,
            this.numintDataGridViewTextBoxColumn,
            this.numextDataGridViewTextBoxColumn,
            this.codigopostalDataGridViewTextBoxColumn,
            this.coloniaDataGridViewTextBoxColumn,
            this.ciudadidDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.fechainicioDataGridViewTextBoxColumn,
            this.fechasalidaDataGridViewTextBoxColumn});
            this.dgvAdmin.DataSource = this.administradorBindingSource;
            this.dgvAdmin.Location = new System.Drawing.Point(12, 50);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(872, 473);
            this.dgvAdmin.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.mbtnAssignUser);
            this.pnlHeader.Controls.Add(this.mbtnUpdateAdmin);
            this.pnlHeader.Controls.Add(this.mbtnInsertNewAdmin);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(896, 49);
            this.pnlHeader.TabIndex = 2;
            // 
            // mbtnAssignUser
            // 
            this.mbtnAssignUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAssignUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAssignUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnAssignUser.Depth = 0;
            this.mbtnAssignUser.HighEmphasis = true;
            this.mbtnAssignUser.Icon = null;
            this.mbtnAssignUser.Location = new System.Drawing.Point(366, 6);
            this.mbtnAssignUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAssignUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAssignUser.Name = "mbtnAssignUser";
            this.mbtnAssignUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnAssignUser.Size = new System.Drawing.Size(148, 36);
            this.mbtnAssignUser.TabIndex = 4;
            this.mbtnAssignUser.Text = "Asignar usuario";
            this.mbtnAssignUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnAssignUser.UseAccentColor = false;
            this.mbtnAssignUser.UseVisualStyleBackColor = true;
            this.mbtnAssignUser.Click += new System.EventHandler(this.mbtnAssignUser_Click);
            // 
            // mbtnUpdateAdmin
            // 
            this.mbtnUpdateAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnUpdateAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnUpdateAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnUpdateAdmin.Depth = 0;
            this.mbtnUpdateAdmin.HighEmphasis = true;
            this.mbtnUpdateAdmin.Icon = null;
            this.mbtnUpdateAdmin.Location = new System.Drawing.Point(534, 6);
            this.mbtnUpdateAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnUpdateAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnUpdateAdmin.Name = "mbtnUpdateAdmin";
            this.mbtnUpdateAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnUpdateAdmin.Size = new System.Drawing.Size(109, 36);
            this.mbtnUpdateAdmin.TabIndex = 3;
            this.mbtnUpdateAdmin.Text = "Actualizar";
            this.mbtnUpdateAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnUpdateAdmin.UseAccentColor = false;
            this.mbtnUpdateAdmin.UseVisualStyleBackColor = true;
            this.mbtnUpdateAdmin.Click += new System.EventHandler(this.mbtnUpdateAdmin_Click);
            // 
            // mbtnInsertNewAdmin
            // 
            this.mbtnInsertNewAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnInsertNewAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnInsertNewAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnInsertNewAdmin.Depth = 0;
            this.mbtnInsertNewAdmin.HighEmphasis = true;
            this.mbtnInsertNewAdmin.Icon = null;
            this.mbtnInsertNewAdmin.Location = new System.Drawing.Point(664, 6);
            this.mbtnInsertNewAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnInsertNewAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnInsertNewAdmin.Name = "mbtnInsertNewAdmin";
            this.mbtnInsertNewAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnInsertNewAdmin.Size = new System.Drawing.Size(219, 36);
            this.mbtnInsertNewAdmin.TabIndex = 2;
            this.mbtnInsertNewAdmin.Text = "Registrar administrador";
            this.mbtnInsertNewAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnInsertNewAdmin.UseAccentColor = false;
            this.mbtnInsertNewAdmin.UseVisualStyleBackColor = true;
            this.mbtnInsertNewAdmin.Click += new System.EventHandler(this.mbtnInsertNewAdmin_Click);
            // 
            // asociacioncivilDataSet
            // 
            this.asociacioncivilDataSet.DataSetName = "asociacioncivilDataSet";
            this.asociacioncivilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administradorBindingSource
            // 
            this.administradorBindingSource.DataMember = "administrador";
            this.administradorBindingSource.DataSource = this.asociacioncivilDataSet;
            // 
            // administradorTableAdapter
            // 
            this.administradorTableAdapter.ClearBeforeFill = true;
            // 
            // admidDataGridViewTextBoxColumn
            // 
            this.admidDataGridViewTextBoxColumn.DataPropertyName = "adm_id";
            this.admidDataGridViewTextBoxColumn.HeaderText = "adm_id";
            this.admidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.admidDataGridViewTextBoxColumn.Name = "admidDataGridViewTextBoxColumn";
            this.admidDataGridViewTextBoxColumn.ReadOnly = true;
            this.admidDataGridViewTextBoxColumn.Width = 125;
            // 
            // admrfcDataGridViewTextBoxColumn
            // 
            this.admrfcDataGridViewTextBoxColumn.DataPropertyName = "adm_rfc";
            this.admrfcDataGridViewTextBoxColumn.HeaderText = "adm_rfc";
            this.admrfcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.admrfcDataGridViewTextBoxColumn.Name = "admrfcDataGridViewTextBoxColumn";
            this.admrfcDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidopatDataGridViewTextBoxColumn
            // 
            this.apellidopatDataGridViewTextBoxColumn.DataPropertyName = "apellido_pat";
            this.apellidopatDataGridViewTextBoxColumn.HeaderText = "apellido_pat";
            this.apellidopatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidopatDataGridViewTextBoxColumn.Name = "apellidopatDataGridViewTextBoxColumn";
            this.apellidopatDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidomatDataGridViewTextBoxColumn
            // 
            this.apellidomatDataGridViewTextBoxColumn.DataPropertyName = "apellido_mat";
            this.apellidomatDataGridViewTextBoxColumn.HeaderText = "apellido_mat";
            this.apellidomatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidomatDataGridViewTextBoxColumn.Name = "apellidomatDataGridViewTextBoxColumn";
            this.apellidomatDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // calleDataGridViewTextBoxColumn
            // 
            this.calleDataGridViewTextBoxColumn.DataPropertyName = "calle";
            this.calleDataGridViewTextBoxColumn.HeaderText = "calle";
            this.calleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            this.calleDataGridViewTextBoxColumn.Width = 125;
            // 
            // numintDataGridViewTextBoxColumn
            // 
            this.numintDataGridViewTextBoxColumn.DataPropertyName = "num_int";
            this.numintDataGridViewTextBoxColumn.HeaderText = "num_int";
            this.numintDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numintDataGridViewTextBoxColumn.Name = "numintDataGridViewTextBoxColumn";
            this.numintDataGridViewTextBoxColumn.Width = 125;
            // 
            // numextDataGridViewTextBoxColumn
            // 
            this.numextDataGridViewTextBoxColumn.DataPropertyName = "num_ext";
            this.numextDataGridViewTextBoxColumn.HeaderText = "num_ext";
            this.numextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numextDataGridViewTextBoxColumn.Name = "numextDataGridViewTextBoxColumn";
            this.numextDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigopostalDataGridViewTextBoxColumn
            // 
            this.codigopostalDataGridViewTextBoxColumn.DataPropertyName = "codigo_postal";
            this.codigopostalDataGridViewTextBoxColumn.HeaderText = "codigo_postal";
            this.codigopostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigopostalDataGridViewTextBoxColumn.Name = "codigopostalDataGridViewTextBoxColumn";
            this.codigopostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // coloniaDataGridViewTextBoxColumn
            // 
            this.coloniaDataGridViewTextBoxColumn.DataPropertyName = "colonia";
            this.coloniaDataGridViewTextBoxColumn.HeaderText = "colonia";
            this.coloniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coloniaDataGridViewTextBoxColumn.Name = "coloniaDataGridViewTextBoxColumn";
            this.coloniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ciudadidDataGridViewTextBoxColumn
            // 
            this.ciudadidDataGridViewTextBoxColumn.DataPropertyName = "ciudad_id";
            this.ciudadidDataGridViewTextBoxColumn.HeaderText = "ciudad_id";
            this.ciudadidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ciudadidDataGridViewTextBoxColumn.Name = "ciudadidDataGridViewTextBoxColumn";
            this.ciudadidDataGridViewTextBoxColumn.Width = 125;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "estatus";
            this.estatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechainicioDataGridViewTextBoxColumn
            // 
            this.fechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            this.fechainicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechasalidaDataGridViewTextBoxColumn
            // 
            this.fechasalidaDataGridViewTextBoxColumn.DataPropertyName = "fecha_salida";
            this.fechasalidaDataGridViewTextBoxColumn.HeaderText = "fecha_salida";
            this.fechasalidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechasalidaDataGridViewTextBoxColumn.Name = "fechasalidaDataGridViewTextBoxColumn";
            this.fechasalidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 537);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton mbtnInsertNewAdmin;
        private MaterialSkin.Controls.MaterialButton mbtnUpdateAdmin;
        private MaterialSkin.Controls.MaterialButton mbtnAssignUser;
        private asociacioncivilDataSet asociacioncivilDataSet;
        private System.Windows.Forms.BindingSource administradorBindingSource;
        private asociacioncivilDataSetTableAdapters.administradorTableAdapter administradorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn admidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admrfcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidomatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasalidaDataGridViewTextBoxColumn;
    }
}