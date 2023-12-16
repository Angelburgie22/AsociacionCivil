
namespace AsociacionCivil
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPartner = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.reciboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asociacioncivilDataSet = new AsociacionCivil.asociacioncivilDataSet();
            this.reciboTableAdapter = new AsociacionCivil.asociacioncivilDataSetTableAdapters.reciboTableAdapter();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlSelection);
            this.pnlMenu.Controls.Add(this.btnPeriod);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnPartner);
            this.pnlMenu.Controls.Add(this.btnReceipt);
            this.pnlMenu.Controls.Add(this.pnlUsername);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(248, 710);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlSelection.Location = new System.Drawing.Point(-5, 193);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(10, 100);
            this.pnlSelection.TabIndex = 5;
            // 
            // btnPeriod
            // 
            this.btnPeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeriod.FlatAppearance.BorderSize = 0;
            this.btnPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriod.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriod.ForeColor = System.Drawing.Color.White;
            this.btnPeriod.Location = new System.Drawing.Point(0, 346);
            this.btnPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(248, 52);
            this.btnPeriod.TabIndex = 4;
            this.btnPeriod.Text = "Periodos";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 658);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(248, 52);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 294);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(248, 52);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administradores";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            this.btnAdmin.Leave += new System.EventHandler(this.btnAdmin_Leave);
            // 
            // btnPartner
            // 
            this.btnPartner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartner.FlatAppearance.BorderSize = 0;
            this.btnPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartner.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner.ForeColor = System.Drawing.Color.White;
            this.btnPartner.Location = new System.Drawing.Point(0, 242);
            this.btnPartner.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartner.Name = "btnPartner";
            this.btnPartner.Size = new System.Drawing.Size(248, 52);
            this.btnPartner.TabIndex = 1;
            this.btnPartner.Text = "Socios";
            this.btnPartner.UseVisualStyleBackColor = true;
            this.btnPartner.Click += new System.EventHandler(this.btnPartner_Click);
            this.btnPartner.Leave += new System.EventHandler(this.btnPartner_Leave);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Location = new System.Drawing.Point(0, 190);
            this.btnReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(248, 52);
            this.btnReceipt.TabIndex = 1;
            this.btnReceipt.Text = "Recibos";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            this.btnReceipt.Leave += new System.EventHandler(this.btnReceipt_Leave);
            // 
            // pnlUsername
            // 
            this.pnlUsername.Controls.Add(this.lblUsername);
            this.pnlUsername.Controls.Add(this.picUser);
            this.pnlUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsername.Location = new System.Drawing.Point(0, 0);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(248, 190);
            this.pnlUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(85, 119);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Usuario";
            // 
            // picUser
            // 
            this.picUser.Image = global::AsociacionCivil.Properties.Resources.memes;
            this.picUser.Location = new System.Drawing.Point(80, 27);
            this.picUser.Margin = new System.Windows.Forms.Padding(4);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(84, 78);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // reciboBindingSource
            // 
            this.reciboBindingSource.DataMember = "recibo";
            this.reciboBindingSource.DataSource = this.asociacioncivilDataSet;
            // 
            // asociacioncivilDataSet
            // 
            this.asociacioncivilDataSet.DataSetName = "asociacioncivilDataSet";
            this.asociacioncivilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reciboTableAdapter
            // 
            this.reciboTableAdapter.ClearBeforeFill = true;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(248, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1020, 62);
            this.pnlTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(8, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 38);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Recibos";
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(248, 65);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1020, 645);
            this.pnlFormLoader.TabIndex = 6;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 710);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asociacioncivilDataSet)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPartner;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Label lblUsername;
        private asociacioncivilDataSet asociacioncivilDataSet;
        private System.Windows.Forms.BindingSource reciboBindingSource;
        private asociacioncivilDataSetTableAdapters.reciboTableAdapter reciboTableAdapter;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Panel pnlSelection;
    }
}

