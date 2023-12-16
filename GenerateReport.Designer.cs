
namespace AsociacionCivil
{
    partial class GenerateReport
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.mbtnGenerateReceipt = new MaterialSkin.Controls.MaterialButton();
            this.pnlFormContainer = new System.Windows.Forms.Panel();
            this.lblOrientation = new System.Windows.Forms.Label();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.mtxtFileName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.cmbOrientation = new System.Windows.Forms.ComboBox();
            this.pnlReceiptLoader = new System.Windows.Forms.Panel();
            this.mbtnSendEmail = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCreateExcel = new MaterialSkin.Controls.MaterialButton();
            this.pnlFooter.SuspendLayout();
            this.pnlFormContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.mbtnCreateExcel);
            this.pnlFooter.Controls.Add(this.mbtnSendEmail);
            this.pnlFooter.Controls.Add(this.mbtnCancel);
            this.pnlFooter.Controls.Add(this.mbtnGenerateReceipt);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 773);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(493, 62);
            this.pnlFooter.TabIndex = 3;
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.HighEmphasis = true;
            this.mbtnCancel.Icon = null;
            this.mbtnCancel.Location = new System.Drawing.Point(33, 11);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCancel.Size = new System.Drawing.Size(96, 36);
            this.mbtnCancel.TabIndex = 1;
            this.mbtnCancel.Text = "Cancelar";
            this.mbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCancel.UseAccentColor = false;
            this.mbtnCancel.UseVisualStyleBackColor = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnGenerateReceipt
            // 
            this.mbtnGenerateReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnGenerateReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnGenerateReceipt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnGenerateReceipt.Depth = 0;
            this.mbtnGenerateReceipt.HighEmphasis = true;
            this.mbtnGenerateReceipt.Icon = null;
            this.mbtnGenerateReceipt.Location = new System.Drawing.Point(393, 11);
            this.mbtnGenerateReceipt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnGenerateReceipt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnGenerateReceipt.Name = "mbtnGenerateReceipt";
            this.mbtnGenerateReceipt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnGenerateReceipt.Size = new System.Drawing.Size(87, 36);
            this.mbtnGenerateReceipt.TabIndex = 0;
            this.mbtnGenerateReceipt.Text = "Imprimir";
            this.mbtnGenerateReceipt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnGenerateReceipt.UseAccentColor = false;
            this.mbtnGenerateReceipt.UseVisualStyleBackColor = true;
            this.mbtnGenerateReceipt.Click += new System.EventHandler(this.mbtnGenerateReceipt_Click);
            // 
            // pnlFormContainer
            // 
            this.pnlFormContainer.AutoScroll = true;
            this.pnlFormContainer.AutoSize = true;
            this.pnlFormContainer.Controls.Add(this.lblOrientation);
            this.pnlFormContainer.Controls.Add(this.lblTitleForm);
            this.pnlFormContainer.Controls.Add(this.mtxtFileName);
            this.pnlFormContainer.Controls.Add(this.lblFileName);
            this.pnlFormContainer.Controls.Add(this.cmbOrientation);
            this.pnlFormContainer.Controls.Add(this.pnlReceiptLoader);
            this.pnlFormContainer.Controls.Add(this.pnlFooter);
            this.pnlFormContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlFormContainer.Name = "pnlFormContainer";
            this.pnlFormContainer.Size = new System.Drawing.Size(493, 835);
            this.pnlFormContainer.TabIndex = 4;
            // 
            // lblOrientation
            // 
            this.lblOrientation.AutoSize = true;
            this.lblOrientation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrientation.Location = new System.Drawing.Point(16, 76);
            this.lblOrientation.Name = "lblOrientation";
            this.lblOrientation.Size = new System.Drawing.Size(103, 23);
            this.lblOrientation.TabIndex = 11;
            this.lblOrientation.Text = "Orientación:";
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.Location = new System.Drawing.Point(12, 9);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(248, 45);
            this.lblTitleForm.TabIndex = 10;
            this.lblTitleForm.Text = "Generar recibo";
            // 
            // mtxtFileName
            // 
            this.mtxtFileName.AnimateReadOnly = false;
            this.mtxtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtFileName.Depth = 0;
            this.mtxtFileName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtFileName.LeadingIcon = null;
            this.mtxtFileName.Location = new System.Drawing.Point(184, 110);
            this.mtxtFileName.MaxLength = 50;
            this.mtxtFileName.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtFileName.Multiline = false;
            this.mtxtFileName.Name = "mtxtFileName";
            this.mtxtFileName.Size = new System.Drawing.Size(165, 50);
            this.mtxtFileName.TabIndex = 9;
            this.mtxtFileName.Text = "";
            this.mtxtFileName.TrailingIcon = null;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(16, 124);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(162, 23);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.Text = "Nombre de archivo:";
            // 
            // cmbOrientation
            // 
            this.cmbOrientation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrientation.FormattingEnabled = true;
            this.cmbOrientation.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.cmbOrientation.Location = new System.Drawing.Point(120, 73);
            this.cmbOrientation.Name = "cmbOrientation";
            this.cmbOrientation.Size = new System.Drawing.Size(121, 31);
            this.cmbOrientation.TabIndex = 7;
            // 
            // pnlReceiptLoader
            // 
            this.pnlReceiptLoader.Location = new System.Drawing.Point(0, 190);
            this.pnlReceiptLoader.Name = "pnlReceiptLoader";
            this.pnlReceiptLoader.Size = new System.Drawing.Size(490, 583);
            this.pnlReceiptLoader.TabIndex = 4;
            // 
            // mbtnSendEmail
            // 
            this.mbtnSendEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnSendEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSendEmail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnSendEmail.Depth = 0;
            this.mbtnSendEmail.HighEmphasis = true;
            this.mbtnSendEmail.Icon = null;
            this.mbtnSendEmail.Location = new System.Drawing.Point(265, 11);
            this.mbtnSendEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnSendEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSendEmail.Name = "mbtnSendEmail";
            this.mbtnSendEmail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnSendEmail.Size = new System.Drawing.Size(120, 36);
            this.mbtnSendEmail.TabIndex = 2;
            this.mbtnSendEmail.Text = "Enviar Email";
            this.mbtnSendEmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnSendEmail.UseAccentColor = false;
            this.mbtnSendEmail.UseVisualStyleBackColor = true;
            this.mbtnSendEmail.Click += new System.EventHandler(this.mbtnSendEmail_Click);
            // 
            // mbtnCreateExcel
            // 
            this.mbtnCreateExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnCreateExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCreateExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCreateExcel.Depth = 0;
            this.mbtnCreateExcel.HighEmphasis = true;
            this.mbtnCreateExcel.Icon = null;
            this.mbtnCreateExcel.Location = new System.Drawing.Point(137, 11);
            this.mbtnCreateExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCreateExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCreateExcel.Name = "mbtnCreateExcel";
            this.mbtnCreateExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCreateExcel.Size = new System.Drawing.Size(120, 36);
            this.mbtnCreateExcel.TabIndex = 3;
            this.mbtnCreateExcel.Text = "Enviar Excel";
            this.mbtnCreateExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCreateExcel.UseAccentColor = false;
            this.mbtnCreateExcel.UseVisualStyleBackColor = true;
            this.mbtnCreateExcel.Click += new System.EventHandler(this.mbtnCreateExcel_Click);
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 836);
            this.Controls.Add(this.pnlFormContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateReport";
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlFormContainer.ResumeLayout(false);
            this.pnlFormContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFooter;
        private MaterialSkin.Controls.MaterialButton mbtnGenerateReceipt;
        private System.Windows.Forms.Panel pnlFormContainer;
        private System.Windows.Forms.Label lblOrientation;
        private System.Windows.Forms.Label lblTitleForm;
        private MaterialSkin.Controls.MaterialTextBox mtxtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ComboBox cmbOrientation;
        private System.Windows.Forms.Panel pnlReceiptLoader;
        private MaterialSkin.Controls.MaterialButton mbtnCancel;
        private MaterialSkin.Controls.MaterialButton mbtnCreateExcel;
        private MaterialSkin.Controls.MaterialButton mbtnSendEmail;
    }
}