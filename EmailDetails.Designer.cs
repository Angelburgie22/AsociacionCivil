
namespace AsociacionCivil
{
    partial class EmailDetails
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
            this.mtxtSender = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mtxtTo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mtxtPasswdSender = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mbtnConfirm = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.mtxtSubject = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mtxtBody = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.Location = new System.Drawing.Point(12, 19);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(309, 45);
            this.lblTitleForm.TabIndex = 1;
            this.lblTitleForm.Text = "Detalles del correo";
            // 
            // mtxtSender
            // 
            this.mtxtSender.AllowPromptAsInput = true;
            this.mtxtSender.AnimateReadOnly = false;
            this.mtxtSender.AsciiOnly = false;
            this.mtxtSender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtSender.BeepOnError = false;
            this.mtxtSender.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSender.Depth = 0;
            this.mtxtSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtSender.HidePromptOnLeave = false;
            this.mtxtSender.HideSelection = true;
            this.mtxtSender.Hint = "Remitente";
            this.mtxtSender.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtSender.LeadingIcon = null;
            this.mtxtSender.Location = new System.Drawing.Point(20, 97);
            this.mtxtSender.Mask = "";
            this.mtxtSender.MaxLength = 32767;
            this.mtxtSender.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtSender.Name = "mtxtSender";
            this.mtxtSender.PasswordChar = '\0';
            this.mtxtSender.PrefixSuffixText = null;
            this.mtxtSender.PromptChar = '_';
            this.mtxtSender.ReadOnly = false;
            this.mtxtSender.RejectInputOnFirstFailure = false;
            this.mtxtSender.ResetOnPrompt = true;
            this.mtxtSender.ResetOnSpace = true;
            this.mtxtSender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtSender.SelectedText = "";
            this.mtxtSender.SelectionLength = 0;
            this.mtxtSender.SelectionStart = 0;
            this.mtxtSender.ShortcutsEnabled = true;
            this.mtxtSender.Size = new System.Drawing.Size(390, 48);
            this.mtxtSender.SkipLiterals = true;
            this.mtxtSender.TabIndex = 8;
            this.mtxtSender.TabStop = false;
            this.mtxtSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtSender.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSender.TrailingIcon = null;
            this.mtxtSender.UseSystemPasswordChar = false;
            this.mtxtSender.ValidatingType = null;
            // 
            // mtxtTo
            // 
            this.mtxtTo.AllowPromptAsInput = true;
            this.mtxtTo.AnimateReadOnly = false;
            this.mtxtTo.AsciiOnly = false;
            this.mtxtTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtTo.BeepOnError = false;
            this.mtxtTo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtTo.Depth = 0;
            this.mtxtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtTo.HidePromptOnLeave = false;
            this.mtxtTo.HideSelection = true;
            this.mtxtTo.Hint = "Destinatario";
            this.mtxtTo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtTo.LeadingIcon = null;
            this.mtxtTo.Location = new System.Drawing.Point(20, 233);
            this.mtxtTo.Mask = "";
            this.mtxtTo.MaxLength = 32767;
            this.mtxtTo.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtTo.Name = "mtxtTo";
            this.mtxtTo.PasswordChar = '\0';
            this.mtxtTo.PrefixSuffixText = null;
            this.mtxtTo.PromptChar = '_';
            this.mtxtTo.ReadOnly = false;
            this.mtxtTo.RejectInputOnFirstFailure = false;
            this.mtxtTo.ResetOnPrompt = true;
            this.mtxtTo.ResetOnSpace = true;
            this.mtxtTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtTo.SelectedText = "";
            this.mtxtTo.SelectionLength = 0;
            this.mtxtTo.SelectionStart = 0;
            this.mtxtTo.ShortcutsEnabled = true;
            this.mtxtTo.Size = new System.Drawing.Size(390, 48);
            this.mtxtTo.SkipLiterals = true;
            this.mtxtTo.TabIndex = 9;
            this.mtxtTo.TabStop = false;
            this.mtxtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtTo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtTo.TrailingIcon = null;
            this.mtxtTo.UseSystemPasswordChar = false;
            this.mtxtTo.ValidatingType = null;
            // 
            // mtxtPasswdSender
            // 
            this.mtxtPasswdSender.AllowPromptAsInput = true;
            this.mtxtPasswdSender.AnimateReadOnly = false;
            this.mtxtPasswdSender.AsciiOnly = false;
            this.mtxtPasswdSender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtPasswdSender.BeepOnError = false;
            this.mtxtPasswdSender.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtPasswdSender.Depth = 0;
            this.mtxtPasswdSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtPasswdSender.HidePromptOnLeave = false;
            this.mtxtPasswdSender.HideSelection = true;
            this.mtxtPasswdSender.Hint = "Contraseña del remitente";
            this.mtxtPasswdSender.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtPasswdSender.LeadingIcon = null;
            this.mtxtPasswdSender.Location = new System.Drawing.Point(20, 166);
            this.mtxtPasswdSender.Mask = "";
            this.mtxtPasswdSender.MaxLength = 32767;
            this.mtxtPasswdSender.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtPasswdSender.Name = "mtxtPasswdSender";
            this.mtxtPasswdSender.PasswordChar = '●';
            this.mtxtPasswdSender.PrefixSuffixText = null;
            this.mtxtPasswdSender.PromptChar = '_';
            this.mtxtPasswdSender.ReadOnly = false;
            this.mtxtPasswdSender.RejectInputOnFirstFailure = false;
            this.mtxtPasswdSender.ResetOnPrompt = true;
            this.mtxtPasswdSender.ResetOnSpace = true;
            this.mtxtPasswdSender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtPasswdSender.SelectedText = "";
            this.mtxtPasswdSender.SelectionLength = 0;
            this.mtxtPasswdSender.SelectionStart = 0;
            this.mtxtPasswdSender.ShortcutsEnabled = true;
            this.mtxtPasswdSender.Size = new System.Drawing.Size(390, 48);
            this.mtxtPasswdSender.SkipLiterals = true;
            this.mtxtPasswdSender.TabIndex = 10;
            this.mtxtPasswdSender.TabStop = false;
            this.mtxtPasswdSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtPasswdSender.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtPasswdSender.TrailingIcon = null;
            this.mtxtPasswdSender.UseSystemPasswordChar = true;
            this.mtxtPasswdSender.ValidatingType = null;
            // 
            // mbtnConfirm
            // 
            this.mbtnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnConfirm.Depth = 0;
            this.mbtnConfirm.HighEmphasis = true;
            this.mbtnConfirm.Icon = null;
            this.mbtnConfirm.Location = new System.Drawing.Point(308, 446);
            this.mbtnConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnConfirm.Name = "mbtnConfirm";
            this.mbtnConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnConfirm.Size = new System.Drawing.Size(105, 36);
            this.mbtnConfirm.TabIndex = 11;
            this.mbtnConfirm.Text = "Confirmar";
            this.mbtnConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnConfirm.UseAccentColor = false;
            this.mbtnConfirm.UseVisualStyleBackColor = true;
            this.mbtnConfirm.Click += new System.EventHandler(this.mbtnConfirm_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.HighEmphasis = true;
            this.mbtnCancel.Icon = null;
            this.mbtnCancel.Location = new System.Drawing.Point(204, 446);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCancel.Size = new System.Drawing.Size(96, 36);
            this.mbtnCancel.TabIndex = 12;
            this.mbtnCancel.Text = "Cancelar";
            this.mbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCancel.UseAccentColor = false;
            this.mbtnCancel.UseVisualStyleBackColor = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mtxtSubject
            // 
            this.mtxtSubject.AllowPromptAsInput = true;
            this.mtxtSubject.AnimateReadOnly = false;
            this.mtxtSubject.AsciiOnly = false;
            this.mtxtSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtSubject.BeepOnError = false;
            this.mtxtSubject.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSubject.Depth = 0;
            this.mtxtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtSubject.HidePromptOnLeave = false;
            this.mtxtSubject.HideSelection = true;
            this.mtxtSubject.Hint = "Asunto";
            this.mtxtSubject.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtSubject.LeadingIcon = null;
            this.mtxtSubject.Location = new System.Drawing.Point(20, 304);
            this.mtxtSubject.Mask = "";
            this.mtxtSubject.MaxLength = 32767;
            this.mtxtSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtSubject.Name = "mtxtSubject";
            this.mtxtSubject.PasswordChar = '\0';
            this.mtxtSubject.PrefixSuffixText = null;
            this.mtxtSubject.PromptChar = '_';
            this.mtxtSubject.ReadOnly = false;
            this.mtxtSubject.RejectInputOnFirstFailure = false;
            this.mtxtSubject.ResetOnPrompt = true;
            this.mtxtSubject.ResetOnSpace = true;
            this.mtxtSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtSubject.SelectedText = "";
            this.mtxtSubject.SelectionLength = 0;
            this.mtxtSubject.SelectionStart = 0;
            this.mtxtSubject.ShortcutsEnabled = true;
            this.mtxtSubject.Size = new System.Drawing.Size(390, 48);
            this.mtxtSubject.SkipLiterals = true;
            this.mtxtSubject.TabIndex = 13;
            this.mtxtSubject.TabStop = false;
            this.mtxtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtSubject.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSubject.TrailingIcon = null;
            this.mtxtSubject.UseSystemPasswordChar = false;
            this.mtxtSubject.ValidatingType = null;
            // 
            // mtxtBody
            // 
            this.mtxtBody.AllowPromptAsInput = true;
            this.mtxtBody.AnimateReadOnly = false;
            this.mtxtBody.AsciiOnly = false;
            this.mtxtBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtBody.BeepOnError = false;
            this.mtxtBody.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtBody.Depth = 0;
            this.mtxtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtBody.HidePromptOnLeave = false;
            this.mtxtBody.HideSelection = true;
            this.mtxtBody.Hint = "Cuerpo";
            this.mtxtBody.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtBody.LeadingIcon = null;
            this.mtxtBody.Location = new System.Drawing.Point(20, 377);
            this.mtxtBody.Mask = "";
            this.mtxtBody.MaxLength = 32767;
            this.mtxtBody.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtBody.Name = "mtxtBody";
            this.mtxtBody.PasswordChar = '\0';
            this.mtxtBody.PrefixSuffixText = null;
            this.mtxtBody.PromptChar = '_';
            this.mtxtBody.ReadOnly = false;
            this.mtxtBody.RejectInputOnFirstFailure = false;
            this.mtxtBody.ResetOnPrompt = true;
            this.mtxtBody.ResetOnSpace = true;
            this.mtxtBody.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtBody.SelectedText = "";
            this.mtxtBody.SelectionLength = 0;
            this.mtxtBody.SelectionStart = 0;
            this.mtxtBody.ShortcutsEnabled = true;
            this.mtxtBody.Size = new System.Drawing.Size(390, 48);
            this.mtxtBody.SkipLiterals = true;
            this.mtxtBody.TabIndex = 14;
            this.mtxtBody.TabStop = false;
            this.mtxtBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtBody.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtBody.TrailingIcon = null;
            this.mtxtBody.UseSystemPasswordChar = false;
            this.mtxtBody.ValidatingType = null;
            // 
            // EmailDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 504);
            this.Controls.Add(this.mtxtBody);
            this.Controls.Add(this.mtxtSubject);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnConfirm);
            this.Controls.Add(this.mtxtPasswdSender);
            this.Controls.Add(this.mtxtTo);
            this.Controls.Add(this.mtxtSender);
            this.Controls.Add(this.lblTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleForm;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtSender;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtTo;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtPasswdSender;
        private MaterialSkin.Controls.MaterialButton mbtnConfirm;
        private MaterialSkin.Controls.MaterialButton mbtnCancel;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtSubject;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtxtBody;
    }
}