
namespace AsociacionCivil
{
    partial class Period
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
            this.dgvPeriod = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.mmbtnCreatePeriod = new MaterialSkin.Controls.MaterialButton();
            this.asociacioncivilDataSet = new AsociacionCivil.asociacioncivilDataSet();
            this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodoTableAdapter = new AsociacionCivil.asociacioncivilDataSetTableAdapters.periodoTableAdapter();
            this.percodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perinicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriod)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeriod
            // 
            this.dgvPeriod.AutoGenerateColumns = false;
            this.dgvPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.percodigoDataGridViewTextBoxColumn,
            this.perinicioDataGridViewTextBoxColumn,
            this.perfinDataGridViewTextBoxColumn});
            this.dgvPeriod.DataSource = this.periodoBindingSource;
            this.dgvPeriod.Location = new System.Drawing.Point(230, 53);
            this.dgvPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPeriod.Name = "dgvPeriod";
            this.dgvPeriod.RowHeadersWidth = 51;
            this.dgvPeriod.RowTemplate.Height = 24;
            this.dgvPeriod.Size = new System.Drawing.Size(427, 473);
            this.dgvPeriod.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.mmbtnCreatePeriod);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(896, 49);
            this.pnlHeader.TabIndex = 2;
            // 
            // mmbtnCreatePeriod
            // 
            this.mmbtnCreatePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mmbtnCreatePeriod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mmbtnCreatePeriod.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mmbtnCreatePeriod.Depth = 0;
            this.mmbtnCreatePeriod.HighEmphasis = true;
            this.mmbtnCreatePeriod.Icon = null;
            this.mmbtnCreatePeriod.Location = new System.Drawing.Point(703, 6);
            this.mmbtnCreatePeriod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mmbtnCreatePeriod.MouseState = MaterialSkin.MouseState.HOVER;
            this.mmbtnCreatePeriod.Name = "mmbtnCreatePeriod";
            this.mmbtnCreatePeriod.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mmbtnCreatePeriod.Size = new System.Drawing.Size(180, 36);
            this.mmbtnCreatePeriod.TabIndex = 2;
            this.mmbtnCreatePeriod.Text = "Abrir nuevo periodo";
            this.mmbtnCreatePeriod.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mmbtnCreatePeriod.UseAccentColor = false;
            this.mmbtnCreatePeriod.UseVisualStyleBackColor = true;
            this.mmbtnCreatePeriod.Click += new System.EventHandler(this.mbtnCreatePeriod_Click);
            // 
            // asociacioncivilDataSet
            // 
            this.asociacioncivilDataSet.DataSetName = "asociacioncivilDataSet";
            this.asociacioncivilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periodoBindingSource
            // 
            this.periodoBindingSource.DataMember = "periodo";
            this.periodoBindingSource.DataSource = this.asociacioncivilDataSet;
            // 
            // periodoTableAdapter
            // 
            this.periodoTableAdapter.ClearBeforeFill = true;
            // 
            // percodigoDataGridViewTextBoxColumn
            // 
            this.percodigoDataGridViewTextBoxColumn.DataPropertyName = "per_codigo";
            this.percodigoDataGridViewTextBoxColumn.HeaderText = "per_codigo";
            this.percodigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.percodigoDataGridViewTextBoxColumn.Name = "percodigoDataGridViewTextBoxColumn";
            this.percodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.percodigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // perinicioDataGridViewTextBoxColumn
            // 
            this.perinicioDataGridViewTextBoxColumn.DataPropertyName = "per_inicio";
            this.perinicioDataGridViewTextBoxColumn.HeaderText = "per_inicio";
            this.perinicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perinicioDataGridViewTextBoxColumn.Name = "perinicioDataGridViewTextBoxColumn";
            this.perinicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // perfinDataGridViewTextBoxColumn
            // 
            this.perfinDataGridViewTextBoxColumn.DataPropertyName = "per_fin";
            this.perfinDataGridViewTextBoxColumn.HeaderText = "per_fin";
            this.perfinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perfinDataGridViewTextBoxColumn.Name = "perfinDataGridViewTextBoxColumn";
            this.perfinDataGridViewTextBoxColumn.Width = 125;
            // 
            // Period
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 537);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvPeriod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Period";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Period_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriod)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeriod;
        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton mmbtnCreatePeriod;
        private asociacioncivilDataSet asociacioncivilDataSet;
        private System.Windows.Forms.BindingSource periodoBindingSource;
        private asociacioncivilDataSetTableAdapters.periodoTableAdapter periodoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn percodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perinicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfinDataGridViewTextBoxColumn;
    }
}