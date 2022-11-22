namespace POO22B_FPA.src.DlgsPracticas.P5
{
    partial class DlgFiguras
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
            this.CdBordes = new System.Windows.Forms.ColorDialog();
            this.CdRelleno = new System.Windows.Forms.ColorDialog();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnColores = new System.Windows.Forms.Button();
            this.BtnLapiz = new System.Windows.Forms.Button();
            this.BtnBorrador = new System.Windows.Forms.Button();
            this.FlpnlArriba = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRellenar = new System.Windows.Forms.Button();
            this.BtnElipse = new System.Windows.Forms.Button();
            this.BtnCuadrilatero = new System.Windows.Forms.Button();
            this.BtnLinea = new System.Windows.Forms.Button();
            this.BtnColorSeleccionado = new System.Windows.Forms.Button();
            this.PtbPaletaColores = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.PtbContenedor = new System.Windows.Forms.PictureBox();
            this.FlpnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPaletaColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbContenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackgroundImage = global::POO22B_FPA.Properties.Resources.P5_Limpiar;
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(910, 15);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(48, 48);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnColores
            // 
            this.BtnColores.BackgroundImage = global::POO22B_FPA.Properties.Resources.P5_Colores;
            this.BtnColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnColores.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnColores.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColores.Location = new System.Drawing.Point(339, 15);
            this.BtnColores.Name = "BtnColores";
            this.BtnColores.Size = new System.Drawing.Size(48, 48);
            this.BtnColores.TabIndex = 5;
            this.BtnColores.UseVisualStyleBackColor = true;
            this.BtnColores.Click += new System.EventHandler(this.BtnColores_Click);
            // 
            // BtnLapiz
            // 
            this.BtnLapiz.BackgroundImage = global::POO22B_FPA.Properties.Resources.P5_Pincel;
            this.BtnLapiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLapiz.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnLapiz.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnLapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLapiz.Location = new System.Drawing.Point(15, 15);
            this.BtnLapiz.Name = "BtnLapiz";
            this.BtnLapiz.Size = new System.Drawing.Size(48, 48);
            this.BtnLapiz.TabIndex = 3;
            this.BtnLapiz.UseVisualStyleBackColor = true;
            this.BtnLapiz.Click += new System.EventHandler(this.BtnLapiz_Click);
            // 
            // BtnBorrador
            // 
            this.BtnBorrador.BackgroundImage = global::POO22B_FPA.Properties.Resources.P5_Borrador;
            this.BtnBorrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBorrador.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnBorrador.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnBorrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrador.Location = new System.Drawing.Point(69, 15);
            this.BtnBorrador.Name = "BtnBorrador";
            this.BtnBorrador.Size = new System.Drawing.Size(48, 48);
            this.BtnBorrador.TabIndex = 1;
            this.BtnBorrador.UseVisualStyleBackColor = true;
            this.BtnBorrador.Click += new System.EventHandler(this.BtnBorrador_Click);
            // 
            // FlpnlArriba
            // 
            this.FlpnlArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.FlpnlArriba.Controls.Add(this.BtnLapiz);
            this.FlpnlArriba.Controls.Add(this.BtnBorrador);
            this.FlpnlArriba.Controls.Add(this.BtnRellenar);
            this.FlpnlArriba.Controls.Add(this.BtnElipse);
            this.FlpnlArriba.Controls.Add(this.BtnCuadrilatero);
            this.FlpnlArriba.Controls.Add(this.BtnLinea);
            this.FlpnlArriba.Controls.Add(this.BtnColores);
            this.FlpnlArriba.Controls.Add(this.BtnColorSeleccionado);
            this.FlpnlArriba.Controls.Add(this.PtbPaletaColores);
            this.FlpnlArriba.Controls.Add(this.BtnGuardar);
            this.FlpnlArriba.Controls.Add(this.BtnLimpiar);
            this.FlpnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlpnlArriba.Location = new System.Drawing.Point(0, 0);
            this.FlpnlArriba.Name = "FlpnlArriba";
            this.FlpnlArriba.Padding = new System.Windows.Forms.Padding(12, 12, 0, 0);
            this.FlpnlArriba.Size = new System.Drawing.Size(964, 160);
            this.FlpnlArriba.TabIndex = 0;
            // 
            // BtnRellenar
            // 
            this.BtnRellenar.BackgroundImage = global::POO22B_FPA.Properties.Resources.P5_Rellenar;
            this.BtnRellenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRellenar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnRellenar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnRellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRellenar.Location = new System.Drawing.Point(123, 15);
            this.BtnRellenar.Name = "BtnRellenar";
            this.BtnRellenar.Size = new System.Drawing.Size(48, 48);
            this.BtnRellenar.TabIndex = 8;
            this.BtnRellenar.UseVisualStyleBackColor = true;
            this.BtnRellenar.Click += new System.EventHandler(this.BtnRellenar_Click);
            // 
            // BtnElipse
            // 
            this.BtnElipse.BackgroundImage = global::POO22B_FPA.Properties.Resources.P5_Circulo;
            this.BtnElipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnElipse.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnElipse.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnElipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElipse.Location = new System.Drawing.Point(177, 15);
            this.BtnElipse.Name = "BtnElipse";
            this.BtnElipse.Size = new System.Drawing.Size(48, 48);
            this.BtnElipse.TabIndex = 9;
            this.BtnElipse.UseVisualStyleBackColor = true;
            this.BtnElipse.Click += new System.EventHandler(this.BtnElipse_Click);
            // 
            // BtnCuadrilatero
            // 
            this.BtnCuadrilatero.BackgroundImage = global::POO22B_FPA.Properties.Resources.P5_Rectangulo;
            this.BtnCuadrilatero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCuadrilatero.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnCuadrilatero.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCuadrilatero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuadrilatero.Location = new System.Drawing.Point(231, 15);
            this.BtnCuadrilatero.Name = "BtnCuadrilatero";
            this.BtnCuadrilatero.Size = new System.Drawing.Size(48, 48);
            this.BtnCuadrilatero.TabIndex = 10;
            this.BtnCuadrilatero.UseVisualStyleBackColor = true;
            this.BtnCuadrilatero.Click += new System.EventHandler(this.BtnCuadrilatero_Click);
            // 
            // BtnLinea
            // 
            this.BtnLinea.BackgroundImage = global::POO22B_FPA.Properties.Resources.P5_Linea;
            this.BtnLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLinea.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnLinea.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLinea.Location = new System.Drawing.Point(285, 15);
            this.BtnLinea.Name = "BtnLinea";
            this.BtnLinea.Size = new System.Drawing.Size(48, 48);
            this.BtnLinea.TabIndex = 11;
            this.BtnLinea.UseVisualStyleBackColor = true;
            this.BtnLinea.Click += new System.EventHandler(this.BtnLinea_Click);
            // 
            // BtnColorSeleccionado
            // 
            this.BtnColorSeleccionado.BackColor = System.Drawing.Color.White;
            this.BtnColorSeleccionado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnColorSeleccionado.Cursor = System.Windows.Forms.Cursors.No;
            this.BtnColorSeleccionado.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnColorSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColorSeleccionado.Location = new System.Drawing.Point(393, 15);
            this.BtnColorSeleccionado.Name = "BtnColorSeleccionado";
            this.BtnColorSeleccionado.Size = new System.Drawing.Size(32, 32);
            this.BtnColorSeleccionado.TabIndex = 13;
            this.BtnColorSeleccionado.UseVisualStyleBackColor = false;
            // 
            // PtbPaletaColores
            // 
            this.PtbPaletaColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PtbPaletaColores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PtbPaletaColores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbPaletaColores.Image = global::POO22B_FPA.Properties.Resources.color_palette;
            this.PtbPaletaColores.Location = new System.Drawing.Point(431, 15);
            this.PtbPaletaColores.Name = "PtbPaletaColores";
            this.PtbPaletaColores.Size = new System.Drawing.Size(419, 133);
            this.PtbPaletaColores.TabIndex = 12;
            this.PtbPaletaColores.TabStop = false;
            this.PtbPaletaColores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PtbPaletaColores_MouseClick);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackgroundImage = global::POO22B_FPA.Properties.Resources.P5_Guardar;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(856, 15);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(48, 48);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PtbContenedor
            // 
            this.PtbContenedor.BackColor = System.Drawing.Color.White;
            this.PtbContenedor.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PtbContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbContenedor.Location = new System.Drawing.Point(0, 160);
            this.PtbContenedor.Name = "PtbContenedor";
            this.PtbContenedor.Size = new System.Drawing.Size(964, 501);
            this.PtbContenedor.TabIndex = 1;
            this.PtbContenedor.TabStop = false;
            this.PtbContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PtbContenedor_Paint);
            this.PtbContenedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PtbContenedor_MouseClick);
            this.PtbContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PtbContenedor_MouseDown);
            this.PtbContenedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PtbContenedor_MouseMove);
            this.PtbContenedor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PtbContenedor_MouseUp);
            // 
            // DlgFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.PtbContenedor);
            this.Controls.Add(this.FlpnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DlgFiguras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figuras";
            this.FlpnlArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbPaletaColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbContenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog CdBordes;
        private System.Windows.Forms.ColorDialog CdRelleno;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnColores;
        private System.Windows.Forms.Button BtnLapiz;
        private System.Windows.Forms.Button BtnBorrador;
        private System.Windows.Forms.FlowLayoutPanel FlpnlArriba;
        private System.Windows.Forms.Button BtnRellenar;
        private System.Windows.Forms.Button BtnElipse;
        private System.Windows.Forms.Button BtnCuadrilatero;
        private System.Windows.Forms.Button BtnLinea;
        private System.Windows.Forms.PictureBox PtbPaletaColores;
        private System.Windows.Forms.Button BtnColorSeleccionado;
        private System.Windows.Forms.PictureBox PtbContenedor;
        private System.Windows.Forms.Button BtnGuardar;
    }
}