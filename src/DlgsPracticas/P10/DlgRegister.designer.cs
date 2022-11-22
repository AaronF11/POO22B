namespace POO22B_FPA
{
    partial class DlgRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgRegister));
            this.PtbIcon = new System.Windows.Forms.PictureBox();
            this.PtbOptions = new System.Windows.Forms.PictureBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnSign_up = new System.Windows.Forms.Button();
            this.FlPnlOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.PtbOptionsIn = new System.Windows.Forms.PictureBox();
            this.PtbClose = new System.Windows.Forms.PictureBox();
            this.PtbReturn = new System.Windows.Forms.PictureBox();
            this.TltDescription = new System.Windows.Forms.ToolTip(this.components);
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PtbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptions)).BeginInit();
            this.FlPnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptionsIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbIcon
            // 
            this.PtbIcon.BackColor = System.Drawing.Color.Transparent;
            this.PtbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbIcon.Image = global::POO22B_FPA.Properties.Resources.P10_Usuario;
            this.PtbIcon.Location = new System.Drawing.Point(274, 12);
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
            this.PtbOptions.Location = new System.Drawing.Point(12, 12);
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
            this.LblDescription.Location = new System.Drawing.Point(12, 330);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(326, 19);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "¿Aún no está registrado? Registra aquí.";
            this.LblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLogin
            // 
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.White;
            this.LblLogin.Location = new System.Drawing.Point(12, 255);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(326, 75);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Crear nueva \r\ncuenta";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(12, 382);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(326, 25);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.White;
            this.TxtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtName.Location = new System.Drawing.Point(12, 410);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(326, 40);
            this.TxtName.TabIndex = 2;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 20.25F);
            this.TxtPassword.ForeColor = System.Drawing.Color.White;
            this.TxtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtPassword.Location = new System.Drawing.Point(12, 552);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(326, 40);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(12, 524);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(326, 25);
            this.LblPassword.TabIndex = 6;
            this.LblPassword.Text = "Contraseña";
            // 
            // BtnSign_up
            // 
            this.BtnSign_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.BtnSign_up.FlatAppearance.BorderSize = 0;
            this.BtnSign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSign_up.Font = new System.Drawing.Font("Myanmar Text", 14.25F);
            this.BtnSign_up.Location = new System.Drawing.Point(12, 608);
            this.BtnSign_up.Name = "BtnSign_up";
            this.BtnSign_up.Size = new System.Drawing.Size(326, 40);
            this.BtnSign_up.TabIndex = 1;
            this.BtnSign_up.Text = "Registrarse";
            this.BtnSign_up.UseVisualStyleBackColor = false;
            this.BtnSign_up.Click += new System.EventHandler(this.BtnSign_up_Click);
            // 
            // FlPnlOptions
            // 
            this.FlPnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.FlPnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlPnlOptions.Controls.Add(this.PtbOptionsIn);
            this.FlPnlOptions.Controls.Add(this.PtbClose);
            this.FlPnlOptions.Controls.Add(this.PtbReturn);
            this.FlPnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlPnlOptions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlPnlOptions.Location = new System.Drawing.Point(0, 0);
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
            // PtbReturn
            // 
            this.PtbReturn.BackColor = System.Drawing.Color.Transparent;
            this.PtbReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbReturn.Image = global::POO22B_FPA.Properties.Resources.P10_Regresar;
            this.PtbReturn.Location = new System.Drawing.Point(-58, 120);
            this.PtbReturn.Name = "PtbReturn";
            this.PtbReturn.Size = new System.Drawing.Size(48, 48);
            this.PtbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PtbReturn.TabIndex = 3;
            this.PtbReturn.TabStop = false;
            this.PtbReturn.Click += new System.EventHandler(this.PtbReturn_Click);
            // 
            // TltDescription
            // 
            this.TltDescription.IsBalloon = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.White;
            this.TxtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtEmail.Location = new System.Drawing.Point(12, 480);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(326, 40);
            this.TxtEmail.TabIndex = 3;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblEmail
            // 
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.White;
            this.LblEmail.Location = new System.Drawing.Point(12, 452);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(326, 25);
            this.LblEmail.TabIndex = 13;
            this.LblEmail.Text = "Correo electronico";
            // 
            // DlgRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::POO22B_FPA.Properties.Resources.P10_Register;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 700);
            this.Controls.Add(this.FlPnlOptions);
            this.Controls.Add(this.BtnSign_up);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.PtbOptions);
            this.Controls.Add(this.PtbIcon);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DlgLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PtbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptions)).EndInit();
            this.FlPnlOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptionsIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbIcon;
        private System.Windows.Forms.PictureBox PtbOptions;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnSign_up;
        private System.Windows.Forms.FlowLayoutPanel FlPnlOptions;
        private System.Windows.Forms.PictureBox PtbClose;
        private System.Windows.Forms.PictureBox PtbOptionsIn;
        private System.Windows.Forms.ToolTip TltDescription;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.PictureBox PtbReturn;
    }
}