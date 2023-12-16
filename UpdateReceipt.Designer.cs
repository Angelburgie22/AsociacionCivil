
namespace AsociacionCivil
{
    partial class UpdateReceipt
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
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.pnlNewPartnerForm = new System.Windows.Forms.Panel();
            this.pnlCancelation = new System.Windows.Forms.Panel();
            this.mmtxtDescription = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblMotive = new System.Windows.Forms.Label();
            this.mcmbMotive = new MaterialSkin.Controls.MaterialComboBox();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.mrbCanceled = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.mcmbPeriods = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.mmtxtInvoiceNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pnlButtonsStrip = new System.Windows.Forms.Panel();
            this.pnlNewPartnerForm.SuspendLayout();
            this.pnlCancelation.SuspendLayout();
            this.gpbStatus.SuspendLayout();
            this.pnlButtonsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.Location = new System.Drawing.Point(24, 27);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(280, 45);
            this.lblTitleForm.TabIndex = 0;
            this.lblTitleForm.Text = "Actualizar recibo";
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
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(425, 9);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(109, 36);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mbtnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.HighEmphasis = true;
            this.mbtnCancel.Icon = null;
            this.mbtnCancel.Location = new System.Drawing.Point(308, 9);
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
            this.pnlNewPartnerForm.Controls.Add(this.pnlCancelation);
            this.pnlNewPartnerForm.Controls.Add(this.gpbStatus);
            this.pnlNewPartnerForm.Controls.Add(this.mcmbPeriods);
            this.pnlNewPartnerForm.Controls.Add(this.lblPeriod);
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
            this.pnlNewPartnerForm.Size = new System.Drawing.Size(547, 571);
            this.pnlNewPartnerForm.TabIndex = 36;
            // 
            // pnlCancelation
            // 
            this.pnlCancelation.Controls.Add(this.mmtxtDescription);
            this.pnlCancelation.Controls.Add(this.lblMotive);
            this.pnlCancelation.Controls.Add(this.mcmbMotive);
            this.pnlCancelation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCancelation.Location = new System.Drawing.Point(0, 429);
            this.pnlCancelation.Name = "pnlCancelation";
            this.pnlCancelation.Size = new System.Drawing.Size(547, 84);
            this.pnlCancelation.TabIndex = 48;
            // 
            // mmtxtDescription
            // 
            this.mmtxtDescription.AllowPromptAsInput = true;
            this.mmtxtDescription.AnimateReadOnly = false;
            this.mmtxtDescription.AsciiOnly = false;
            this.mmtxtDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtDescription.BeepOnError = false;
            this.mmtxtDescription.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtDescription.Depth = 0;
            this.mmtxtDescription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtDescription.HidePromptOnLeave = false;
            this.mmtxtDescription.HideSelection = true;
            this.mmtxtDescription.Hint = "Descripción";
            this.mmtxtDescription.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtDescription.LeadingIcon = null;
            this.mmtxtDescription.Location = new System.Drawing.Point(331, 26);
            this.mmtxtDescription.Mask = "";
            this.mmtxtDescription.MaxLength = 32767;
            this.mmtxtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtDescription.Name = "mmtxtDescription";
            this.mmtxtDescription.PasswordChar = '\0';
            this.mmtxtDescription.PrefixSuffixText = null;
            this.mmtxtDescription.PromptChar = '_';
            this.mmtxtDescription.ReadOnly = false;
            this.mmtxtDescription.RejectInputOnFirstFailure = false;
            this.mmtxtDescription.ResetOnPrompt = true;
            this.mmtxtDescription.ResetOnSpace = true;
            this.mmtxtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtDescription.SelectedText = "";
            this.mmtxtDescription.SelectionLength = 0;
            this.mmtxtDescription.SelectionStart = 0;
            this.mmtxtDescription.ShortcutsEnabled = true;
            this.mmtxtDescription.Size = new System.Drawing.Size(184, 48);
            this.mmtxtDescription.SkipLiterals = true;
            this.mmtxtDescription.TabIndex = 49;
            this.mmtxtDescription.TabStop = false;
            this.mmtxtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtDescription.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtDescription.TrailingIcon = null;
            this.mmtxtDescription.UseSystemPasswordChar = false;
            this.mmtxtDescription.ValidatingType = null;
            this.mmtxtDescription.TextChanged += new System.EventHandler(this.mmtxtDescription_TextChanged);
            // 
            // lblMotive
            // 
            this.lblMotive.AutoSize = true;
            this.lblMotive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotive.Location = new System.Drawing.Point(41, 0);
            this.lblMotive.Name = "lblMotive";
            this.lblMotive.Size = new System.Drawing.Size(185, 23);
            this.lblMotive.TabIndex = 17;
            this.lblMotive.Text = "Motivo de cancelación:";
            // 
            // mcmbMotive
            // 
            this.mcmbMotive.AutoResize = false;
            this.mcmbMotive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmbMotive.Depth = 0;
            this.mcmbMotive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcmbMotive.DropDownHeight = 174;
            this.mcmbMotive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcmbMotive.DropDownWidth = 121;
            this.mcmbMotive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcmbMotive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcmbMotive.FormattingEnabled = true;
            this.mcmbMotive.IntegralHeight = false;
            this.mcmbMotive.ItemHeight = 43;
            this.mcmbMotive.Location = new System.Drawing.Point(45, 26);
            this.mcmbMotive.MaxDropDownItems = 4;
            this.mcmbMotive.MouseState = MaterialSkin.MouseState.OUT;
            this.mcmbMotive.Name = "mcmbMotive";
            this.mcmbMotive.Size = new System.Drawing.Size(184, 49);
            this.mcmbMotive.StartIndex = 0;
            this.mcmbMotive.TabIndex = 16;
            // 
            // gpbStatus
            // 
            this.gpbStatus.Controls.Add(this.mrbCanceled);
            this.gpbStatus.Controls.Add(this.mrbActive);
            this.gpbStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStatus.Location = new System.Drawing.Point(32, 347);
            this.gpbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbStatus.Size = new System.Drawing.Size(225, 74);
            this.gpbStatus.TabIndex = 47;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Text = "Estatus:";
            // 
            // mrbCanceled
            // 
            this.mrbCanceled.AutoSize = true;
            this.mrbCanceled.Depth = 0;
            this.mrbCanceled.Location = new System.Drawing.Point(103, 31);
            this.mrbCanceled.Margin = new System.Windows.Forms.Padding(0);
            this.mrbCanceled.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbCanceled.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbCanceled.Name = "mrbCanceled";
            this.mrbCanceled.Ripple = true;
            this.mrbCanceled.Size = new System.Drawing.Size(110, 37);
            this.mrbCanceled.TabIndex = 43;
            this.mrbCanceled.TabStop = true;
            this.mrbCanceled.Text = "Cancelado";
            this.mrbCanceled.UseVisualStyleBackColor = true;
            this.mrbCanceled.CheckedChanged += new System.EventHandler(this.mrbCanceled_CheckedChanged);
            // 
            // mrbActive
            // 
            this.mrbActive.AutoSize = true;
            this.mrbActive.Checked = true;
            this.mrbActive.Depth = 0;
            this.mrbActive.Location = new System.Drawing.Point(13, 31);
            this.mrbActive.Margin = new System.Windows.Forms.Padding(0);
            this.mrbActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbActive.Name = "mrbActive";
            this.mrbActive.Ripple = true;
            this.mrbActive.Size = new System.Drawing.Size(79, 37);
            this.mrbActive.TabIndex = 42;
            this.mrbActive.TabStop = true;
            this.mrbActive.Text = "Activo";
            this.mrbActive.UseVisualStyleBackColor = true;
            this.mrbActive.CheckedChanged += new System.EventHandler(this.mrbActive_CheckedChanged);
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
            this.mmtxtInvoiceNum.Location = new System.Drawing.Point(32, 98);
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
            this.pnlButtonsStrip.Controls.Add(this.btnUpdate);
            this.pnlButtonsStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsStrip.Location = new System.Drawing.Point(0, 513);
            this.pnlButtonsStrip.Name = "pnlButtonsStrip";
            this.pnlButtonsStrip.Size = new System.Drawing.Size(547, 58);
            this.pnlButtonsStrip.TabIndex = 37;
            // 
            // UpdateReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(546, 571);
            this.Controls.Add(this.pnlNewPartnerForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.pnlNewPartnerForm.ResumeLayout(false);
            this.pnlNewPartnerForm.PerformLayout();
            this.pnlCancelation.ResumeLayout(false);
            this.pnlCancelation.PerformLayout();
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton mbtnCancel;
        private System.Windows.Forms.Panel pnlNewPartnerForm;
        private System.Windows.Forms.Panel pnlButtonsStrip;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtInvoiceNum;
        private System.Windows.Forms.Label lblPeriod;
        private MaterialSkin.Controls.MaterialComboBox mcmbPeriods;
        private System.Windows.Forms.GroupBox gpbStatus;
        private MaterialSkin.Controls.MaterialRadioButton mrbCanceled;
        private MaterialSkin.Controls.MaterialRadioButton mrbActive;
        private System.Windows.Forms.Panel pnlCancelation;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtDescription;
        private System.Windows.Forms.Label lblMotive;
        private MaterialSkin.Controls.MaterialComboBox mcmbMotive;
    }
}