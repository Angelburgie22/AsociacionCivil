namespace AsociacionCivil
{
    partial class RegisterUser
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
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.mmtxtUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mmtxtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.gpbUserLevel = new System.Windows.Forms.GroupBox();
            this.mrbALevel = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbELevel = new MaterialSkin.Controls.MaterialRadioButton();
            this.mbtnCreateUser = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.gpbUserLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(13, 9);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(250, 45);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Nuevo Usuario";
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
            this.mmtxtUsername.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtUsername.HidePromptOnLeave = false;
            this.mmtxtUsername.HideSelection = true;
            this.mmtxtUsername.Hint = "Nombre de usuario";
            this.mmtxtUsername.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtUsername.LeadingIcon = null;
            this.mmtxtUsername.Location = new System.Drawing.Point(21, 82);
            this.mmtxtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.mmtxtUsername.Size = new System.Drawing.Size(184, 48);
            this.mmtxtUsername.SkipLiterals = true;
            this.mmtxtUsername.TabIndex = 8;
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
            this.mmtxtPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtxtPassword.HidePromptOnLeave = false;
            this.mmtxtPassword.HideSelection = true;
            this.mmtxtPassword.Hint = "Contraseña";
            this.mmtxtPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtxtPassword.LeadingIcon = null;
            this.mmtxtPassword.Location = new System.Drawing.Point(238, 82);
            this.mmtxtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.mmtxtPassword.Size = new System.Drawing.Size(184, 48);
            this.mmtxtPassword.SkipLiterals = true;
            this.mmtxtPassword.TabIndex = 9;
            this.mmtxtPassword.TabStop = false;
            this.mmtxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtxtPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtxtPassword.TrailingIcon = null;
            this.mmtxtPassword.UseSystemPasswordChar = true;
            this.mmtxtPassword.ValidatingType = null;
            this.mmtxtPassword.TextChanged += new System.EventHandler(this.mmtxtPassword_TextChanged);
            // 
            // gpbUserLevel
            // 
            this.gpbUserLevel.Controls.Add(this.mrbALevel);
            this.gpbUserLevel.Controls.Add(this.mrbELevel);
            this.gpbUserLevel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbUserLevel.Location = new System.Drawing.Point(21, 160);
            this.gpbUserLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbUserLevel.Name = "gpbUserLevel";
            this.gpbUserLevel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbUserLevel.Size = new System.Drawing.Size(289, 82);
            this.gpbUserLevel.TabIndex = 41;
            this.gpbUserLevel.TabStop = false;
            this.gpbUserLevel.Text = "Nivel de usuario:";
            // 
            // mrbALevel
            // 
            this.mrbALevel.AutoSize = true;
            this.mrbALevel.Depth = 0;
            this.mrbALevel.Location = new System.Drawing.Point(161, 31);
            this.mrbALevel.Margin = new System.Windows.Forms.Padding(0);
            this.mrbALevel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbALevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbALevel.Name = "mrbALevel";
            this.mrbALevel.Ripple = true;
            this.mrbALevel.Size = new System.Drawing.Size(100, 37);
            this.mrbALevel.TabIndex = 43;
            this.mrbALevel.TabStop = true;
            this.mrbALevel.Text = "Asistente";
            this.mrbALevel.UseVisualStyleBackColor = true;
            // 
            // mrbELevel
            // 
            this.mrbELevel.AutoSize = true;
            this.mrbELevel.Checked = true;
            this.mrbELevel.Depth = 0;
            this.mrbELevel.Location = new System.Drawing.Point(13, 31);
            this.mrbELevel.Margin = new System.Windows.Forms.Padding(0);
            this.mrbELevel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbELevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbELevel.Name = "mrbELevel";
            this.mrbELevel.Ripple = true;
            this.mrbELevel.Size = new System.Drawing.Size(111, 37);
            this.mrbELevel.TabIndex = 42;
            this.mrbELevel.TabStop = true;
            this.mrbELevel.Text = "Encargado";
            this.mrbELevel.UseVisualStyleBackColor = true;
            // 
            // mbtnCreateUser
            // 
            this.mbtnCreateUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCreateUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCreateUser.Depth = 0;
            this.mbtnCreateUser.HighEmphasis = true;
            this.mbtnCreateUser.Icon = null;
            this.mbtnCreateUser.Location = new System.Drawing.Point(340, 281);
            this.mbtnCreateUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCreateUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCreateUser.Name = "mbtnCreateUser";
            this.mbtnCreateUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCreateUser.Size = new System.Drawing.Size(67, 36);
            this.mbtnCreateUser.TabIndex = 42;
            this.mbtnCreateUser.Text = "Crear";
            this.mbtnCreateUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCreateUser.UseAccentColor = false;
            this.mbtnCreateUser.UseVisualStyleBackColor = true;
            this.mbtnCreateUser.Click += new System.EventHandler(this.mbtnCreateUser_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.HighEmphasis = true;
            this.mbtnCancel.Icon = null;
            this.mbtnCancel.Location = new System.Drawing.Point(227, 281);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCancel.Size = new System.Drawing.Size(96, 36);
            this.mbtnCancel.TabIndex = 43;
            this.mbtnCancel.Text = "Cancelar";
            this.mbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCancel.UseAccentColor = false;
            this.mbtnCancel.UseVisualStyleBackColor = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 337);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnCreateUser);
            this.Controls.Add(this.gpbUserLevel);
            this.Controls.Add(this.mmtxtPassword);
            this.Controls.Add(this.mmtxtUsername);
            this.Controls.Add(this.lbl_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.gpbUserLevel.ResumeLayout(false);
            this.gpbUserLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtUsername;
        private MaterialSkin.Controls.MaterialMaskedTextBox mmtxtPassword;
        private System.Windows.Forms.GroupBox gpbUserLevel;
        private MaterialSkin.Controls.MaterialRadioButton mrbALevel;
        private MaterialSkin.Controls.MaterialRadioButton mrbELevel;
        private MaterialSkin.Controls.MaterialButton mbtnCreateUser;
        private MaterialSkin.Controls.MaterialButton mbtnCancel;
    }
}