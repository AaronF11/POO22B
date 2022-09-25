namespace POO22B_FPA.src.DlgsMenu
{
    partial class DlgPractica3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FlpTopButtonsPractica3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCLosePractica3 = new System.Windows.Forms.Button();
            this.BtnMaximizedPractica3 = new System.Windows.Forms.Button();
            this.BtnMinimizedPractica3 = new System.Windows.Forms.Button();
            this.P3PnlBotones = new System.Windows.Forms.Panel();
            this.P3BtnLimpiarDgv = new System.Windows.Forms.Button();
            this.P3BtnObtenerMetas = new System.Windows.Forms.Button();
            this.P3DgvMetasInfo = new System.Windows.Forms.DataGridView();
            this.P3DgvColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3DgvColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3DgvColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3DgvColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3DgvColumnDetener = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FlpTopButtonsPractica3.SuspendLayout();
            this.P3PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P3DgvMetasInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // FlpTopButtonsPractica3
            // 
            this.FlpTopButtonsPractica3.Controls.Add(this.BtnCLosePractica3);
            this.FlpTopButtonsPractica3.Controls.Add(this.BtnMaximizedPractica3);
            this.FlpTopButtonsPractica3.Controls.Add(this.BtnMinimizedPractica3);
            this.FlpTopButtonsPractica3.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlpTopButtonsPractica3.Location = new System.Drawing.Point(0, 0);
            this.FlpTopButtonsPractica3.Name = "FlpTopButtonsPractica3";
            this.FlpTopButtonsPractica3.Size = new System.Drawing.Size(584, 29);
            this.FlpTopButtonsPractica3.TabIndex = 6;
            this.FlpTopButtonsPractica3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlpTopButtonsPracticas_MouseDown);
            // 
            // BtnCLosePractica3
            // 
            this.BtnCLosePractica3.FlatAppearance.BorderSize = 0;
            this.BtnCLosePractica3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCLosePractica3.Image = global::POO22B_FPA.Properties.Resources.icons8_sphere_18px;
            this.BtnCLosePractica3.Location = new System.Drawing.Point(3, 3);
            this.BtnCLosePractica3.Name = "BtnCLosePractica3";
            this.BtnCLosePractica3.Size = new System.Drawing.Size(18, 18);
            this.BtnCLosePractica3.TabIndex = 1;
            this.BtnCLosePractica3.UseVisualStyleBackColor = true;
            this.BtnCLosePractica3.Click += new System.EventHandler(this.BtnCLosePracticas_Click);
            // 
            // BtnMaximizedPractica3
            // 
            this.BtnMaximizedPractica3.FlatAppearance.BorderSize = 0;
            this.BtnMaximizedPractica3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizedPractica3.Image = global::POO22B_FPA.Properties.Resources.icons8_sphere_18px_1;
            this.BtnMaximizedPractica3.Location = new System.Drawing.Point(27, 3);
            this.BtnMaximizedPractica3.Name = "BtnMaximizedPractica3";
            this.BtnMaximizedPractica3.Size = new System.Drawing.Size(18, 18);
            this.BtnMaximizedPractica3.TabIndex = 2;
            this.BtnMaximizedPractica3.UseVisualStyleBackColor = true;
            this.BtnMaximizedPractica3.Click += new System.EventHandler(this.BtnMaximizedPracticas_Click);
            // 
            // BtnMinimizedPractica3
            // 
            this.BtnMinimizedPractica3.FlatAppearance.BorderSize = 0;
            this.BtnMinimizedPractica3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizedPractica3.Image = global::POO22B_FPA.Properties.Resources.icons8_sphere_18px_2;
            this.BtnMinimizedPractica3.Location = new System.Drawing.Point(51, 3);
            this.BtnMinimizedPractica3.Name = "BtnMinimizedPractica3";
            this.BtnMinimizedPractica3.Size = new System.Drawing.Size(18, 18);
            this.BtnMinimizedPractica3.TabIndex = 3;
            this.BtnMinimizedPractica3.UseVisualStyleBackColor = true;
            this.BtnMinimizedPractica3.Click += new System.EventHandler(this.BtnMinimizedPracticas_Click);
            // 
            // P3PnlBotones
            // 
            this.P3PnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P3PnlBotones.Controls.Add(this.P3BtnLimpiarDgv);
            this.P3PnlBotones.Controls.Add(this.P3BtnObtenerMetas);
            this.P3PnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.P3PnlBotones.Location = new System.Drawing.Point(0, 29);
            this.P3PnlBotones.Name = "P3PnlBotones";
            this.P3PnlBotones.Size = new System.Drawing.Size(584, 65);
            this.P3PnlBotones.TabIndex = 7;
            // 
            // P3BtnLimpiarDgv
            // 
            this.P3BtnLimpiarDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.P3BtnLimpiarDgv.Location = new System.Drawing.Point(0, 30);
            this.P3BtnLimpiarDgv.Name = "P3BtnLimpiarDgv";
            this.P3BtnLimpiarDgv.Size = new System.Drawing.Size(580, 30);
            this.P3BtnLimpiarDgv.TabIndex = 1;
            this.P3BtnLimpiarDgv.Text = "Limpiar";
            this.P3BtnLimpiarDgv.UseVisualStyleBackColor = true;
            this.P3BtnLimpiarDgv.Click += new System.EventHandler(this.P3BtnLimpiarDgv_Click);
            // 
            // P3BtnObtenerMetas
            // 
            this.P3BtnObtenerMetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.P3BtnObtenerMetas.Location = new System.Drawing.Point(0, 0);
            this.P3BtnObtenerMetas.Name = "P3BtnObtenerMetas";
            this.P3BtnObtenerMetas.Size = new System.Drawing.Size(580, 30);
            this.P3BtnObtenerMetas.TabIndex = 0;
            this.P3BtnObtenerMetas.Text = "Obtener datos de Metas";
            this.P3BtnObtenerMetas.UseVisualStyleBackColor = true;
            this.P3BtnObtenerMetas.Click += new System.EventHandler(this.P3BtnObtenerMetas_Click);
            // 
            // P3DgvMetasInfo
            // 
            this.P3DgvMetasInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.P3DgvMetasInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P3DgvMetasInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.P3DgvMetasInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.P3DgvMetasInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P3DgvMetasInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P3DgvColumnNumero,
            this.P3DgvColumnX,
            this.P3DgvColumnY,
            this.P3DgvColumnColor,
            this.P3DgvColumnDetener});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.P3DgvMetasInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.P3DgvMetasInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P3DgvMetasInfo.Location = new System.Drawing.Point(0, 94);
            this.P3DgvMetasInfo.Name = "P3DgvMetasInfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.P3DgvMetasInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.P3DgvMetasInfo.Size = new System.Drawing.Size(584, 367);
            this.P3DgvMetasInfo.TabIndex = 8;
            this.P3DgvMetasInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.P3DgvMetasInfo_CellContentClick);
            // 
            // P3DgvColumnNumero
            // 
            this.P3DgvColumnNumero.HeaderText = "Número";
            this.P3DgvColumnNumero.Name = "P3DgvColumnNumero";
            // 
            // P3DgvColumnX
            // 
            this.P3DgvColumnX.HeaderText = "Posición en X";
            this.P3DgvColumnX.Name = "P3DgvColumnX";
            // 
            // P3DgvColumnY
            // 
            this.P3DgvColumnY.HeaderText = "Posición en Y";
            this.P3DgvColumnY.Name = "P3DgvColumnY";
            // 
            // P3DgvColumnColor
            // 
            this.P3DgvColumnColor.HeaderText = "Color";
            this.P3DgvColumnColor.Name = "P3DgvColumnColor";
            this.P3DgvColumnColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // P3DgvColumnDetener
            // 
            this.P3DgvColumnDetener.HeaderText = "Detener";
            this.P3DgvColumnDetener.Name = "P3DgvColumnDetener";
            // 
            // DlgPractica3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.ControlBox = false;
            this.Controls.Add(this.P3DgvMetasInfo);
            this.Controls.Add(this.P3PnlBotones);
            this.Controls.Add(this.FlpTopButtonsPractica3);
            this.Name = "DlgPractica3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Práctica 3";
            this.Load += new System.EventHandler(this.DlgPractica3_Load);
            this.FlpTopButtonsPractica3.ResumeLayout(false);
            this.P3PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.P3DgvMetasInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpTopButtonsPractica3;
        private System.Windows.Forms.Button BtnCLosePractica3;
        private System.Windows.Forms.Button BtnMaximizedPractica3;
        private System.Windows.Forms.Button BtnMinimizedPractica3;
        private System.Windows.Forms.Panel P3PnlBotones;
        private System.Windows.Forms.Button P3BtnLimpiarDgv;
        private System.Windows.Forms.Button P3BtnObtenerMetas;
        private System.Windows.Forms.DataGridView P3DgvMetasInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3DgvColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3DgvColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3DgvColumnY;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3DgvColumnColor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn P3DgvColumnDetener;
    }
}