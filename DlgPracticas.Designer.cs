namespace POO22B_FPA
{
    partial class DlgPracticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPracticas));
            this.BtnPrueba = new System.Windows.Forms.Button();
            this.FlpTopButtonsPracticas = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCLosePracticas = new System.Windows.Forms.Button();
            this.BtnMaximizedPracticas = new System.Windows.Forms.Button();
            this.BtnMinimizedPracticas = new System.Windows.Forms.Button();
            this.TcPracticas = new System.Windows.Forms.TabControl();
            this.TpTest = new System.Windows.Forms.TabPage();
            this.BtnPersonas = new System.Windows.Forms.Button();
            this.Tp1 = new System.Windows.Forms.TabPage();
            this.Tp2 = new System.Windows.Forms.TabPage();
            this.FlpTopButtonsPracticas.SuspendLayout();
            this.TcPracticas.SuspendLayout();
            this.TpTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPrueba
            // 
            this.BtnPrueba.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPrueba.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrueba.Location = new System.Drawing.Point(0, 0);
            this.BtnPrueba.Name = "BtnPrueba";
            this.BtnPrueba.Size = new System.Drawing.Size(792, 78);
            this.BtnPrueba.TabIndex = 1;
            this.BtnPrueba.Text = "Prueba";
            this.BtnPrueba.UseVisualStyleBackColor = true;
            this.BtnPrueba.Click += new System.EventHandler(this.BtnPrueba_Click);
            // 
            // FlpTopButtonsPracticas
            // 
            this.FlpTopButtonsPracticas.Controls.Add(this.BtnCLosePracticas);
            this.FlpTopButtonsPracticas.Controls.Add(this.BtnMaximizedPracticas);
            this.FlpTopButtonsPracticas.Controls.Add(this.BtnMinimizedPracticas);
            this.FlpTopButtonsPracticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlpTopButtonsPracticas.Location = new System.Drawing.Point(0, 0);
            this.FlpTopButtonsPracticas.Name = "FlpTopButtonsPracticas";
            this.FlpTopButtonsPracticas.Size = new System.Drawing.Size(800, 29);
            this.FlpTopButtonsPracticas.TabIndex = 5;
            this.FlpTopButtonsPracticas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlpTopButtonsPracticas_MouseDown);
            // 
            // BtnCLosePracticas
            // 
            this.BtnCLosePracticas.FlatAppearance.BorderSize = 0;
            this.BtnCLosePracticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCLosePracticas.Image = global::POO22B_FPA.Properties.Resources.icons8_sphere_18px;
            this.BtnCLosePracticas.Location = new System.Drawing.Point(3, 3);
            this.BtnCLosePracticas.Name = "BtnCLosePracticas";
            this.BtnCLosePracticas.Size = new System.Drawing.Size(18, 18);
            this.BtnCLosePracticas.TabIndex = 1;
            this.BtnCLosePracticas.UseVisualStyleBackColor = true;
            this.BtnCLosePracticas.Click += new System.EventHandler(this.BtnCLosePracticas_Click);
            // 
            // BtnMaximizedPracticas
            // 
            this.BtnMaximizedPracticas.FlatAppearance.BorderSize = 0;
            this.BtnMaximizedPracticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizedPracticas.Image = global::POO22B_FPA.Properties.Resources.icons8_sphere_18px_1;
            this.BtnMaximizedPracticas.Location = new System.Drawing.Point(27, 3);
            this.BtnMaximizedPracticas.Name = "BtnMaximizedPracticas";
            this.BtnMaximizedPracticas.Size = new System.Drawing.Size(18, 18);
            this.BtnMaximizedPracticas.TabIndex = 2;
            this.BtnMaximizedPracticas.UseVisualStyleBackColor = true;
            this.BtnMaximizedPracticas.Click += new System.EventHandler(this.BtnMaximizedPracticas_Click);
            // 
            // BtnMinimizedPracticas
            // 
            this.BtnMinimizedPracticas.FlatAppearance.BorderSize = 0;
            this.BtnMinimizedPracticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizedPracticas.Image = global::POO22B_FPA.Properties.Resources.icons8_sphere_18px_2;
            this.BtnMinimizedPracticas.Location = new System.Drawing.Point(51, 3);
            this.BtnMinimizedPracticas.Name = "BtnMinimizedPracticas";
            this.BtnMinimizedPracticas.Size = new System.Drawing.Size(18, 18);
            this.BtnMinimizedPracticas.TabIndex = 3;
            this.BtnMinimizedPracticas.UseVisualStyleBackColor = true;
            this.BtnMinimizedPracticas.Click += new System.EventHandler(this.BtnMinimizedPracticas_Click);
            // 
            // TcPracticas
            // 
            this.TcPracticas.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TcPracticas.Controls.Add(this.TpTest);
            this.TcPracticas.Controls.Add(this.Tp1);
            this.TcPracticas.Controls.Add(this.Tp2);
            this.TcPracticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TcPracticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcPracticas.Location = new System.Drawing.Point(0, 29);
            this.TcPracticas.Name = "TcPracticas";
            this.TcPracticas.SelectedIndex = 0;
            this.TcPracticas.Size = new System.Drawing.Size(800, 421);
            this.TcPracticas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TcPracticas.TabIndex = 6;
            // 
            // TpTest
            // 
            this.TpTest.Controls.Add(this.BtnPersonas);
            this.TpTest.Controls.Add(this.BtnPrueba);
            this.TpTest.Location = new System.Drawing.Point(4, 25);
            this.TpTest.Name = "TpTest";
            this.TpTest.Size = new System.Drawing.Size(792, 392);
            this.TpTest.TabIndex = 2;
            this.TpTest.Text = "Ejemplo";
            this.TpTest.UseVisualStyleBackColor = true;
            // 
            // BtnPersonas
            // 
            this.BtnPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonas.Location = new System.Drawing.Point(0, 78);
            this.BtnPersonas.Name = "BtnPersonas";
            this.BtnPersonas.Size = new System.Drawing.Size(792, 78);
            this.BtnPersonas.TabIndex = 2;
            this.BtnPersonas.Text = "Personas";
            this.BtnPersonas.UseVisualStyleBackColor = true;
            this.BtnPersonas.Click += new System.EventHandler(this.BtnPersonas_Click);
            // 
            // Tp1
            // 
            this.Tp1.Location = new System.Drawing.Point(4, 25);
            this.Tp1.Name = "Tp1";
            this.Tp1.Padding = new System.Windows.Forms.Padding(3);
            this.Tp1.Size = new System.Drawing.Size(792, 392);
            this.Tp1.TabIndex = 0;
            this.Tp1.Text = "Práctica 1";
            this.Tp1.UseVisualStyleBackColor = true;
            // 
            // Tp2
            // 
            this.Tp2.Location = new System.Drawing.Point(4, 25);
            this.Tp2.Name = "Tp2";
            this.Tp2.Padding = new System.Windows.Forms.Padding(3);
            this.Tp2.Size = new System.Drawing.Size(792, 392);
            this.Tp2.TabIndex = 1;
            this.Tp2.Text = "Práctica 2";
            this.Tp2.UseVisualStyleBackColor = true;
            // 
            // DlgPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TcPracticas);
            this.Controls.Add(this.FlpTopButtonsPracticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgPracticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prácticas";
            this.FlpTopButtonsPracticas.ResumeLayout(false);
            this.TcPracticas.ResumeLayout(false);
            this.TpTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrueba;
        private System.Windows.Forms.FlowLayoutPanel FlpTopButtonsPracticas;
        private System.Windows.Forms.Button BtnCLosePracticas;
        private System.Windows.Forms.Button BtnMaximizedPracticas;
        private System.Windows.Forms.Button BtnMinimizedPracticas;
        private System.Windows.Forms.TabControl TcPracticas;
        private System.Windows.Forms.TabPage TpTest;
        private System.Windows.Forms.TabPage Tp1;
        private System.Windows.Forms.TabPage Tp2;
        private System.Windows.Forms.Button BtnPersonas;
    }
}