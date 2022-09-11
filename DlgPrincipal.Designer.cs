namespace POO22B_FPA
{
    partial class DlgPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPrincipal));
            this.FlpTopButtonsMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCLoseMenu = new System.Windows.Forms.Button();
            this.BtnMaximizedMenu = new System.Windows.Forms.Button();
            this.BtnMinimizedMenu = new System.Windows.Forms.Button();
            this.PnlButtonsListMenu = new System.Windows.Forms.Panel();
            this.CCPtbProfileMenu = new Mensajeria.Customs.CustomCircularPictureBox();
            this.LblProfileMenu = new System.Windows.Forms.Label();
            this.BtnMoreInfoMenu = new System.Windows.Forms.Button();
            this.PnlHelpMenu = new System.Windows.Forms.Panel();
            this.BtnHelpAboutMenu = new System.Windows.Forms.Button();
            this.BtnHelpManualMenu = new System.Windows.Forms.Button();
            this.BtnHelpMenu = new System.Windows.Forms.Button();
            this.PnlToolsMenu = new System.Windows.Forms.Panel();
            this.BtnToolsModernMenu = new System.Windows.Forms.Button();
            this.BtnToolsDarkMenu = new System.Windows.Forms.Button();
            this.BtnToolsLightMenu = new System.Windows.Forms.Button();
            this.BtnToolsMenu = new System.Windows.Forms.Button();
            this.BtnPracticesMenu = new System.Windows.Forms.Button();
            this.PtbLogoMenu = new System.Windows.Forms.PictureBox();
            this.FlpTopButtonsMenu.SuspendLayout();
            this.PnlButtonsListMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCPtbProfileMenu)).BeginInit();
            this.PnlHelpMenu.SuspendLayout();
            this.PnlToolsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // FlpTopButtonsMenu
            // 
            this.FlpTopButtonsMenu.Controls.Add(this.BtnCLoseMenu);
            this.FlpTopButtonsMenu.Controls.Add(this.BtnMaximizedMenu);
            this.FlpTopButtonsMenu.Controls.Add(this.BtnMinimizedMenu);
            this.FlpTopButtonsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlpTopButtonsMenu.Location = new System.Drawing.Point(0, 0);
            this.FlpTopButtonsMenu.Name = "FlpTopButtonsMenu";
            this.FlpTopButtonsMenu.Size = new System.Drawing.Size(284, 29);
            this.FlpTopButtonsMenu.TabIndex = 4;
            this.FlpTopButtonsMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlpTopButtonsMenu_MouseDown);
            // 
            // BtnCLoseMenu
            // 
            this.BtnCLoseMenu.FlatAppearance.BorderSize = 0;
            this.BtnCLoseMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCLoseMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnCLoseMenu.Image")));
            this.BtnCLoseMenu.Location = new System.Drawing.Point(3, 3);
            this.BtnCLoseMenu.Name = "BtnCLoseMenu";
            this.BtnCLoseMenu.Size = new System.Drawing.Size(18, 18);
            this.BtnCLoseMenu.TabIndex = 1;
            this.BtnCLoseMenu.UseVisualStyleBackColor = true;
            this.BtnCLoseMenu.Click += new System.EventHandler(this.BtnCLoseMenu_Click);
            // 
            // BtnMaximizedMenu
            // 
            this.BtnMaximizedMenu.FlatAppearance.BorderSize = 0;
            this.BtnMaximizedMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizedMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizedMenu.Image")));
            this.BtnMaximizedMenu.Location = new System.Drawing.Point(27, 3);
            this.BtnMaximizedMenu.Name = "BtnMaximizedMenu";
            this.BtnMaximizedMenu.Size = new System.Drawing.Size(18, 18);
            this.BtnMaximizedMenu.TabIndex = 2;
            this.BtnMaximizedMenu.UseVisualStyleBackColor = true;
            // 
            // BtnMinimizedMenu
            // 
            this.BtnMinimizedMenu.FlatAppearance.BorderSize = 0;
            this.BtnMinimizedMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizedMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizedMenu.Image")));
            this.BtnMinimizedMenu.Location = new System.Drawing.Point(51, 3);
            this.BtnMinimizedMenu.Name = "BtnMinimizedMenu";
            this.BtnMinimizedMenu.Size = new System.Drawing.Size(18, 18);
            this.BtnMinimizedMenu.TabIndex = 3;
            this.BtnMinimizedMenu.UseVisualStyleBackColor = true;
            this.BtnMinimizedMenu.Click += new System.EventHandler(this.BtnMinimizedMenu_Click);
            // 
            // PnlButtonsListMenu
            // 
            this.PnlButtonsListMenu.Controls.Add(this.CCPtbProfileMenu);
            this.PnlButtonsListMenu.Controls.Add(this.LblProfileMenu);
            this.PnlButtonsListMenu.Controls.Add(this.BtnMoreInfoMenu);
            this.PnlButtonsListMenu.Controls.Add(this.PnlHelpMenu);
            this.PnlButtonsListMenu.Controls.Add(this.BtnHelpMenu);
            this.PnlButtonsListMenu.Controls.Add(this.PnlToolsMenu);
            this.PnlButtonsListMenu.Controls.Add(this.BtnToolsMenu);
            this.PnlButtonsListMenu.Controls.Add(this.BtnPracticesMenu);
            this.PnlButtonsListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlButtonsListMenu.Location = new System.Drawing.Point(0, 93);
            this.PnlButtonsListMenu.Name = "PnlButtonsListMenu";
            this.PnlButtonsListMenu.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.PnlButtonsListMenu.Size = new System.Drawing.Size(284, 468);
            this.PnlButtonsListMenu.TabIndex = 6;
            // 
            // CCPtbProfileMenu
            // 
            this.CCPtbProfileMenu.BackgroundImage = global::POO22B_FPA.Properties.Resources.Profile;
            this.CCPtbProfileMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CCPtbProfileMenu.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.CCPtbProfileMenu.BorderColor = System.Drawing.Color.RoyalBlue;
            this.CCPtbProfileMenu.BorderColor2 = System.Drawing.Color.RoyalBlue;
            this.CCPtbProfileMenu.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.CCPtbProfileMenu.BorderSize = 2;
            this.CCPtbProfileMenu.GradientAngle = 50F;
            this.CCPtbProfileMenu.Location = new System.Drawing.Point(10, 406);
            this.CCPtbProfileMenu.Name = "CCPtbProfileMenu";
            this.CCPtbProfileMenu.Size = new System.Drawing.Size(50, 50);
            this.CCPtbProfileMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CCPtbProfileMenu.TabIndex = 12;
            this.CCPtbProfileMenu.TabStop = false;
            // 
            // LblProfileMenu
            // 
            this.LblProfileMenu.AutoSize = true;
            this.LblProfileMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfileMenu.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblProfileMenu.Location = new System.Drawing.Point(64, 424);
            this.LblProfileMenu.Name = "LblProfileMenu";
            this.LblProfileMenu.Size = new System.Drawing.Size(148, 20);
            this.LblProfileMenu.TabIndex = 11;
            this.LblProfileMenu.Text = "Aarón Flores Pasos";
            // 
            // BtnMoreInfoMenu
            // 
            this.BtnMoreInfoMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMoreInfoMenu.BackgroundImage = global::POO22B_FPA.Properties.Resources.icons8_help_32px;
            this.BtnMoreInfoMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMoreInfoMenu.FlatAppearance.BorderSize = 0;
            this.BtnMoreInfoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoreInfoMenu.Location = new System.Drawing.Point(254, 436);
            this.BtnMoreInfoMenu.Name = "BtnMoreInfoMenu";
            this.BtnMoreInfoMenu.Size = new System.Drawing.Size(20, 20);
            this.BtnMoreInfoMenu.TabIndex = 9;
            this.BtnMoreInfoMenu.UseVisualStyleBackColor = true;
            this.BtnMoreInfoMenu.Click += new System.EventHandler(this.BtnMoreInfoMenu_Click);
            // 
            // PnlHelpMenu
            // 
            this.PnlHelpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.PnlHelpMenu.Controls.Add(this.BtnHelpAboutMenu);
            this.PnlHelpMenu.Controls.Add(this.BtnHelpManualMenu);
            this.PnlHelpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHelpMenu.Location = new System.Drawing.Point(10, 305);
            this.PnlHelpMenu.Name = "PnlHelpMenu";
            this.PnlHelpMenu.Padding = new System.Windows.Forms.Padding(50, 0, 25, 0);
            this.PnlHelpMenu.Size = new System.Drawing.Size(264, 90);
            this.PnlHelpMenu.TabIndex = 8;
            // 
            // BtnHelpAboutMenu
            // 
            this.BtnHelpAboutMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(40)))));
            this.BtnHelpAboutMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHelpAboutMenu.FlatAppearance.BorderSize = 0;
            this.BtnHelpAboutMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BtnHelpAboutMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnHelpAboutMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelpAboutMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelpAboutMenu.ForeColor = System.Drawing.Color.White;
            this.BtnHelpAboutMenu.Image = global::POO22B_FPA.Properties.Resources.icons8_document_32px;
            this.BtnHelpAboutMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHelpAboutMenu.Location = new System.Drawing.Point(50, 45);
            this.BtnHelpAboutMenu.Name = "BtnHelpAboutMenu";
            this.BtnHelpAboutMenu.Size = new System.Drawing.Size(189, 45);
            this.BtnHelpAboutMenu.TabIndex = 7;
            this.BtnHelpAboutMenu.Text = "Acerca de";
            this.BtnHelpAboutMenu.UseVisualStyleBackColor = false;
            this.BtnHelpAboutMenu.Click += new System.EventHandler(this.BtnHelpAboutMenu_Click);
            // 
            // BtnHelpManualMenu
            // 
            this.BtnHelpManualMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(40)))));
            this.BtnHelpManualMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHelpManualMenu.FlatAppearance.BorderSize = 0;
            this.BtnHelpManualMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BtnHelpManualMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnHelpManualMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelpManualMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelpManualMenu.ForeColor = System.Drawing.Color.White;
            this.BtnHelpManualMenu.Image = global::POO22B_FPA.Properties.Resources.icons8_user_manual_32px;
            this.BtnHelpManualMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHelpManualMenu.Location = new System.Drawing.Point(50, 0);
            this.BtnHelpManualMenu.Name = "BtnHelpManualMenu";
            this.BtnHelpManualMenu.Size = new System.Drawing.Size(189, 45);
            this.BtnHelpManualMenu.TabIndex = 6;
            this.BtnHelpManualMenu.Text = "Manual";
            this.BtnHelpManualMenu.UseVisualStyleBackColor = false;
            this.BtnHelpManualMenu.Click += new System.EventHandler(this.BtnHelpManualMenu_Click);
            // 
            // BtnHelpMenu
            // 
            this.BtnHelpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHelpMenu.FlatAppearance.BorderSize = 0;
            this.BtnHelpMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BtnHelpMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnHelpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelpMenu.ForeColor = System.Drawing.Color.White;
            this.BtnHelpMenu.Image = global::POO22B_FPA.Properties.Resources.icons8_info_32px;
            this.BtnHelpMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHelpMenu.Location = new System.Drawing.Point(10, 265);
            this.BtnHelpMenu.Name = "BtnHelpMenu";
            this.BtnHelpMenu.Size = new System.Drawing.Size(264, 40);
            this.BtnHelpMenu.TabIndex = 7;
            this.BtnHelpMenu.Text = "Ayuda";
            this.BtnHelpMenu.UseVisualStyleBackColor = true;
            this.BtnHelpMenu.Click += new System.EventHandler(this.BtnHelpMenu_Click);
            // 
            // PnlToolsMenu
            // 
            this.PnlToolsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.PnlToolsMenu.Controls.Add(this.BtnToolsModernMenu);
            this.PnlToolsMenu.Controls.Add(this.BtnToolsDarkMenu);
            this.PnlToolsMenu.Controls.Add(this.BtnToolsLightMenu);
            this.PnlToolsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlToolsMenu.Location = new System.Drawing.Point(10, 130);
            this.PnlToolsMenu.Name = "PnlToolsMenu";
            this.PnlToolsMenu.Padding = new System.Windows.Forms.Padding(50, 0, 25, 0);
            this.PnlToolsMenu.Size = new System.Drawing.Size(264, 135);
            this.PnlToolsMenu.TabIndex = 6;
            // 
            // BtnToolsModernMenu
            // 
            this.BtnToolsModernMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(40)))));
            this.BtnToolsModernMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnToolsModernMenu.FlatAppearance.BorderSize = 0;
            this.BtnToolsModernMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BtnToolsModernMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnToolsModernMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToolsModernMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToolsModernMenu.ForeColor = System.Drawing.Color.White;
            this.BtnToolsModernMenu.Image = global::POO22B_FPA.Properties.Resources.icons8_pie_chart_32px;
            this.BtnToolsModernMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnToolsModernMenu.Location = new System.Drawing.Point(50, 90);
            this.BtnToolsModernMenu.Name = "BtnToolsModernMenu";
            this.BtnToolsModernMenu.Size = new System.Drawing.Size(189, 45);
            this.BtnToolsModernMenu.TabIndex = 8;
            this.BtnToolsModernMenu.Text = "Moderno";
            this.BtnToolsModernMenu.UseVisualStyleBackColor = false;
            this.BtnToolsModernMenu.Click += new System.EventHandler(this.BtnToolsModernMenu_Click);
            // 
            // BtnToolsDarkMenu
            // 
            this.BtnToolsDarkMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(40)))));
            this.BtnToolsDarkMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnToolsDarkMenu.FlatAppearance.BorderSize = 0;
            this.BtnToolsDarkMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BtnToolsDarkMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnToolsDarkMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToolsDarkMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToolsDarkMenu.ForeColor = System.Drawing.Color.White;
            this.BtnToolsDarkMenu.Image = global::POO22B_FPA.Properties.Resources.icons8_light_off_32px;
            this.BtnToolsDarkMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnToolsDarkMenu.Location = new System.Drawing.Point(50, 45);
            this.BtnToolsDarkMenu.Name = "BtnToolsDarkMenu";
            this.BtnToolsDarkMenu.Size = new System.Drawing.Size(189, 45);
            this.BtnToolsDarkMenu.TabIndex = 7;
            this.BtnToolsDarkMenu.Text = "Oscuro";
            this.BtnToolsDarkMenu.UseVisualStyleBackColor = false;
            this.BtnToolsDarkMenu.Click += new System.EventHandler(this.BtnToolsDarkMenu_Click);
            // 
            // BtnToolsLightMenu
            // 
            this.BtnToolsLightMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(40)))));
            this.BtnToolsLightMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnToolsLightMenu.FlatAppearance.BorderSize = 0;
            this.BtnToolsLightMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BtnToolsLightMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnToolsLightMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToolsLightMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToolsLightMenu.ForeColor = System.Drawing.Color.White;
            this.BtnToolsLightMenu.Image = global::POO22B_FPA.Properties.Resources.icons8_light_on_32px;
            this.BtnToolsLightMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnToolsLightMenu.Location = new System.Drawing.Point(50, 0);
            this.BtnToolsLightMenu.Name = "BtnToolsLightMenu";
            this.BtnToolsLightMenu.Size = new System.Drawing.Size(189, 45);
            this.BtnToolsLightMenu.TabIndex = 6;
            this.BtnToolsLightMenu.Text = "Claro";
            this.BtnToolsLightMenu.UseVisualStyleBackColor = false;
            this.BtnToolsLightMenu.Click += new System.EventHandler(this.BtnToolsLightMenu_Click);
            // 
            // BtnToolsMenu
            // 
            this.BtnToolsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnToolsMenu.FlatAppearance.BorderSize = 0;
            this.BtnToolsMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BtnToolsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnToolsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToolsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToolsMenu.ForeColor = System.Drawing.Color.White;
            this.BtnToolsMenu.Image = global::POO22B_FPA.Properties.Resources.icons8_settings_32px;
            this.BtnToolsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnToolsMenu.Location = new System.Drawing.Point(10, 85);
            this.BtnToolsMenu.Name = "BtnToolsMenu";
            this.BtnToolsMenu.Size = new System.Drawing.Size(264, 45);
            this.BtnToolsMenu.TabIndex = 5;
            this.BtnToolsMenu.Text = "Configuración";
            this.BtnToolsMenu.UseVisualStyleBackColor = true;
            this.BtnToolsMenu.Click += new System.EventHandler(this.BtnToolsMenu_Click);
            // 
            // BtnPracticesMenu
            // 
            this.BtnPracticesMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPracticesMenu.FlatAppearance.BorderSize = 0;
            this.BtnPracticesMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BtnPracticesMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnPracticesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPracticesMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPracticesMenu.ForeColor = System.Drawing.Color.White;
            this.BtnPracticesMenu.Image = global::POO22B_FPA.Properties.Resources.icons8_opened_folder_32px;
            this.BtnPracticesMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPracticesMenu.Location = new System.Drawing.Point(10, 40);
            this.BtnPracticesMenu.Name = "BtnPracticesMenu";
            this.BtnPracticesMenu.Size = new System.Drawing.Size(264, 45);
            this.BtnPracticesMenu.TabIndex = 4;
            this.BtnPracticesMenu.Text = "Prácticas";
            this.BtnPracticesMenu.UseVisualStyleBackColor = true;
            this.BtnPracticesMenu.Click += new System.EventHandler(this.BtnPracticesMenu_Click);
            // 
            // PtbLogoMenu
            // 
            this.PtbLogoMenu.BackgroundImage = global::POO22B_FPA.Properties.Resources.icons8_forward_64px_1;
            this.PtbLogoMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PtbLogoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PtbLogoMenu.ImageLocation = "";
            this.PtbLogoMenu.Location = new System.Drawing.Point(0, 29);
            this.PtbLogoMenu.Name = "PtbLogoMenu";
            this.PtbLogoMenu.Size = new System.Drawing.Size(284, 64);
            this.PtbLogoMenu.TabIndex = 5;
            this.PtbLogoMenu.TabStop = false;
            // 
            // DlgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.ControlBox = false;
            this.Controls.Add(this.PnlButtonsListMenu);
            this.Controls.Add(this.PtbLogoMenu);
            this.Controls.Add(this.FlpTopButtonsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.FlpTopButtonsMenu.ResumeLayout(false);
            this.PnlButtonsListMenu.ResumeLayout(false);
            this.PnlButtonsListMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCPtbProfileMenu)).EndInit();
            this.PnlHelpMenu.ResumeLayout(false);
            this.PnlToolsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogoMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCLoseMenu;
        private System.Windows.Forms.Button BtnMinimizedMenu;
        private System.Windows.Forms.Button BtnMaximizedMenu;
        private System.Windows.Forms.FlowLayoutPanel FlpTopButtonsMenu;
        private System.Windows.Forms.PictureBox PtbLogoMenu;
        private System.Windows.Forms.Button BtnPracticesMenu;
        private System.Windows.Forms.Panel PnlButtonsListMenu;
        private System.Windows.Forms.Button BtnToolsMenu;
        private System.Windows.Forms.Panel PnlToolsMenu;
        private System.Windows.Forms.Button BtnToolsDarkMenu;
        private System.Windows.Forms.Button BtnToolsLightMenu;
        private System.Windows.Forms.Panel PnlHelpMenu;
        private System.Windows.Forms.Button BtnHelpAboutMenu;
        private System.Windows.Forms.Button BtnHelpManualMenu;
        private System.Windows.Forms.Button BtnHelpMenu;
        private System.Windows.Forms.Button BtnToolsModernMenu;
        private System.Windows.Forms.Button BtnMoreInfoMenu;
        private System.Windows.Forms.Label LblProfileMenu;
        private Mensajeria.Customs.CustomCircularPictureBox CCPtbProfileMenu;
    }
}

