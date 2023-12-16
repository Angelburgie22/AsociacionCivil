
namespace AsociacionCivil
{
    partial class LoginForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.mmtxtUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mbtnLogin = new MaterialSkin.Controls.MaterialButton();
            this.mchkRemember = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 38);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Inicia sesión a Asociación Civil";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(42, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entra a la aplicación de gestión de recibos de la asociación civil, y administra " +
    "a tus socios.";
            // 
            // picPerson
            // 
            this.picPerson.Image = global::AsociacionCivil.Properties.Resources.personbg;
            this.picPerson.Location = new System.Drawing.Point(555, 93);
            this.picPerson.Name = "picPerson";
            this.picPerson.Size = new System.Drawing.Size(289, 291);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerson.TabIndex = 6;
            this.picPerson.TabStop = false;
            // 
            // mmtxtUsername
            // 
            this.mmtxtUsername.AllowPromptAsInput = true;
            this.mmtxtUsername.AnimateReadOnly = false;
            this.mmtxtUsername.AsciiOnly = false;
            this.mmtxtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtUsername.BeepOnError = false;
            this.mmtxtUsername.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtUsername.Depth = 0;
            this.mmtxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mmtxtUsername.HidePromptOnLeave = false;
            this.mmtxtUsername.HideSelection = true;
            this.mmtxtUsername.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtUsername.LeadingIcon = null;
            this.mmtxtUsername.Location = new System.Drawing.Point(46, 171);
            this.mmtxtUsername.Mask = "";
            this.mmtxtUsername.MaxLength = 32767;
            this.mmtxtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtUsername.Name = "mmtxtUsername";
            this.mmtxtUsername.PasswordChar = '\0';
            this.mmtxtUsername.PrefixSuffixText = null;
            this.mmtxtUsername.PromptChar = '_';
            this.mmtxtUsername.ReadOnly = false;
            this.mmtxtUsername.RejectInputOnFirstFailure = false;
            this.mmtxtUsername.ResetOnPrompt = true;
            this.mmtxtUsername.ResetOnSpace = true;
            this.mmtxtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtUsername.SelectedText = "";
            this.mmtxtUsername.SelectionLength = 0;
            this.mmtxtUsername.SelectionStart = 0;
            this.mmtxtUsername.ShortcutsEnabled = true;
            this.mmtxtUsername.Size = new System.Drawing.Size(390, 48);
            this.mmtxtUsername.SkipLiterals = true;
            this.mmtxtUsername.TabIndex = 7;
            this.mmtxtUsername.TabStop = false;
            this.mmtxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtUsername.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtUsername.TrailingIcon = null;
            this.mmtxtUsername.UseSystemPasswordChar = false;
            this.mmtxtUsername.ValidatingType = null;
            this.mmtxtUsername.TextChanged += new System.EventHandler(this.mmtxtUsername_TextChanged);
            // 
            // mmtxtPassword
            // 
            this.mmtxtPassword.AllowPromptAsInput = true;
            this.mmtxtPassword.AnimateReadOnly = false;
            this.mmtxtPassword.AsciiOnly = false;
            this.mmtxtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtxtPassword.BeepOnError = false;
            this.mmtxtPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtPassword.Depth = 0;
            this.mmtxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mmtxtPassword.HidePromptOnLeave = false;
            this.mmtxtPassword.HideSelection = true;
            this.mmtxtPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtPassword.LeadingIcon = null;
            this.mmtxtPassword.Location = new System.Drawing.Point(46, 252);
            this.mmtxtPassword.Mask = "";
            this.mmtxtPassword.MaxLength = 32767;
            this.mmtxtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.mmtxtPassword.Name = "mmtxtPassword";
            this.mmtxtPassword.PasswordChar = '●';
            this.mmtxtPassword.PrefixSuffixText = null;
            this.mmtxtPassword.PromptChar = '_';
            this.mmtxtPassword.ReadOnly = false;
            this.mmtxtPassword.RejectInputOnFirstFailure = false;
            this.mmtxtPassword.ResetOnPrompt = true;
            this.mmtxtPassword.ResetOnSpace = true;
            this.mmtxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtxtPassword.SelectedText = "";
            this.mmtxtPassword.SelectionLength = 0;
            this.mmtxtPassword.SelectionStart = 0;
            this.mmtxtPassword.ShortcutsEnabled = true;
            this.mmtxtPassword.Size = new System.Drawing.Size(390, 48);
            this.mmtxtPassword.SkipLiterals = true;
            this.mmtxtPassword.TabIndex = 8;
            this.mmtxtPassword.TabStop = false;
            this.mmtxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtPassword.TrailingIcon = null;
            this.mmtxtPassword.UseSystemPasswordChar = true;
            this.mmtxtPassword.ValidatingType = null;
            this.mmtxtPassword.TextChanged += new System.EventHandler(this.mmtxtPassword_TextChanged);
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.AutoSize = false;
            this.mbtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnLogin.Depth = 0;
            this.mbtnLogin.HighEmphasis = true;
            this.mbtnLogin.Icon = null;
            this.mbtnLogin.Location = new System.Drawing.Point(46, 375);
            this.mbtnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnLogin.Size = new System.Drawing.Size(390, 36);
            this.mbtnLogin.TabIndex = 9;
            this.mbtnLogin.Text = "Iniciar sesión";
            this.mbtnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnLogin.UseAccentColor = false;
            this.mbtnLogin.UseVisualStyleBackColor = true;
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // mchkRemember
            // 
            this.mchkRemember.AutoSize = true;
            this.mchkRemember.Depth = 0;
            this.mchkRemember.Location = new System.Drawing.Point(46, 315);
            this.mchkRemember.Margin = new System.Windows.Forms.Padding(0);
            this.mchkRemember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkRemember.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkRemember.Name = "mchkRemember";
            this.mchkRemember.ReadOnly = false;
            this.mchkRemember.Ripple = true;
            this.mchkRemember.Size = new System.Drawing.Size(123, 37);
            this.mchkRemember.TabIndex = 10;
            this.mchkRemember.Text = "Recuérdame";
            this.mchkRemember.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(948, 484);
            this.Controls.Add(this.mchkRemember);
            this.Controls.Add(this.mbtnLogin);
            this.Controls.Add(this.mmtxtPassword);
            this.Controls.Add(this.mmtxtUsername);
            this.Controls.Add(this.picPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociación Civil";
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPerson;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtUsername;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtPassword;
        private MaterialSkin.Controls.MaterialButton mbtnLogin;
        private MaterialSkin.Controls.MaterialCheckbox mchkRemember;
    }
}

