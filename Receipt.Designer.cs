
namespace AsociacionCivil
{
    partial class Receipt
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
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.mbtnUpdateReceipt = new MaterialSkin.Controls.MaterialButton();
            this.mbtnGenerateReport = new MaterialSkin.Controls.MaterialButton();
            this.mbtnInsertNewReceipt = new MaterialSkin.Controls.MaterialButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceipt.AutoGenerateColumns = false;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recfolioDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.importepesosmxDataGridViewTextBoxColumn,
            this.importeletraDataGridViewTextBoxColumn,
            this.percodigoDataGridViewTextBoxColumn,
            this.socrfcDataGridViewTextBoxColumn});
            this.dgvReceipt.DataSource = this.reciboBindingSource;
            this.dgvReceipt.Location = new System.Drawing.Point(12, 51);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(872, 473);
            this.dgvReceipt.TabIndex = 0;
            this.dgvReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellContentClick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.mbtnUpdateReceipt);
            this.pnlHeader.Controls.Add(this.mbtnGenerateReport);
            this.pnlHeader.Controls.Add(this.mbtnInsertNewReceipt);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(896, 49);
            this.pnlHeader.TabIndex = 2;
            // 
            // mbtnUpdateReceipt
            // 
            this.mbtnUpdateReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnUpdateReceipt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnUpdateReceipt.Depth = 0;
            this.mbtnUpdateReceipt.HighEmphasis = true;
            this.mbtnUpdateReceipt.Icon = null;
            this.mbtnUpdateReceipt.Location = new System.Drawing.Point(397, 7);
            this.mbtnUpdateReceipt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnUpdateReceipt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnUpdateReceipt.Name = "mbtnUpdateReceipt";
            this.mbtnUpdateReceipt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnUpdateReceipt.Size = new System.Drawing.Size(109, 36);
            this.mbtnUpdateReceipt.TabIndex = 4;
            this.mbtnUpdateReceipt.Text = "Actualizar";
            this.mbtnUpdateReceipt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnUpdateReceipt.UseAccentColor = false;
            this.mbtnUpdateReceipt.UseVisualStyleBackColor = true;
            this.mbtnUpdateReceipt.Visible = false;
            this.mbtnUpdateReceipt.Click += new System.EventHandler(this.mbtnUpdateReceipt_Click);
            // 
            // mbtnGenerateReport
            // 
            this.mbtnGenerateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnGenerateReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnGenerateReport.Depth = 0;
            this.mbtnGenerateReport.HighEmphasis = true;
            this.mbtnGenerateReport.Icon = null;
            this.mbtnGenerateReport.Location = new System.Drawing.Point(564, 6);
            this.mbtnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnGenerateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnGenerateReport.Name = "mbtnGenerateReport";
            this.mbtnGenerateReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnGenerateReport.Size = new System.Drawing.Size(154, 36);
            this.mbtnGenerateReport.TabIndex = 3;
            this.mbtnGenerateReport.Text = "Generar reporte";
            this.mbtnGenerateReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnGenerateReport.UseAccentColor = false;
            this.mbtnGenerateReport.UseVisualStyleBackColor = true;
            this.mbtnGenerateReport.Visible = false;
            this.mbtnGenerateReport.Click += new System.EventHandler(this.mbtnGenerateReport_Click);
            // 
            // mbtnInsertNewReceipt
            // 
            this.mbtnInsertNewReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnInsertNewReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnInsertNewReceipt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnInsertNewReceipt.Depth = 0;
            this.mbtnInsertNewReceipt.HighEmphasis = true;
            this.mbtnInsertNewReceipt.Icon = null;
            this.mbtnInsertNewReceipt.Location = new System.Drawing.Point(730, 6);
            this.mbtnInsertNewReceipt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnInsertNewReceipt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnInsertNewReceipt.Name = "mbtnInsertNewReceipt";
            this.mbtnInsertNewReceipt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnInsertNewReceipt.Size = new System.Drawing.Size(153, 36);
            this.mbtnInsertNewReceipt.TabIndex = 2;
            this.mbtnInsertNewReceipt.Text = "Registrar recibo";
            this.mbtnInsertNewReceipt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnInsertNewReceipt.UseAccentColor = false;
            this.mbtnInsertNewReceipt.UseVisualStyleBackColor = true;
            this.mbtnInsertNewReceipt.Click += new System.EventHandler(this.mbtnInsertNewReceipt_Click);
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
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 536);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton mbtnInsertNewReceipt;
        private MaterialSkin.Controls.MaterialButton mbtnGenerateReport;
        private MaterialSkin.Controls.MaterialButton mbtnUpdateReceipt;
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