namespace POO22B_FPA
{
    partial class DlgLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgLogin));
            this.PtbIcon = new System.Windows.Forms.PictureBox();
            this.PtbOptions = new System.Windows.Forms.PictureBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnLog_in = new System.Windows.Forms.Button();
            this.LnkLblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.LnkLblSign_Up = new System.Windows.Forms.LinkLabel();
            this.FlPnlOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.PtbOptionsIn = new System.Windows.Forms.PictureBox();
            this.PtbClose = new System.Windows.Forms.PictureBox();
            this.TltDescription = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PtbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptions)).BeginInit();
            this.FlPnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptionsIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbIcon
            // 
            this.PtbIcon.BackColor = System.Drawing.Color.Transparent;
            this.PtbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbIcon.Image = global::POO22B_FPA.Properties.Resources.P10_Usuario;
            this.PtbIcon.Location = new System.Drawing.Point(13, 13);
            this.PtbIcon.Name = "PtbIcon";
            this.PtbIcon.Size = new System.Drawing.Size(64, 64);
            this.PtbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PtbIcon.TabIndex = 0;
            this.PtbIcon.TabStop = false;
            // 
            // PtbOptions
            // 
            this.PtbOptions.BackColor = System.Drawing.Color.Transparent;
            this.PtbOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbOptions.Image = global::POO22B_FPA.Properties.Resources.P10_Menu;
            this.PtbOptions.Location = new System.Drawing.Point(290, 12);
            this.PtbOptions.Name = "PtbOptions";
            this.PtbOptions.Size = new System.Drawing.Size(48, 48);
            this.PtbOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PtbOptions.TabIndex = 1;
            this.PtbOptions.TabStop = false;
            this.PtbOptions.Click += new System.EventHandler(this.PtbOptions_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.BackColor = System.Drawing.Color.Transparent;
            this.LblDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.LblDescription.Location = new System.Drawing.Point(12, 364);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(326, 19);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Ingresa tu cuenta para continuar.";
            this.LblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLogin
            // 
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.White;
            this.LblLogin.Location = new System.Drawing.Point(12, 309);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(326, 55);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Login";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(12, 412);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(326, 25);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.White;
            this.TxtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtName.Location = new System.Drawing.Point(12, 440);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(326, 40);
            this.TxtName.TabIndex = 5;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.White;
            this.TxtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtPassword.Location = new System.Drawing.Point(12, 514);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(326, 40);
            this.TxtPassword.TabIndex = 7;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(12, 486);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(326, 25);
            this.LblPassword.TabIndex = 6;
            this.LblPassword.Text = "Contraseña";
            // 
            // BtnLog_in
            // 
            this.BtnLog_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.BtnLog_in.FlatAppearance.BorderSize = 0;
            this.BtnLog_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLog_in.Font = new System.Drawing.Font("Myanmar Text", 14.25F);
            this.BtnLog_in.Location = new System.Drawing.Point(12, 570);
            this.BtnLog_in.Name = "BtnLog_in";
            this.BtnLog_in.Size = new System.Drawing.Size(326, 40);
            this.BtnLog_in.TabIndex = 1;
            this.BtnLog_in.Text = "Iniciar sesión";
            this.BtnLog_in.UseVisualStyleBackColor = false;
            this.BtnLog_in.Click += new System.EventHandler(this.BtnLog_in_Click);
            // 
            // LnkLblForgotPassword
            // 
            this.LnkLblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblForgotPassword.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LnkLblForgotPassword.LinkColor = System.Drawing.Color.White;
            this.LnkLblForgotPassword.Location = new System.Drawing.Point(15, 628);
            this.LnkLblForgotPassword.Name = "LnkLblForgotPassword";
            this.LnkLblForgotPassword.Size = new System.Drawing.Size(323, 23);
            this.LnkLblForgotPassword.TabIndex = 10;
            this.LnkLblForgotPassword.TabStop = true;
            this.LnkLblForgotPassword.Text = "¿Olvidaste tu contraseña?";
            this.LnkLblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LnkLblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblForgotPassword_LinkClicked);
            // 
            // LnkLblSign_Up
            // 
            this.LnkLblSign_Up.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblSign_Up.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LnkLblSign_Up.LinkColor = System.Drawing.Color.White;
            this.LnkLblSign_Up.Location = new System.Drawing.Point(15, 651);
            this.LnkLblSign_Up.Name = "LnkLblSign_Up";
            this.LnkLblSign_Up.Size = new System.Drawing.Size(323, 23);
            this.LnkLblSign_Up.TabIndex = 11;
            this.LnkLblSign_Up.TabStop = true;
            this.LnkLblSign_Up.Text = "Registrate";
            this.LnkLblSign_Up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LnkLblSign_Up.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblSign_Up_LinkClicked);
            // 
            // FlPnlOptions
            // 
            this.FlPnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.FlPnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlPnlOptions.Controls.Add(this.PtbOptionsIn);
            this.FlPnlOptions.Controls.Add(this.PtbClose);
            this.FlPnlOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlPnlOptions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlPnlOptions.Location = new System.Drawing.Point(350, 0);
            this.FlPnlOptions.Name = "FlPnlOptions";
            this.FlPnlOptions.Padding = new System.Windows.Forms.Padding(0, 9, 7, 0);
            this.FlPnlOptions.Size = new System.Drawing.Size(0, 700);
            this.FlPnlOptions.TabIndex = 12;
            // 
            // PtbOptionsIn
            // 
            this.PtbOptionsIn.BackColor = System.Drawing.Color.Transparent;
            this.PtbOptionsIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbOptionsIn.Image = global::POO22B_FPA.Properties.Resources.P10_Menu;
            this.PtbOptionsIn.Location = new System.Drawing.Point(-58, 12);
            this.PtbOptionsIn.Name = "PtbOptionsIn";
            this.PtbOptionsIn.Size = new System.Drawing.Size(48, 48);
            this.PtbOptionsIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PtbOptionsIn.TabIndex = 2;
            this.PtbOptionsIn.TabStop = false;
            this.PtbOptionsIn.Click += new System.EventHandler(this.PtbOptions_Click);
            // 
            // PtbClose
            // 
            this.PtbClose.BackColor = System.Drawing.Color.Transparent;
            this.PtbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbClose.Image = global::POO22B_FPA.Properties.Resources.P10_Apagar;
            this.PtbClose.Location = new System.Drawing.Point(-58, 66);
            this.PtbClose.Name = "PtbClose";
            this.PtbClose.Size = new System.Drawing.Size(48, 48);
            this.PtbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PtbClose.TabIndex = 1;
            this.PtbClose.TabStop = false;
            this.PtbClose.Click += new System.EventHandler(this.PtbClose_Click);
            // 
            // TltDescription
            // 
            this.TltDescription.IsBalloon = true;
            // 
            // DlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::POO22B_FPA.Properties.Resources.P10_Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 700);
            this.Controls.Add(this.FlPnlOptions);
            this.Controls.Add(this.LnkLblSign_Up);
            this.Controls.Add(this.LnkLblForgotPassword);
            this.Controls.Add(this.BtnLog_in);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.PtbOptions);
            this.Controls.Add(this.PtbIcon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DlgLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DlgLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PtbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptions)).EndInit();
            this.FlPnlOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptionsIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbIcon;
        private System.Windows.Forms.PictureBox PtbOptions;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnLog_in;
        private System.Windows.Forms.LinkLabel LnkLblForgotPassword;
        private System.Windows.Forms.LinkLabel LnkLblSign_Up;
        private System.Windows.Forms.FlowLayoutPanel FlPnlOptions;
        private System.Windows.Forms.PictureBox PtbClose;
        private System.Windows.Forms.PictureBox PtbOptionsIn;
        private System.Windows.Forms.ToolTip TltDescription;
        private System.Windows.Forms.TextBox TxtName;
    }
}