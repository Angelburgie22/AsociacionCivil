
namespace AsociacionCivil
{
    partial class Partner
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
            this.dgvPartner = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.mbtnUpdatePartner = new MaterialSkin.Controls.MaterialButton();
            this.mbtnDetails = new MaterialSkin.Controls.MaterialButton();
            this.mbtnInsertNewPartner = new MaterialSkin.Controls.MaterialButton();
            this.asociacioncivilDataSet = new AsociacionCivil.asociacioncivilDataSet();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter = new AsociacionCivil.asociacioncivilDataSetTableAdapters.socioTableAdapter();
            this.socrfcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.estatusasociacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaingresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechasalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartner)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartner
            // 
            this.dgvPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPartner.AutoGenerateColumns = false;
            this.dgvPartner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.socrfcDataGridViewTextBoxColumn,
            this.tipopersonaDataGridViewTextBoxColumn,
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
            this.estatusasociacionDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.fechaingresoDataGridViewTextBoxColumn,
            this.fechasalidaDataGridViewTextBoxColumn});
            this.dgvPartner.DataSource = this.socioBindingSource;
            this.dgvPartner.Location = new System.Drawing.Point(12, 51);
            this.dgvPartner.Name = "dgvPartner";
            this.dgvPartner.RowHeadersWidth = 51;
            this.dgvPartner.RowTemplate.Height = 24;
            this.dgvPartner.Size = new System.Drawing.Size(872, 473);
            this.dgvPartner.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.mbtnUpdatePartner);
            this.pnlHeader.Controls.Add(this.mbtnDetails);
            this.pnlHeader.Controls.Add(this.mbtnInsertNewPartner);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(896, 49);
            this.pnlHeader.TabIndex = 2;
            // 
            // mbtnUpdatePartner
            // 
            this.mbtnUpdatePartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnUpdatePartner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnUpdatePartner.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnUpdatePartner.Depth = 0;
            this.mbtnUpdatePartner.HighEmphasis = true;
            this.mbtnUpdatePartner.Icon = null;
            this.mbtnUpdatePartner.Location = new System.Drawing.Point(498, 6);
            this.mbtnUpdatePartner.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnUpdatePartner.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnUpdatePartner.Name = "mbtnUpdatePartner";
            this.mbtnUpdatePartner.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnUpdatePartner.Size = new System.Drawing.Size(109, 36);
            this.mbtnUpdatePartner.TabIndex = 4;
            this.mbtnUpdatePartner.Text = "Actualizar";
            this.mbtnUpdatePartner.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnUpdatePartner.UseAccentColor = false;
            this.mbtnUpdatePartner.UseVisualStyleBackColor = true;
            this.mbtnUpdatePartner.Click += new System.EventHandler(this.mbtnUpdatePartner_Click);
            // 
            // mbtnDetails
            // 
            this.mbtnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnDetails.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnDetails.Depth = 0;
            this.mbtnDetails.HighEmphasis = true;
            this.mbtnDetails.Icon = null;
            this.mbtnDetails.Location = new System.Drawing.Point(629, 6);
            this.mbtnDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnDetails.Name = "mbtnDetails";
            this.mbtnDetails.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnDetails.Size = new System.Drawing.Size(91, 36);
            this.mbtnDetails.TabIndex = 3;
            this.mbtnDetails.Text = "Detalles";
            this.mbtnDetails.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnDetails.UseAccentColor = false;
            this.mbtnDetails.UseVisualStyleBackColor = true;
            this.mbtnDetails.Click += new System.EventHandler(this.mbtnDetails_Click);
            // 
            // mbtnInsertNewPartner
            // 
            this.mbtnInsertNewPartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnInsertNewPartner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnInsertNewPartner.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnInsertNewPartner.Depth = 0;
            this.mbtnInsertNewPartner.HighEmphasis = true;
            this.mbtnInsertNewPartner.Icon = null;
            this.mbtnInsertNewPartner.Location = new System.Drawing.Point(737, 6);
            this.mbtnInsertNewPartner.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnInsertNewPartner.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnInsertNewPartner.Name = "mbtnInsertNewPartner";
            this.mbtnInsertNewPartner.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnInsertNewPartner.Size = new System.Drawing.Size(146, 36);
            this.mbtnInsertNewPartner.TabIndex = 2;
            this.mbtnInsertNewPartner.Text = "Registrar socio";
            this.mbtnInsertNewPartner.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnInsertNewPartner.UseAccentColor = false;
            this.mbtnInsertNewPartner.UseVisualStyleBackColor = true;
            this.mbtnInsertNewPartner.Click += new System.EventHandler(this.mbtnInsertNewPartner_Click);
            // 
            // asociacioncivilDataSet
            // 
            this.asociacioncivilDataSet.DataSetName = "asociacioncivilDataSet";
            this.asociacioncivilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataMember = "socio";
            this.socioBindingSource.DataSource = this.asociacioncivilDataSet;
            // 
            // socioTableAdapter
            // 
            this.socioTableAdapter.ClearBeforeFill = true;
            // 
            // socrfcDataGridViewTextBoxColumn
            // 
            this.socrfcDataGridViewTextBoxColumn.DataPropertyName = "soc_rfc";
            this.socrfcDataGridViewTextBoxColumn.HeaderText = "soc_rfc";
            this.socrfcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.socrfcDataGridViewTextBoxColumn.Name = "socrfcDataGridViewTextBoxColumn";
            this.socrfcDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipopersonaDataGridViewTextBoxColumn
            // 
            this.tipopersonaDataGridViewTextBoxColumn.DataPropertyName = "tipo_persona";
            this.tipopersonaDataGridViewTextBoxColumn.HeaderText = "tipo_persona";
            this.tipopersonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipopersonaDataGridViewTextBoxColumn.Name = "tipopersonaDataGridViewTextBoxColumn";
            this.tipopersonaDataGridViewTextBoxColumn.Width = 125;
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
            // estatusasociacionDataGridViewTextBoxColumn
            // 
            this.estatusasociacionDataGridViewTextBoxColumn.DataPropertyName = "estatus_asociacion";
            this.estatusasociacionDataGridViewTextBoxColumn.HeaderText = "estatus_asociacion";
            this.estatusasociacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estatusasociacionDataGridViewTextBoxColumn.Name = "estatusasociacionDataGridViewTextBoxColumn";
            this.estatusasociacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            this.fechanacimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaingresoDataGridViewTextBoxColumn
            // 
            this.fechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fecha_ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.HeaderText = "fecha_ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaingresoDataGridViewTextBoxColumn.Name = "fechaingresoDataGridViewTextBoxColumn";
            this.fechaingresoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechasalidaDataGridViewTextBoxColumn
            // 
            this.fechasalidaDataGridViewTextBoxColumn.DataPropertyName = "fecha_salida";
            this.fechasalidaDataGridViewTextBoxColumn.HeaderText = "fecha_salida";
            this.fechasalidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechasalidaDataGridViewTextBoxColumn.Name = "fechasalidaDataGridViewTextBoxColumn";
            this.fechasalidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 536);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvPartner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Partner";
            this.Text = "Partner";
            this.Load += new System.EventHandler(this.Partner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartner)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartner;
        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton mbtnInsertNewPartner;
        private MaterialSkin.Controls.MaterialButton mbtnUpdatePartner;
        private MaterialSkin.Controls.MaterialButton mbtnDetails;
        private asociacioncivilDataSet asociacioncivilDataSet;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private asociacioncivilDataSetTableAdapters.socioTableAdapter socioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn socrfcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopersonaDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusasociacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaingresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasalidaDataGridViewTextBoxColumn;
    }
}