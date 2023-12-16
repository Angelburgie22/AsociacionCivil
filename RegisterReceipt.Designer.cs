
namespace AsociacionCivil
{
    partial class RegisterReceipt
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
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.lblReceiptDate = new System.Windows.Forms.Label();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.lblPartner = new System.Windows.Forms.Label();
            this.mcmbPartners = new MaterialSkin.Controls.MaterialComboBox();
            this.mmtxtAmount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnInsertNew = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.pnlNewPartnerForm = new System.Windows.Forms.Panel();
            this.mcmbPeriods = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.mchkAutomaticInvoiceNum = new MaterialSkin.Controls.MaterialCheckbox();
            this.mmtxtInvoiceNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pnlButtonsStrip = new System.Windows.Forms.Panel();
            this.pnlNewPartnerForm.SuspendLayout();
            this.pnlButtonsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.Location = new System.Drawing.Point(24, 27);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(227, 45);
            this.lblTitleForm.TabIndex = 0;
            this.lblTitleForm.Text = "Nuevo recibo";
            // 
            // lblReceiptDate
            // 
            this.lblReceiptDate.AutoSize = true;
            this.lblReceiptDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptDate.Location = new System.Drawing.Point(327, 173);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(134, 23);
            this.lblReceiptDate.TabIndex = 7;
            this.lblReceiptDate.Text = "Fecha de recibo:";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReceiptDate.Enabled = false;
            this.dtpReceiptDate.Location = new System.Drawing.Point(331, 199);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(203, 22);
            this.dtpReceiptDate.TabIndex = 8;
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartner.Location = new System.Drawing.Point(327, 249);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(151, 23);
            this.lblPartner.TabIndex = 14;
            this.lblPartner.Text = "Socio participante:";
            // 
            // mcmbPartners
            // 
            this.mcmbPartners.AutoResize = false;
            this.mcmbPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmbPartners.Depth = 0;
            this.mcmbPartners.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcmbPartners.DropDownHeight = 174;
            this.mcmbPartners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcmbPartners.DropDownWidth = 121;
            this.mcmbPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcmbPartners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcmbPartners.FormattingEnabled = true;
            this.mcmbPartners.IntegralHeight = false;
            this.mcmbPartners.ItemHeight = 43;
            this.mcmbPartners.Location = new System.Drawing.Point(331, 275);
            this.mcmbPartners.MaxDropDownItems = 4;
            this.mcmbPartners.MouseState = MaterialSkin.MouseState.OUT;
            this.mcmbPartners.Name = "mcmbPartners";
            this.mcmbPartners.Size = new System.Drawing.Size(184, 49);
            this.mcmbPartners.StartIndex = 0;
            this.mcmbPartners.TabIndex = 15;
            // 
            // mmtxtAmount
            // 
            this.mmtxtAmount.AllowPromptAsInput = true;
            this.mmtxtAmount.AnimateReadOnly = false;
            this.mmtxtAmount.AsciiOnly = false;
            this.mmtxtAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtAmount.BeepOnError = false;
            this.mmtxtAmount.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtAmount.Depth = 0;
            this.mmtxtAmount.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtAmount.HidePromptOnLeave = false;
            this.mmtxtAmount.HideSelection = true;
            this.mmtxtAmount.Hint = "Importe (MX)";
            this.mmtxtAmount.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtAmount.LeadingIcon = null;
            this.mmtxtAmount.Location = new System.Drawing.Point(32, 275);
            this.mmtxtAmount.Mask = "";
            this.mmtxtAmount.MaxLength = 32767;
            this.mmtxtAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtAmount.Name = "mmtxtAmount";
            this.mmtxtAmount.PasswordChar = '\0';
            this.mmtxtAmount.PrefixSuffixText = null;
            this.mmtxtAmount.PromptChar = '_';
            this.mmtxtAmount.ReadOnly = false;
            this.mmtxtAmount.RejectInputOnFirstFailure = false;
            this.mmtxtAmount.ResetOnPrompt = true;
            this.mmtxtAmount.ResetOnSpace = true;
            this.mmtxtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtAmount.SelectedText = "";
            this.mmtxtAmount.SelectionLength = 0;
            this.mmtxtAmount.SelectionStart = 0;
            this.mmtxtAmount.ShortcutsEnabled = true;
            this.mmtxtAmount.Size = new System.Drawing.Size(184, 48);
            this.mmtxtAmount.SkipLiterals = true;
            this.mmtxtAmount.TabIndex = 19;
            this.mmtxtAmount.TabStop = false;
            this.mmtxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtAmount.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtAmount.TrailingIcon = null;
            this.mmtxtAmount.UseSystemPasswordChar = false;
            this.mmtxtAmount.ValidatingType = null;
            this.mmtxtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mmtxtAmount_KeyPress);
            // 
            // btnInsertNew
            // 
            this.btnInsertNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsertNew.Depth = 0;
            this.btnInsertNew.HighEmphasis = true;
            this.btnInsertNew.Icon = null;
            this.btnInsertNew.Location = new System.Drawing.Point(448, 15);
            this.btnInsertNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsertNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertNew.Name = "btnInsertNew";
            this.btnInsertNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInsertNew.Size = new System.Drawing.Size(90, 36);
            this.btnInsertNew.TabIndex = 34;
            this.btnInsertNew.Text = "Insertar";
            this.btnInsertNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsertNew.UseAccentColor = false;
            this.btnInsertNew.UseVisualStyleBackColor = true;
            this.btnInsertNew.Click += new System.EventHandler(this.btnInsertNew_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mbtnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.HighEmphasis = true;
            this.mbtnCancel.Icon = null;
            this.mbtnCancel.Location = new System.Drawing.Point(331, 15);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCancel.Size = new System.Drawing.Size(96, 36);
            this.mbtnCancel.TabIndex = 35;
            this.mbtnCancel.Text = "Cancelar";
            this.mbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCancel.UseAccentColor = false;
            this.mbtnCancel.UseVisualStyleBackColor = false;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // pnlNewPartnerForm
            // 
            this.pnlNewPartnerForm.AutoScroll = true;
            this.pnlNewPartnerForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlNewPartnerForm.Controls.Add(this.mcmbPeriods);
            this.pnlNewPartnerForm.Controls.Add(this.lblPeriod);
            this.pnlNewPartnerForm.Controls.Add(this.mchkAutomaticInvoiceNum);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtInvoiceNum);
            this.pnlNewPartnerForm.Controls.Add(this.pnlButtonsStrip);
            this.pnlNewPartnerForm.Controls.Add(this.lblTitleForm);
            this.pnlNewPartnerForm.Controls.Add(this.lblReceiptDate);
            this.pnlNewPartnerForm.Controls.Add(this.dtpReceiptDate);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtAmount);
            this.pnlNewPartnerForm.Controls.Add(this.mcmbPartners);
            this.pnlNewPartnerForm.Controls.Add(this.lblPartner);
            this.pnlNewPartnerForm.Location = new System.Drawing.Point(0, 0);
            this.pnlNewPartnerForm.Name = "pnlNewPartnerForm";
            this.pnlNewPartnerForm.Size = new System.Drawing.Size(557, 426);
            this.pnlNewPartnerForm.TabIndex = 36;
            // 
            // mcmbPeriods
            // 
            this.mcmbPeriods.AutoResize = false;
            this.mcmbPeriods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmbPeriods.Depth = 0;
            this.mcmbPeriods.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcmbPeriods.DropDownHeight = 174;
            this.mcmbPeriods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcmbPeriods.DropDownWidth = 121;
            this.mcmbPeriods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcmbPeriods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcmbPeriods.FormattingEnabled = true;
            this.mcmbPeriods.IntegralHeight = false;
            this.mcmbPeriods.ItemHeight = 43;
            this.mcmbPeriods.Location = new System.Drawing.Point(32, 199);
            this.mcmbPeriods.MaxDropDownItems = 4;
            this.mcmbPeriods.MouseState = MaterialSkin.MouseState.OUT;
            this.mcmbPeriods.Name = "mcmbPeriods";
            this.mcmbPeriods.Size = new System.Drawing.Size(184, 49);
            this.mcmbPeriods.StartIndex = 0;
            this.mcmbPeriods.TabIndex = 46;
            this.mcmbPeriods.SelectionChangeCommitted += new System.EventHandler(this.mcmbPeriods_SelectionChangeCommitted);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(28, 173);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(148, 23);
            this.lblPeriod.TabIndex = 45;
            this.lblPeriod.Text = "Periodo del recibo";
            // 
            // mchkAutomaticInvoiceNum
            // 
            this.mchkAutomaticInvoiceNum.AutoSize = true;
            this.mchkAutomaticInvoiceNum.Checked = true;
            this.mchkAutomaticInvoiceNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchkAutomaticInvoiceNum.Depth = 0;
            this.mchkAutomaticInvoiceNum.Location = new System.Drawing.Point(32, 106);
            this.mchkAutomaticInvoiceNum.Margin = new System.Windows.Forms.Padding(0);
            this.mchkAutomaticInvoiceNum.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkAutomaticInvoiceNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkAutomaticInvoiceNum.Name = "mchkAutomaticInvoiceNum";
            this.mchkAutomaticInvoiceNum.ReadOnly = false;
            this.mchkAutomaticInvoiceNum.Ripple = true;
            this.mchkAutomaticInvoiceNum.Size = new System.Drawing.Size(155, 37);
            this.mchkAutomaticInvoiceNum.TabIndex = 44;
            this.mchkAutomaticInvoiceNum.Text = "Folio automático";
            this.mchkAutomaticInvoiceNum.UseVisualStyleBackColor = true;
            this.mchkAutomaticInvoiceNum.CheckedChanged += new System.EventHandler(this.mchkAutomaticInvoiceNum_CheckedChanged);
            // 
            // mmtxtInvoiceNum
            // 
            this.mmtxtInvoiceNum.AllowPromptAsInput = true;
            this.mmtxtInvoiceNum.AnimateReadOnly = false;
            this.mmtxtInvoiceNum.AsciiOnly = false;
            this.mmtxtInvoiceNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtInvoiceNum.BeepOnError = false;
            this.mmtxtInvoiceNum.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtInvoiceNum.Depth = 0;
            this.mmtxtInvoiceNum.Enabled = false;
            this.mmtxtInvoiceNum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtInvoiceNum.HidePromptOnLeave = false;
            this.mmtxtInvoiceNum.HideSelection = true;
            this.mmtxtInvoiceNum.Hint = "Folio de recibo";
            this.mmtxtInvoiceNum.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtInvoiceNum.LeadingIcon = null;
            this.mmtxtInvoiceNum.Location = new System.Drawing.Point(243, 95);
            this.mmtxtInvoiceNum.Mask = "000000";
            this.mmtxtInvoiceNum.MaxLength = 32767;
            this.mmtxtInvoiceNum.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtInvoiceNum.Name = "mmtxtInvoiceNum";
            this.mmtxtInvoiceNum.PasswordChar = '\0';
            this.mmtxtInvoiceNum.PrefixSuffixText = null;
            this.mmtxtInvoiceNum.PromptChar = '_';
            this.mmtxtInvoiceNum.ReadOnly = false;
            this.mmtxtInvoiceNum.RejectInputOnFirstFailure = false;
            this.mmtxtInvoiceNum.ResetOnPrompt = true;
            this.mmtxtInvoiceNum.ResetOnSpace = true;
            this.mmtxtInvoiceNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtInvoiceNum.SelectedText = "";
            this.mmtxtInvoiceNum.SelectionLength = 0;
            this.mmtxtInvoiceNum.SelectionStart = 0;
            this.mmtxtInvoiceNum.ShortcutsEnabled = true;
            this.mmtxtInvoiceNum.Size = new System.Drawing.Size(184, 48);
            this.mmtxtInvoiceNum.SkipLiterals = true;
            this.mmtxtInvoiceNum.TabIndex = 43;
            this.mmtxtInvoiceNum.TabStop = false;
            this.mmtxtInvoiceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtInvoiceNum.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtInvoiceNum.TrailingIcon = null;
            this.mmtxtInvoiceNum.UseSystemPasswordChar = false;
            this.mmtxtInvoiceNum.ValidatingType = null;
            // 
            // pnlButtonsStrip
            // 
            this.pnlButtonsStrip.Controls.Add(this.mbtnCancel);
            this.pnlButtonsStrip.Controls.Add(this.btnInsertNew);
            this.pnlButtonsStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsStrip.Location = new System.Drawing.Point(0, 362);
            this.pnlButtonsStrip.Name = "pnlButtonsStrip";
            this.pnlButtonsStrip.Size = new System.Drawing.Size(557, 64);
            this.pnlButtonsStrip.TabIndex = 37;
            // 
            // RegisterReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(557, 427);
            this.Controls.Add(this.pnlNewPartnerForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.pnlNewPartnerForm.ResumeLayout(false);
            this.pnlNewPartnerForm.PerformLayout();
            this.pnlButtonsStrip.ResumeLayout(false);
            this.pnlButtonsStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.Label lblReceiptDate;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.Label lblPartner;
        private MaterialSkin.Controls.MaterialComboBox mcmbPartners;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtAmount;
        private MaterialSkin.Controls.MaterialButton btnInsertNew;
        private MaterialSkin.Controls.MaterialButton mbtnCancel;
        private System.Windows.Forms.Panel pnlNewPartnerForm;
        private System.Windows.Forms.Panel pnlButtonsStrip;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtInvoiceNum;
        private System.Windows.Forms.Label lblPeriod;
        private MaterialSkin.Controls.MaterialCheckbox mchkAutomaticInvoiceNum;
        private MaterialSkin.Controls.MaterialComboBox mcmbPeriods;
    }
}