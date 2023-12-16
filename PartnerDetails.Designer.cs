
namespace AsociacionCivil
{
    partial class PartnerDetails
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.mbtnClose = new MaterialSkin.Controls.MaterialButton();
            this.pnlNewPartnerForm = new System.Windows.Forms.Panel();
            this.mmtxtState = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtCity = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.tlpPhoneFields = new System.Windows.Forms.TableLayoutPanel();
            this.mmtxtPrototype = new MaterialSkin.Controls.MaterialMaskedTextBox();
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
            this.lblTitleForm.Size = new System.Drawing.Size(144, 45);
            this.lblTitleForm.TabIndex = 0;
            this.lblTitleForm.Text = "Detalles";
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
            this.mmtxtRFC.Enabled = false;
            this.mmtxtRFC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtRFC.HidePromptOnLeave = false;
            this.mmtxtRFC.HideSelection = true;
            this.mmtxtRFC.Hint = "RFC";
            this.mmtxtRFC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtRFC.LeadingIcon = null;
            this.mmtxtRFC.Location = new System.Drawing.Point(32, 112);
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
            this.mmtxtRFC.TabIndex = 10;
            this.mmtxtRFC.TabStop = false;
            this.mmtxtRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtRFC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtRFC.TrailingIcon = null;
            this.mmtxtRFC.UseSystemPasswordChar = false;
            this.mmtxtRFC.ValidatingType = null;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(28, 277);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(81, 23);
            this.lblPhone.TabIndex = 32;
            this.lblPhone.Text = "Teléfonos";
            // 
            // mbtnClose
            // 
            this.mbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mbtnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnClose.Depth = 0;
            this.mbtnClose.HighEmphasis = true;
            this.mbtnClose.Icon = null;
            this.mbtnClose.Location = new System.Drawing.Point(391, 12);
            this.mbtnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnClose.Name = "mbtnClose";
            this.mbtnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnClose.Size = new System.Drawing.Size(77, 36);
            this.mbtnClose.TabIndex = 35;
            this.mbtnClose.Text = "Cerrar";
            this.mbtnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnClose.UseAccentColor = false;
            this.mbtnClose.UseVisualStyleBackColor = false;
            this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
            // 
            // pnlNewPartnerForm
            // 
            this.pnlNewPartnerForm.AutoScroll = true;
            this.pnlNewPartnerForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtState);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtCity);
            this.pnlNewPartnerForm.Controls.Add(this.tlpPhoneFields);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtPrototype);
            this.pnlNewPartnerForm.Controls.Add(this.pnlButtonsStrip);
            this.pnlNewPartnerForm.Controls.Add(this.lblPhone);
            this.pnlNewPartnerForm.Controls.Add(this.lblTitleForm);
            this.pnlNewPartnerForm.Controls.Add(this.mmtxtRFC);
            this.pnlNewPartnerForm.Location = new System.Drawing.Point(0, 0);
            this.pnlNewPartnerForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNewPartnerForm.Name = "pnlNewPartnerForm";
            this.pnlNewPartnerForm.Size = new System.Drawing.Size(486, 441);
            this.pnlNewPartnerForm.TabIndex = 36;
            // 
            // mmtxtState
            // 
            this.mmtxtState.AllowPromptAsInput = true;
            this.mmtxtState.AnimateReadOnly = false;
            this.mmtxtState.AsciiOnly = false;
            this.mmtxtState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtState.BeepOnError = false;
            this.mmtxtState.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtState.Depth = 0;
            this.mmtxtState.Enabled = false;
            this.mmtxtState.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtState.HidePromptOnLeave = false;
            this.mmtxtState.HideSelection = true;
            this.mmtxtState.Hint = "Estado";
            this.mmtxtState.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtState.LeadingIcon = null;
            this.mmtxtState.Location = new System.Drawing.Point(270, 197);
            this.mmtxtState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtState.Mask = "";
            this.mmtxtState.MaxLength = 32767;
            this.mmtxtState.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtState.Name = "mmtxtState";
            this.mmtxtState.PasswordChar = '\0';
            this.mmtxtState.PrefixSuffixText = null;
            this.mmtxtState.PromptChar = '_';
            this.mmtxtState.ReadOnly = false;
            this.mmtxtState.RejectInputOnFirstFailure = false;
            this.mmtxtState.ResetOnPrompt = true;
            this.mmtxtState.ResetOnSpace = true;
            this.mmtxtState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtState.SelectedText = "";
            this.mmtxtState.SelectionLength = 0;
            this.mmtxtState.SelectionStart = 0;
            this.mmtxtState.ShortcutsEnabled = true;
            this.mmtxtState.Size = new System.Drawing.Size(184, 48);
            this.mmtxtState.SkipLiterals = true;
            this.mmtxtState.TabIndex = 41;
            this.mmtxtState.TabStop = false;
            this.mmtxtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtState.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtState.TrailingIcon = null;
            this.mmtxtState.UseSystemPasswordChar = false;
            this.mmtxtState.ValidatingType = null;
            // 
            // mmtxtCity
            // 
            this.mmtxtCity.AllowPromptAsInput = true;
            this.mmtxtCity.AnimateReadOnly = false;
            this.mmtxtCity.AsciiOnly = false;
            this.mmtxtCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtCity.BeepOnError = false;
            this.mmtxtCity.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtCity.Depth = 0;
            this.mmtxtCity.Enabled = false;
            this.mmtxtCity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtCity.HidePromptOnLeave = false;
            this.mmtxtCity.HideSelection = true;
            this.mmtxtCity.Hint = "Ciudad";
            this.mmtxtCity.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtCity.LeadingIcon = null;
            this.mmtxtCity.Location = new System.Drawing.Point(31, 197);
            this.mmtxtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtCity.Mask = "";
            this.mmtxtCity.MaxLength = 32767;
            this.mmtxtCity.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtCity.Name = "mmtxtCity";
            this.mmtxtCity.PasswordChar = '\0';
            this.mmtxtCity.PrefixSuffixText = null;
            this.mmtxtCity.PromptChar = '_';
            this.mmtxtCity.ReadOnly = false;
            this.mmtxtCity.RejectInputOnFirstFailure = false;
            this.mmtxtCity.ResetOnPrompt = true;
            this.mmtxtCity.ResetOnSpace = true;
            this.mmtxtCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtCity.SelectedText = "";
            this.mmtxtCity.SelectionLength = 0;
            this.mmtxtCity.SelectionStart = 0;
            this.mmtxtCity.ShortcutsEnabled = true;
            this.mmtxtCity.Size = new System.Drawing.Size(184, 48);
            this.mmtxtCity.SkipLiterals = true;
            this.mmtxtCity.TabIndex = 40;
            this.mmtxtCity.TabStop = false;
            this.mmtxtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtCity.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtCity.TrailingIcon = null;
            this.mmtxtCity.UseSystemPasswordChar = false;
            this.mmtxtCity.ValidatingType = null;
            // 
            // tlpPhoneFields
            // 
            this.tlpPhoneFields.AutoSize = true;
            this.tlpPhoneFields.ColumnCount = 2;
            this.tlpPhoneFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.35571F));
            this.tlpPhoneFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.64429F));
            this.tlpPhoneFields.Location = new System.Drawing.Point(32, 302);
            this.tlpPhoneFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPhoneFields.Name = "tlpPhoneFields";
            this.tlpPhoneFields.RowCount = 1;
            this.tlpPhoneFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPhoneFields.Size = new System.Drawing.Size(298, 48);
            this.tlpPhoneFields.TabIndex = 39;
            // 
            // mmtxtPrototype
            // 
            this.mmtxtPrototype.AllowPromptAsInput = true;
            this.mmtxtPrototype.AnimateReadOnly = false;
            this.mmtxtPrototype.AsciiOnly = false;
            this.mmtxtPrototype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtPrototype.BeepOnError = false;
            this.mmtxtPrototype.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtPrototype.Depth = 0;
            this.mmtxtPrototype.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtPrototype.HidePromptOnLeave = false;
            this.mmtxtPrototype.HideSelection = true;
            this.mmtxtPrototype.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtPrototype.LeadingIcon = null;
            this.mmtxtPrototype.Location = new System.Drawing.Point(284, 24);
            this.mmtxtPrototype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mmtxtPrototype.Mask = "";
            this.mmtxtPrototype.MaxLength = 32767;
            this.mmtxtPrototype.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtPrototype.Name = "mmtxtPrototype";
            this.mmtxtPrototype.PasswordChar = '\0';
            this.mmtxtPrototype.PrefixSuffixText = null;
            this.mmtxtPrototype.PromptChar = '_';
            this.mmtxtPrototype.ReadOnly = false;
            this.mmtxtPrototype.RejectInputOnFirstFailure = false;
            this.mmtxtPrototype.ResetOnPrompt = true;
            this.mmtxtPrototype.ResetOnSpace = true;
            this.mmtxtPrototype.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtPrototype.SelectedText = "";
            this.mmtxtPrototype.SelectionLength = 0;
            this.mmtxtPrototype.SelectionStart = 0;
            this.mmtxtPrototype.ShortcutsEnabled = true;
            this.mmtxtPrototype.Size = new System.Drawing.Size(184, 48);
            this.mmtxtPrototype.SkipLiterals = true;
            this.mmtxtPrototype.TabIndex = 38;
            this.mmtxtPrototype.TabStop = false;
            this.mmtxtPrototype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtPrototype.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtPrototype.TrailingIcon = null;
            this.mmtxtPrototype.UseSystemPasswordChar = false;
            this.mmtxtPrototype.ValidatingType = null;
            this.mmtxtPrototype.Visible = false;
            // 
            // pnlButtonsStrip
            // 
            this.pnlButtonsStrip.Controls.Add(this.mbtnClose);
            this.pnlButtonsStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsStrip.Location = new System.Drawing.Point(0, 377);
            this.pnlButtonsStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonsStrip.Name = "pnlButtonsStrip";
            this.pnlButtonsStrip.Size = new System.Drawing.Size(486, 64);
            this.pnlButtonsStrip.TabIndex = 37;
            // 
            // PartnerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(486, 440);
            this.Controls.Add(this.pnlNewPartnerForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PartnerDetails";
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
        private System.Windows.Forms.Label lblPhone;
        private MaterialSkin.Controls.MaterialButton mbtnClose;
        private System.Windows.Forms.Panel pnlNewPartnerForm;
        private System.Windows.Forms.Panel pnlButtonsStrip;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtPrototype;
        private System.Windows.Forms.TableLayoutPanel tlpPhoneFields;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtState;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtCity;
    }
}