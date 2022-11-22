namespace POO22B_FPA.src.DlgsPracticas.P10
{
    partial class DlgMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgMain));
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.PnlSelection = new System.Windows.Forms.Panel();
            this.CCPtbProfile = new Mensajeria.Customs.CustomCircularPictureBox();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnTI = new System.Windows.Forms.Button();
            this.BtnBuilds = new System.Windows.Forms.Button();
            this.BtnStudents = new System.Windows.Forms.Button();
            this.BtnTeachers = new System.Windows.Forms.Button();
            this.BtnEmployers = new System.Windows.Forms.Button();
            this.PtbIcon = new System.Windows.Forms.PictureBox();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnCLosePracticas = new System.Windows.Forms.Button();
            this.BtnMaximizedPracticas = new System.Windows.Forms.Button();
            this.BtnMinimizedPracticas = new System.Windows.Forms.Button();
            this.PtbOptions = new System.Windows.Forms.PictureBox();
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.PnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCPtbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbIcon)).BeginInit();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.PnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLeft.Controls.Add(this.PnlSelection);
            this.PnlLeft.Controls.Add(this.CCPtbProfile);
            this.PnlLeft.Controls.Add(this.LblMail);
            this.PnlLeft.Controls.Add(this.LblName);
            this.PnlLeft.Controls.Add(this.BtnTI);
            this.PnlLeft.Controls.Add(this.BtnBuilds);
            this.PnlLeft.Controls.Add(this.BtnStudents);
            this.PnlLeft.Controls.Add(this.BtnTeachers);
            this.PnlLeft.Controls.Add(this.BtnEmployers);
            this.PnlLeft.Controls.Add(this.PtbIcon);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(250, 611);
            this.PnlLeft.TabIndex = 0;
            this.PnlLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DlgMain_MouseDown);
            // 
            // PnlSelection
            // 
            this.PnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.PnlSelection.Location = new System.Drawing.Point(0, 176);
            this.PnlSelection.Name = "PnlSelection";
            this.PnlSelection.Size = new System.Drawing.Size(5, 200);
            this.PnlSelection.TabIndex = 0;
            // 
            // CCPtbProfile
            // 
            this.CCPtbProfile.BackgroundImage = global::POO22B_FPA.Properties.Resources.Profile;
            this.CCPtbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CCPtbProfile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.CCPtbProfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.CCPtbProfile.BorderColor2 = System.Drawing.Color.AliceBlue;
            this.CCPtbProfile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.CCPtbProfile.BorderSize = 2;
            this.CCPtbProfile.GradientAngle = 50F;
            this.CCPtbProfile.Location = new System.Drawing.Point(72, 11);
            this.CCPtbProfile.Name = "CCPtbProfile";
            this.CCPtbProfile.Size = new System.Drawing.Size(97, 97);
            this.CCPtbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CCPtbProfile.TabIndex = 13;
            this.CCPtbProfile.TabStop = false;
            this.CCPtbProfile.Click += new System.EventHandler(this.PtbIcon_Click);
            // 
            // LblMail
            // 
            this.LblMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblMail.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMail.ForeColor = System.Drawing.Color.White;
            this.LblMail.Location = new System.Drawing.Point(0, 143);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(248, 20);
            this.LblMail.TabIndex = 12;
            this.LblMail.Text = "Correo";
            this.LblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.LblName.Location = new System.Drawing.Point(0, 119);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(248, 24);
            this.LblName.TabIndex = 11;
            this.LblName.Text = "Nombre";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTI
            // 
            this.BtnTI.BackColor = System.Drawing.Color.Transparent;
            this.BtnTI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTI.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnTI.FlatAppearance.BorderSize = 0;
            this.BtnTI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.BtnTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTI.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.BtnTI.Image = global::POO22B_FPA.Properties.Resources.P10_TI;
            this.BtnTI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTI.Location = new System.Drawing.Point(3, 336);
            this.BtnTI.Name = "BtnTI";
            this.BtnTI.Size = new System.Drawing.Size(245, 40);
            this.BtnTI.TabIndex = 9;
            this.BtnTI.Text = "Equipos TI";
            this.BtnTI.UseVisualStyleBackColor = false;
            this.BtnTI.Click += new System.EventHandler(this.BtnTI_Click);
            this.BtnTI.Leave += new System.EventHandler(this.BtnTI_Leave);
            // 
            // BtnBuilds
            // 
            this.BtnBuilds.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuilds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuilds.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnBuilds.FlatAppearance.BorderSize = 0;
            this.BtnBuilds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.BtnBuilds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuilds.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuilds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.BtnBuilds.Image = global::POO22B_FPA.Properties.Resources.P10_Edificios;
            this.BtnBuilds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuilds.Location = new System.Drawing.Point(3, 296);
            this.BtnBuilds.Name = "BtnBuilds";
            this.BtnBuilds.Size = new System.Drawing.Size(245, 40);
            this.BtnBuilds.TabIndex = 8;
            this.BtnBuilds.Text = "Edificios";
            this.BtnBuilds.UseVisualStyleBackColor = false;
            this.BtnBuilds.Click += new System.EventHandler(this.BtnBuilds_Click);
            this.BtnBuilds.Leave += new System.EventHandler(this.BtnBuilds_Leave);
            // 
            // BtnStudents
            // 
            this.BtnStudents.BackColor = System.Drawing.Color.Transparent;
            this.BtnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudents.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnStudents.FlatAppearance.BorderSize = 0;
            this.BtnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.BtnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudents.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.BtnStudents.Image = ((System.Drawing.Image)(resources.GetObject("BtnStudents.Image")));
            this.BtnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStudents.Location = new System.Drawing.Point(3, 256);
            this.BtnStudents.Name = "BtnStudents";
            this.BtnStudents.Size = new System.Drawing.Size(245, 40);
            this.BtnStudents.TabIndex = 7;
            this.BtnStudents.Text = "Alumnos";
            this.BtnStudents.UseVisualStyleBackColor = false;
            this.BtnStudents.Click += new System.EventHandler(this.BtnStudents_Click);
            this.BtnStudents.Leave += new System.EventHandler(this.BtnStudents_Leave);
            // 
            // BtnTeachers
            // 
            this.BtnTeachers.BackColor = System.Drawing.Color.Transparent;
            this.BtnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTeachers.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnTeachers.FlatAppearance.BorderSize = 0;
            this.BtnTeachers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.BtnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeachers.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.BtnTeachers.Image = ((System.Drawing.Image)(resources.GetObject("BtnTeachers.Image")));
            this.BtnTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTeachers.Location = new System.Drawing.Point(3, 216);
            this.BtnTeachers.Name = "BtnTeachers";
            this.BtnTeachers.Size = new System.Drawing.Size(245, 40);
            this.BtnTeachers.TabIndex = 6;
            this.BtnTeachers.Text = "Maestros";
            this.BtnTeachers.UseVisualStyleBackColor = false;
            this.BtnTeachers.Click += new System.EventHandler(this.BtnTeachers_Click);
            this.BtnTeachers.Leave += new System.EventHandler(this.BtnTeachers_Leave);
            // 
            // BtnEmployers
            // 
            this.BtnEmployers.BackColor = System.Drawing.Color.Transparent;
            this.BtnEmployers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmployers.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnEmployers.FlatAppearance.BorderSize = 0;
            this.BtnEmployers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.BtnEmployers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployers.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.BtnEmployers.Image = global::POO22B_FPA.Properties.Resources.P10_Docentes;
            this.BtnEmployers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployers.Location = new System.Drawing.Point(3, 176);
            this.BtnEmployers.Name = "BtnEmployers";
            this.BtnEmployers.Size = new System.Drawing.Size(245, 40);
            this.BtnEmployers.TabIndex = 5;
            this.BtnEmployers.Text = "Docentes";
            this.BtnEmployers.UseVisualStyleBackColor = false;
            this.BtnEmployers.Click += new System.EventHandler(this.BtnEmployers_Click);
            this.BtnEmployers.Leave += new System.EventHandler(this.BtnEmployers_Leave);
            // 
            // PtbIcon
            // 
            this.PtbIcon.BackColor = System.Drawing.Color.Transparent;
            this.PtbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.PtbIcon.Image = global::POO22B_FPA.Properties.Resources.Logo;
            this.PtbIcon.Location = new System.Drawing.Point(0, 0);
            this.PtbIcon.Name = "PtbIcon";
            this.PtbIcon.Size = new System.Drawing.Size(248, 119);
            this.PtbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PtbIcon.TabIndex = 4;
            this.PtbIcon.TabStop = false;
            this.PtbIcon.Click += new System.EventHandler(this.PtbIcon_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.PnlTop.Controls.Add(this.BtnCLosePracticas);
            this.PnlTop.Controls.Add(this.BtnMaximizedPracticas);
            this.PnlTop.Controls.Add(this.BtnMinimizedPracticas);
            this.PnlTop.Controls.Add(this.PtbOptions);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(250, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1034, 40);
            this.PnlTop.TabIndex = 1;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DlgMain_MouseDown);
            // 
            // BtnCLosePracticas
            // 
            this.BtnCLosePracticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCLosePracticas.FlatAppearance.BorderSize = 0;
            this.BtnCLosePracticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCLosePracticas.Image = global::POO22B_FPA.Properties.Resources.Rojo;
            this.BtnCLosePracticas.Location = new System.Drawing.Point(1009, 6);
            this.BtnCLosePracticas.Name = "BtnCLosePracticas";
            this.BtnCLosePracticas.Size = new System.Drawing.Size(18, 18);
            this.BtnCLosePracticas.TabIndex = 4;
            this.BtnCLosePracticas.UseVisualStyleBackColor = true;
            this.BtnCLosePracticas.Click += new System.EventHandler(this.BtnCLosePracticas_Click);
            // 
            // BtnMaximizedPracticas
            // 
            this.BtnMaximizedPracticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizedPracticas.FlatAppearance.BorderSize = 0;
            this.BtnMaximizedPracticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizedPracticas.Image = global::POO22B_FPA.Properties.Resources.Amarillo;
            this.BtnMaximizedPracticas.Location = new System.Drawing.Point(985, 6);
            this.BtnMaximizedPracticas.Name = "BtnMaximizedPracticas";
            this.BtnMaximizedPracticas.Size = new System.Drawing.Size(18, 18);
            this.BtnMaximizedPracticas.TabIndex = 5;
            this.BtnMaximizedPracticas.UseVisualStyleBackColor = true;
            this.BtnMaximizedPracticas.Click += new System.EventHandler(this.BtnMaximizedPracticas_Click);
            // 
            // BtnMinimizedPracticas
            // 
            this.BtnMinimizedPracticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizedPracticas.FlatAppearance.BorderSize = 0;
            this.BtnMinimizedPracticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizedPracticas.Image = global::POO22B_FPA.Properties.Resources.Verde;
            this.BtnMinimizedPracticas.Location = new System.Drawing.Point(961, 6);
            this.BtnMinimizedPracticas.Name = "BtnMinimizedPracticas";
            this.BtnMinimizedPracticas.Size = new System.Drawing.Size(18, 18);
            this.BtnMinimizedPracticas.TabIndex = 6;
            this.BtnMinimizedPracticas.UseVisualStyleBackColor = true;
            this.BtnMinimizedPracticas.Click += new System.EventHandler(this.BtnMinimizedPracticas_Click);
            // 
            // PtbOptions
            // 
            this.PtbOptions.BackColor = System.Drawing.Color.Transparent;
            this.PtbOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PtbOptions.Image = global::POO22B_FPA.Properties.Resources.P10_Menu2;
            this.PtbOptions.Location = new System.Drawing.Point(3, 3);
            this.PtbOptions.Name = "PtbOptions";
            this.PtbOptions.Size = new System.Drawing.Size(32, 32);
            this.PtbOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PtbOptions.TabIndex = 2;
            this.PtbOptions.TabStop = false;
            this.PtbOptions.Click += new System.EventHandler(this.PtbOptions_Click);
            // 
            // PnlContainer
            // 
            this.PnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.PnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContainer.Location = new System.Drawing.Point(250, 40);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(1034, 571);
            this.PnlContainer.TabIndex = 2;
            this.PnlContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DlgMain_MouseDown);
            // 
            // DlgMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.ControlBox = false;
            this.Controls.Add(this.PnlContainer);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.PnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DlgMain_MouseDown);
            this.PnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CCPtbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbIcon)).EndInit();
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.PictureBox PtbOptions;
        private System.Windows.Forms.PictureBox PtbIcon;
        private System.Windows.Forms.Button BtnCLosePracticas;
        private System.Windows.Forms.Button BtnMaximizedPracticas;
        private System.Windows.Forms.Button BtnMinimizedPracticas;
        private System.Windows.Forms.Button BtnEmployers;
        private System.Windows.Forms.Button BtnTI;
        private System.Windows.Forms.Button BtnBuilds;
        private System.Windows.Forms.Button BtnStudents;
        private System.Windows.Forms.Button BtnTeachers;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblName;
        private Mensajeria.Customs.CustomCircularPictureBox CCPtbProfile;
        private System.Windows.Forms.Panel PnlSelection;
    }
}