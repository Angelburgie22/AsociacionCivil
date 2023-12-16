
namespace AsociacionCivil
{
    partial class RegisterAdmin
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
            this.mmtxtRFC = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mcmbState = new MaterialSkin.Controls.MaterialComboBox();
            this.mcmbCity = new MaterialSkin.Controls.MaterialComboBox();
            this.mmtxtPostalCode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtSuburb = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtStreet = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtExtNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtIntNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dtpAssociationDate = new System.Windows.Forms.DateTimePicker();
            this.lblAssociationDate = new System.Windows.Forms.Label();
            this.mmtxtEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnInsertNew = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.pnlNewPartnerForm = new System.Windows.Forms.Panel();
            this.pnlButtonsStrip = new System.Windows.Forms.Panel();
            this.mmtxtMLastName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtPLastName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
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
            this.lblTitleForm.Size = new System.Drawing.Size(349, 45);
            this.lblTitleForm.TabIndex = 0;
            this.lblTitleForm.Text = "Nuevo administrador";
            // 
            // mmtxtRFC
            // 
            this.mmtxtRFC.AllowPromptAsInput = true;
            this.mmtxtRFC.AnimateReadOnly = false;
            this.mmtxtRFC.AsciiOnly = false;
            this.mmtxtRFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtRFC.BeepOnError = false;
            this.mmtxtRFC.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtRFC.Depth = 0;
            this.mmtxtRFC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtRFC.HidePromptOnLeave = false;
            this.mmtxtRFC.HideSelection = true;
            this.mmtxtRFC.Hint = "RFC";
            this.mmtxtRFC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtRFC.LeadingIcon = null;
            this.mmtxtRFC.Location = new System.Drawing.Point(32, 226);
            this.mmtxtRFC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtRFC.Mask = "";
            this.mmtxtRFC.MaxLength = 32767;
            this.mmtxtRFC.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtRFC.Name = "mmtxtRFC";
            this.mmtxtRFC.PasswordChar = '\0';
            this.mmtxtRFC.PrefixSuffixText = null;
            this.mmtxtRFC.PromptChar = '_';
            this.mmtxtRFC.ReadOnly = false;
            this.mmtxtRFC.RejectInputOnFirstFailure = false;
            this.mmtxtRFC.ResetOnPrompt = true;
            this.mmtxtRFC.ResetOnSpace = true;
            this.mmtxtRFC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtRFC.SelectedText = "";
            this.mmtxtRFC.SelectionLength = 0;
            this.mmtxtRFC.SelectionStart = 0;
            this.mmtxtRFC.ShortcutsEnabled = true;
            this.mmtxtRFC.Size = new System.Drawing.Size(184, 48);
            this.mmtxtRFC.SkipLiterals = true;
            this.mmtxtRFC.TabIndex = 13;
            this.mmtxtRFC.TabStop = false;
            this.mmtxtRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtRFC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtRFC.TrailingIcon = null;
            this.mmtxtRFC.UseSystemPasswordChar = false;
            this.mmtxtRFC.ValidatingType = null;
            this.mmtxtRFC.TextChanged += new System.EventHandler(this.mmtxtRFC_TextChanged);
            // 
            // mcmbState
            // 
            this.mcmbState.AutoResize = false;
            this.mcmbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmbState.Depth = 0;
            this.mcmbState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcmbState.DropDownHeight = 174;
            this.mcmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcmbState.DropDownWidth = 121;
            this.mcmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcmbState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcmbState.FormattingEnabled = true;
            this.mcmbState.IntegralHeight = false;
            this.mcmbState.ItemHeight = 43;
            this.mcmbState.Location = new System.Drawing.Point(32, 331);
            this.mcmbState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mcmbState.MaxDropDownItems = 4;
            this.mcmbState.MouseState = MaterialSkin.MouseState.OUT;
            this.mcmbState.Name = "mcmbState";
            this.mcmbState.Size = new System.Drawing.Size(184, 49);
            this.mcmbState.StartIndex = 0;
            this.mcmbState.TabIndex = 15;
            this.mcmbState.SelectionChangeCommitted += new System.EventHandler(this.mcmbState_SelectionChangeCommitted);
            // 
            // mcmbCity
            // 
            this.mcmbCity.AutoResize = false;
            this.mcmbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmbCity.Depth = 0;
            this.mcmbCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcmbCity.DropDownHeight = 174;
            this.mcmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcmbCity.DropDownWidth = 121;
            this.mcmbCity.Enabled = false;
            this.mcmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcmbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcmbCity.FormattingEnabled = true;
            this.mcmbCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mcmbCity.IntegralHeight = false;
            this.mcmbCity.ItemHeight = 43;
            this.mcmbCity.Location = new System.Drawing.Point(231, 331);
            this.mcmbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mcmbCity.MaxDropDownItems = 4;
            this.mcmbCity.MouseState = MaterialSkin.MouseState.OUT;
            this.mcmbCity.Name = "mcmbCity";
            this.mcmbCity.Size = new System.Drawing.Size(184, 49);
            this.mcmbCity.StartIndex = 0;
            this.mcmbCity.TabIndex = 17;
            // 
            // mmtxtPostalCode
            // 
            this.mmtxtPostalCode.AllowPromptAsInput = true;
            this.mmtxtPostalCode.AnimateReadOnly = false;
            this.mmtxtPostalCode.AsciiOnly = false;
            this.mmtxtPostalCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtPostalCode.BeepOnError = false;
            this.mmtxtPostalCode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtPostalCode.Depth = 0;
            this.mmtxtPostalCode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtPostalCode.HidePromptOnLeave = false;
            this.mmtxtPostalCode.HideSelection = true;
            this.mmtxtPostalCode.Hint = "Código postal";
            this.mmtxtPostalCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtPostalCode.LeadingIcon = null;
            this.mmtxtPostalCode.Location = new System.Drawing.Point(32, 430);
            this.mmtxtPostalCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtPostalCode.Mask = "00000";
            this.mmtxtPostalCode.MaxLength = 32767;
            this.mmtxtPostalCode.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtPostalCode.Name = "mmtxtPostalCode";
            this.mmtxtPostalCode.PasswordChar = '\0';
            this.mmtxtPostalCode.PrefixSuffixText = null;
            this.mmtxtPostalCode.PromptChar = '_';
            this.mmtxtPostalCode.ReadOnly = false;
            this.mmtxtPostalCode.RejectInputOnFirstFailure = false;
            this.mmtxtPostalCode.ResetOnPrompt = true;
            this.mmtxtPostalCode.ResetOnSpace = true;
            this.mmtxtPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtPostalCode.SelectedText = "";
            this.mmtxtPostalCode.SelectionLength = 0;
            this.mmtxtPostalCode.SelectionStart = 0;
            this.mmtxtPostalCode.ShortcutsEnabled = true;
            this.mmtxtPostalCode.Size = new System.Drawing.Size(184, 48);
            this.mmtxtPostalCode.SkipLiterals = true;
            this.mmtxtPostalCode.TabIndex = 19;
            this.mmtxtPostalCode.TabStop = false;
            this.mmtxtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtPostalCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtPostalCode.TrailingIcon = null;
            this.mmtxtPostalCode.UseSystemPasswordChar = false;
            this.mmtxtPostalCode.ValidatingType = null;
            // 
            // mmtxtSuburb
            // 
            this.mmtxtSuburb.AllowPromptAsInput = true;
            this.mmtxtSuburb.AnimateReadOnly = false;
            this.mmtxtSuburb.AsciiOnly = false;
            this.mmtxtSuburb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtSuburb.BeepOnError = false;
            this.mmtxtSuburb.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtSuburb.Depth = 0;
            this.mmtxtSuburb.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtSuburb.HidePromptOnLeave = false;
            this.mmtxtSuburb.HideSelection = true;
            this.mmtxtSuburb.Hint = "Colonia";
            this.mmtxtSuburb.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtSuburb.LeadingIcon = null;
            this.mmtxtSuburb.Location = new System.Drawing.Point(232, 430);
            this.mmtxtSuburb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtSuburb.Mask = "";
            this.mmtxtSuburb.MaxLength = 32767;
            this.mmtxtSuburb.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtSuburb.Name = "mmtxtSuburb";
            this.mmtxtSuburb.PasswordChar = '\0';
            this.mmtxtSuburb.PrefixSuffixText = null;
            this.mmtxtSuburb.PromptChar = '_';
            this.mmtxtSuburb.ReadOnly = false;
            this.mmtxtSuburb.RejectInputOnFirstFailure = false;
            this.mmtxtSuburb.ResetOnPrompt = true;
            this.mmtxtSuburb.ResetOnSpace = true;
            this.mmtxtSuburb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtSuburb.SelectedText = "";
            this.mmtxtSuburb.SelectionLength = 0;
            this.mmtxtSuburb.SelectionStart = 0;
            this.mmtxtSuburb.ShortcutsEnabled = true;
            this.mmtxtSuburb.Size = new System.Drawing.Size(184, 48);
            this.mmtxtSuburb.SkipLiterals = true;
            this.mmtxtSuburb.TabIndex = 21;
            this.mmtxtSuburb.TabStop = false;
            this.mmtxtSuburb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtSuburb.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtSuburb.TrailingIcon = null;
            this.mmtxtSuburb.UseSystemPasswordChar = false;
            this.mmtxtSuburb.ValidatingType = null;
            this.mmtxtSuburb.TextChanged += new System.EventHandler(this.mmtxtSuburb_TextChanged);
            // 
            // mmtxtStreet
            // 
            this.mmtxtStreet.AllowPromptAsInput = true;
            this.mmtxtStreet.AnimateReadOnly = false;
            this.mmtxtStreet.AsciiOnly = false;
            this.mmtxtStreet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtStreet.BeepOnError = false;
            this.mmtxtStreet.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtStreet.Depth = 0;
            this.mmtxtStreet.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtStreet.HidePromptOnLeave = false;
            this.mmtxtStreet.HideSelection = true;
            this.mmtxtStreet.Hint = "Calle";
            this.mmtxtStreet.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtStreet.LeadingIcon = null;
            this.mmtxtStreet.Location = new System.Drawing.Point(32, 526);
            this.mmtxtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtStreet.Mask = "";
            this.mmtxtStreet.MaxLength = 32767;
            this.mmtxtStreet.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtStreet.Name = "mmtxtStreet";
            this.mmtxtStreet.PasswordChar = '\0';
            this.mmtxtStreet.PrefixSuffixText = null;
            this.mmtxtStreet.PromptChar = '_';
            this.mmtxtStreet.ReadOnly = false;
            this.mmtxtStreet.RejectInputOnFirstFailure = false;
            this.mmtxtStreet.ResetOnPrompt = true;
            this.mmtxtStreet.ResetOnSpace = true;
            this.mmtxtStreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtStreet.SelectedText = "";
            this.mmtxtStreet.SelectionLength = 0;
            this.mmtxtStreet.SelectionStart = 0;
            this.mmtxtStreet.ShortcutsEnabled = true;
            this.mmtxtStreet.Size = new System.Drawing.Size(184, 48);
            this.mmtxtStreet.SkipLiterals = true;
            this.mmtxtStreet.TabIndex = 23;
            this.mmtxtStreet.TabStop = false;
            this.mmtxtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtStreet.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtStreet.TrailingIcon = null;
            this.mmtxtStreet.UseSystemPasswordChar = false;
            this.mmtxtStreet.ValidatingType = null;
            this.mmtxtStreet.TextChanged += new System.EventHandler(this.mmtxtStreet_TextChanged);
            // 
            // mmtxtExtNum
            // 
            this.mmtxtExtNum.AllowPromptAsInput = true;
            this.mmtxtExtNum.AnimateReadOnly = false;
            this.mmtxtExtNum.AsciiOnly = false;
            this.mmtxtExtNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtExtNum.BeepOnError = false;
            this.mmtxtExtNum.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtExtNum.Depth = 0;
            this.mmtxtExtNum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtExtNum.HidePromptOnLeave = false;
            this.mmtxtExtNum.HideSelection = true;
            this.mmtxtExtNum.Hint = "Número exterior";
            this.mmtxtExtNum.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtExtNum.LeadingIcon = null;
            this.mmtxtExtNum.Location = new System.Drawing.Point(231, 526);
            this.mmtxtExtNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtExtNum.Mask = "";
            this.mmtxtExtNum.MaxLength = 32767;
            this.mmtxtExtNum.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtExtNum.Name = "mmtxtExtNum";
            this.mmtxtExtNum.PasswordChar = '\0';
            this.mmtxtExtNum.PrefixSuffixText = null;
            this.mmtxtExtNum.PromptChar = '_';
            this.mmtxtExtNum.ReadOnly = false;
            this.mmtxtExtNum.RejectInputOnFirstFailure = false;
            this.mmtxtExtNum.ResetOnPrompt = true;
            this.mmtxtExtNum.ResetOnSpace = true;
            this.mmtxtExtNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtExtNum.SelectedText = "";
            this.mmtxtExtNum.SelectionLength = 0;
            this.mmtxtExtNum.SelectionStart = 0;
            this.mmtxtExtNum.ShortcutsEnabled = true;
            this.mmtxtExtNum.Size = new System.Drawing.Size(184, 48);
            this.mmtxtExtNum.SkipLiterals = true;
            this.mmtxtExtNum.TabIndex = 25;
            this.mmtxtExtNum.TabStop = false;
            this.mmtxtExtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtExtNum.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtExtNum.TrailingIcon = null;
            this.mmtxtExtNum.UseSystemPasswordChar = false;
            this.mmtxtExtNum.ValidatingType = null;
            // 
            // mmtxtIntNum
            // 
            this.mmtxtIntNum.AllowPromptAsInput = true;
            this.mmtxtIntNum.AnimateReadOnly = false;
            this.mmtxtIntNum.AsciiOnly = false;
            this.mmtxtIntNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtIntNum.BeepOnError = false;
            this.mmtxtIntNum.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtIntNum.Depth = 0;
            this.mmtxtIntNum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtIntNum.HidePromptOnLeave = false;
            this.mmtxtIntNum.HideSelection = true;
            this.mmtxtIntNum.Hint = "Número interior";
            this.mmtxtIntNum.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtIntNum.LeadingIcon = null;
            this.mmtxtIntNum.Location = new System.Drawing.Point(431, 526);
            this.mmtxtIntNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtIntNum.Mask = "";
            this.mmtxtIntNum.MaxLength = 32767;
            this.mmtxtIntNum.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtIntNum.Name = "mmtxtIntNum";
            this.mmtxtIntNum.PasswordChar = '\0';
            this.mmtxtIntNum.PrefixSuffixText = null;
            this.mmtxtIntNum.PromptChar = '_';
            this.mmtxtIntNum.ReadOnly = false;
            this.mmtxtIntNum.RejectInputOnFirstFailure = false;
            this.mmtxtIntNum.ResetOnPrompt = true;
            this.mmtxtIntNum.ResetOnSpace = true;
            this.mmtxtIntNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtIntNum.SelectedText = "";
            this.mmtxtIntNum.SelectionLength = 0;
            this.mmtxtIntNum.SelectionStart = 0;
            this.mmtxtIntNum.ShortcutsEnabled = true;
            this.mmtxtIntNum.Size = new System.Drawing.Size(184, 48);
            this.mmtxtIntNum.SkipLiterals = true;
            this.mmtxtIntNum.TabIndex = 27;
            this.mmtxtIntNum.TabStop = false;
            this.mmtxtIntNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtIntNum.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtIntNum.TrailingIcon = null;
            this.mmtxtIntNum.UseSystemPasswordChar = false;
            this.mmtxtIntNum.ValidatingType = null;
            // 
            // dtpAssociationDate
            // 
            this.dtpAssociationDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAssociationDate.Location = new System.Drawing.Point(235, 226);
            this.dtpAssociationDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAssociationDate.Name = "dtpAssociationDate";
            this.dtpAssociationDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAssociationDate.TabIndex = 29;
            // 
            // lblAssociationDate
            // 
            this.lblAssociationDate.AutoSize = true;
            this.lblAssociationDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociationDate.Location = new System.Drawing.Point(229, 199);
            this.lblAssociationDate.Name = "lblAssociationDate";
            this.lblAssociationDate.Size = new System.Drawing.Size(143, 23);
            this.lblAssociationDate.TabIndex = 28;
            this.lblAssociationDate.Text = "Fecha de ingreso:";
            // 
            // mmtxtEmail
            // 
            this.mmtxtEmail.AllowPromptAsInput = true;
            this.mmtxtEmail.AnimateReadOnly = false;
            this.mmtxtEmail.AsciiOnly = false;
            this.mmtxtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtEmail.BeepOnError = false;
            this.mmtxtEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtEmail.Depth = 0;
            this.mmtxtEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtEmail.HidePromptOnLeave = false;
            this.mmtxtEmail.HideSelection = true;
            this.mmtxtEmail.Hint = "Correo electrónico";
            this.mmtxtEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtEmail.LeadingIcon = null;
            this.mmtxtEmail.Location = new System.Drawing.Point(32, 630);
            this.mmtxtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtEmail.Mask = "";
            this.mmtxtEmail.MaxLength = 32767;
            this.mmtxtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtEmail.Name = "mmtxtEmail";
            this.mmtxtEmail.PasswordChar = '\0';
            this.mmtxtEmail.PrefixSuffixText = null;
            this.mmtxtEmail.PromptChar = '_';
            this.mmtxtEmail.ReadOnly = false;
            this.mmtxtEmail.RejectInputOnFirstFailure = false;
            this.mmtxtEmail.ResetOnPrompt = true;
            this.mmtxtEmail.ResetOnSpace = true;
            this.mmtxtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtEmail.SelectedText = "";
            this.mmtxtEmail.SelectionLength = 0;
            this.mmtxtEmail.SelectionStart = 0;
            this.mmtxtEmail.ShortcutsEnabled = true;
            this.mmtxtEmail.Size = new System.Drawing.Size(256, 48);
            this.mmtxtEmail.SkipLiterals = true;
            this.mmtxtEmail.TabIndex = 31;
            this.mmtxtEmail.TabStop = false;
            this.mmtxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtEmail.TrailingIcon = null;
            this.mmtxtEmail.UseSystemPasswordChar = false;
            this.mmtxtEmail.ValidatingType = null;
            // 
            // btnInsertNew
            // 
            this.btnInsertNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsertNew.Depth = 0;
            this.btnInsertNew.HighEmphasis = true;
            this.btnInsertNew.Icon = null;
            this.btnInsertNew.Location = new System.Drawing.Point(548, 15);
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
            this.mbtnCancel.Location = new System.Drawing.Point(431, 15);
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
            this.pnlNewPartnerForm.Controls.Add(this.pnlButtonsStrip);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtMLastName);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtPLastName);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtEmail);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtName);
            this.pnlNewPartnerForm.Controls.Add(this.lblTitleForm);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtStreet);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtIntNum);
            this.pnlNewPartnerForm.Controls.Add(this.dtpAssociationDate);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtExtNum);
            this.pnlNewPartnerForm.Controls.Add(this.lblAssociationDate);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtSuburb);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtPostalCode);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtRFC);
            this.pnlNewPartnerForm.Controls.Add(this.mcmbState);
            this.pnlNewPartnerForm.Controls.Add(this.mcmbCity);
            this.pnlNewPartnerForm.Controls.Add(this.lblState);
            this.pnlNewPartnerForm.Controls.Add(this.lblCity);
            this.pnlNewPartnerForm.Location = new System.Drawing.Point(0, 0);
            this.pnlNewPartnerForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNewPartnerForm.Name = "pnlNewPartnerForm";
            this.pnlNewPartnerForm.Size = new System.Drawing.Size(669, 742);
            this.pnlNewPartnerForm.TabIndex = 36;
            // 
            // pnlButtonsStrip
            // 
            this.pnlButtonsStrip.Controls.Add(this.mbtnCancel);
            this.pnlButtonsStrip.Controls.Add(this.btnInsertNew);
            this.pnlButtonsStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsStrip.Location = new System.Drawing.Point(0, 678);
            this.pnlButtonsStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonsStrip.Name = "pnlButtonsStrip";
            this.pnlButtonsStrip.Size = new System.Drawing.Size(669, 64);
            this.pnlButtonsStrip.TabIndex = 37;
            // 
            // mmtxtMLastName
            // 
            this.mmtxtMLastName.AllowPromptAsInput = true;
            this.mmtxtMLastName.AnimateReadOnly = false;
            this.mmtxtMLastName.AsciiOnly = false;
            this.mmtxtMLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtMLastName.BeepOnError = false;
            this.mmtxtMLastName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtMLastName.Depth = 0;
            this.mmtxtMLastName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtMLastName.HidePromptOnLeave = false;
            this.mmtxtMLastName.HideSelection = true;
            this.mmtxtMLastName.Hint = "Apellido materno";
            this.mmtxtMLastName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtMLastName.LeadingIcon = null;
            this.mmtxtMLastName.Location = new System.Drawing.Point(431, 127);
            this.mmtxtMLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtMLastName.Mask = "";
            this.mmtxtMLastName.MaxLength = 32767;
            this.mmtxtMLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtMLastName.Name = "mmtxtMLastName";
            this.mmtxtMLastName.PasswordChar = '\0';
            this.mmtxtMLastName.PrefixSuffixText = null;
            this.mmtxtMLastName.PromptChar = '_';
            this.mmtxtMLastName.ReadOnly = false;
            this.mmtxtMLastName.RejectInputOnFirstFailure = false;
            this.mmtxtMLastName.ResetOnPrompt = true;
            this.mmtxtMLastName.ResetOnSpace = true;
            this.mmtxtMLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtMLastName.SelectedText = "";
            this.mmtxtMLastName.SelectionLength = 0;
            this.mmtxtMLastName.SelectionStart = 0;
            this.mmtxtMLastName.ShortcutsEnabled = true;
            this.mmtxtMLastName.Size = new System.Drawing.Size(184, 48);
            this.mmtxtMLastName.SkipLiterals = true;
            this.mmtxtMLastName.TabIndex = 11;
            this.mmtxtMLastName.TabStop = false;
            this.mmtxtMLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtMLastName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtMLastName.TrailingIcon = null;
            this.mmtxtMLastName.UseSystemPasswordChar = false;
            this.mmtxtMLastName.ValidatingType = null;
            this.mmtxtMLastName.TextChanged += new System.EventHandler(this.mmtxtMLastName_TextChanged);
            // 
            // mmtxtPLastName
            // 
            this.mmtxtPLastName.AllowPromptAsInput = true;
            this.mmtxtPLastName.AnimateReadOnly = false;
            this.mmtxtPLastName.AsciiOnly = false;
            this.mmtxtPLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtPLastName.BeepOnError = false;
            this.mmtxtPLastName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtPLastName.Depth = 0;
            this.mmtxtPLastName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtPLastName.HidePromptOnLeave = false;
            this.mmtxtPLastName.HideSelection = true;
            this.mmtxtPLastName.Hint = "Apellido paterno";
            this.mmtxtPLastName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtPLastName.LeadingIcon = null;
            this.mmtxtPLastName.Location = new System.Drawing.Point(231, 127);
            this.mmtxtPLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtPLastName.Mask = "";
            this.mmtxtPLastName.MaxLength = 32767;
            this.mmtxtPLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtPLastName.Name = "mmtxtPLastName";
            this.mmtxtPLastName.PasswordChar = '\0';
            this.mmtxtPLastName.PrefixSuffixText = null;
            this.mmtxtPLastName.PromptChar = '_';
            this.mmtxtPLastName.ReadOnly = false;
            this.mmtxtPLastName.RejectInputOnFirstFailure = false;
            this.mmtxtPLastName.ResetOnPrompt = true;
            this.mmtxtPLastName.ResetOnSpace = true;
            this.mmtxtPLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtPLastName.SelectedText = "";
            this.mmtxtPLastName.SelectionLength = 0;
            this.mmtxtPLastName.SelectionStart = 0;
            this.mmtxtPLastName.ShortcutsEnabled = true;
            this.mmtxtPLastName.Size = new System.Drawing.Size(184, 48);
            this.mmtxtPLastName.SkipLiterals = true;
            this.mmtxtPLastName.TabIndex = 9;
            this.mmtxtPLastName.TabStop = false;
            this.mmtxtPLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtPLastName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtPLastName.TrailingIcon = null;
            this.mmtxtPLastName.UseSystemPasswordChar = false;
            this.mmtxtPLastName.ValidatingType = null;
            this.mmtxtPLastName.TextChanged += new System.EventHandler(this.mmtxtPLastName_TextChanged);
            // 
            // mmtxtName
            // 
            this.mmtxtName.AllowPromptAsInput = true;
            this.mmtxtName.AnimateReadOnly = false;
            this.mmtxtName.AsciiOnly = false;
            this.mmtxtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtName.BeepOnError = false;
            this.mmtxtName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtName.Depth = 0;
            this.mmtxtName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtName.HidePromptOnLeave = false;
            this.mmtxtName.HideSelection = true;
            this.mmtxtName.Hint = "Nombre(s)";
            this.mmtxtName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtName.LeadingIcon = null;
            this.mmtxtName.Location = new System.Drawing.Point(32, 127);
            this.mmtxtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtName.Mask = "";
            this.mmtxtName.MaxLength = 32767;
            this.mmtxtName.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtName.Name = "mmtxtName";
            this.mmtxtName.PasswordChar = '\0';
            this.mmtxtName.PrefixSuffixText = null;
            this.mmtxtName.PromptChar = '_';
            this.mmtxtName.ReadOnly = false;
            this.mmtxtName.RejectInputOnFirstFailure = false;
            this.mmtxtName.ResetOnPrompt = true;
            this.mmtxtName.ResetOnSpace = true;
            this.mmtxtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtName.SelectedText = "";
            this.mmtxtName.SelectionLength = 0;
            this.mmtxtName.SelectionStart = 0;
            this.mmtxtName.ShortcutsEnabled = true;
            this.mmtxtName.Size = new System.Drawing.Size(184, 48);
            this.mmtxtName.SkipLiterals = true;
            this.mmtxtName.TabIndex = 7;
            this.mmtxtName.TabStop = false;
            this.mmtxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtName.TrailingIcon = null;
            this.mmtxtName.UseSystemPasswordChar = false;
            this.mmtxtName.ValidatingType = null;
            this.mmtxtName.TextChanged += new System.EventHandler(this.mmtxtName_TextChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(28, 304);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(65, 23);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "Estado:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(227, 304);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(68, 23);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "Ciudad:";
            // 
            // RegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(656, 742);
            this.Controls.Add(this.pnlNewPartnerForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar socio";
            this.pnlNewPartnerForm.ResumeLayout(false);
            this.pnlNewPartnerForm.PerformLayout();
            this.pnlButtonsStrip.ResumeLayout(false);
            this.pnlButtonsStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleForm;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtRFC;
        private MaterialSkin.Controls.MaterialComboBox mcmbState;
        private MaterialSkin.Controls.MaterialComboBox mcmbCity;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtPostalCode;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtSuburb;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtStreet;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtExtNum;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtIntNum;
        private System.Windows.Forms.DateTimePicker dtpAssociationDate;
        private System.Windows.Forms.Label lblAssociationDate;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtEmail;
        private MaterialSkin.Controls.MaterialButton btnInsertNew;
        private MaterialSkin.Controls.MaterialButton mbtnCancel;
        private System.Windows.Forms.Panel pnlNewPartnerForm;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtMLastName;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtPLastName;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtName;
        private System.Windows.Forms.Panel pnlButtonsStrip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
    }
}