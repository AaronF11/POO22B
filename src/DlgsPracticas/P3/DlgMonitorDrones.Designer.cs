namespace POO22B_FPA.src.DlgsMenu
{
    partial class DlgMonitorDrones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgMonitorDrones));
            this.FlpTopButtonsPractica3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnCLosePractica3 = new System.Windows.Forms.Button();
            this.BtnMaximizedPractica3 = new System.Windows.Forms.Button();
            this.BtnMinimizedPractica3 = new System.Windows.Forms.Button();
            this.P3LblTotalMeta = new System.Windows.Forms.Label();
            this.P3BtnLimpiarDgv = new System.Windows.Forms.Button();
            this.P3BtnRefrescar = new System.Windows.Forms.Button();
            this.P3BtnPausar = new System.Windows.Forms.Button();
            this.P3BtnAutomatico = new System.Windows.Forms.Button();
            this.P3DgvMetasInfo = new System.Windows.Forms.DataGridView();
            this.P3DgvColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3DgvColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3DgvColX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3DgvColY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3DgvColRegresar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.P3FlPnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpTopButtonsPractica3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P3DgvMetasInfo)).BeginInit();
            this.P3FlPnlBotones.SuspendLayout();
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
            this.BtnCLosePractica3.Image = global::POO22B_FPA.Properties.Resources.Rojo;
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
            this.BtnMaximizedPractica3.Image = global::POO22B_FPA.Properties.Resources.Amarillo;
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
            this.BtnMinimizedPractica3.Image = global::POO22B_FPA.Properties.Resources.Verde;
            this.BtnMinimizedPractica3.Location = new System.Drawing.Point(51, 3);
            this.BtnMinimizedPractica3.Name = "BtnMinimizedPractica3";
            this.BtnMinimizedPractica3.Size = new System.Drawing.Size(18, 18);
            this.BtnMinimizedPractica3.TabIndex = 3;
            this.BtnMinimizedPractica3.UseVisualStyleBackColor = true;
            this.BtnMinimizedPractica3.Click += new System.EventHandler(this.BtnMinimizedPracticas_Click);
            // 
            // P3LblTotalMeta
            // 
            this.P3LblTotalMeta.Dock = System.Windows.Forms.DockStyle.Top;
            this.P3LblTotalMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.P3LblTotalMeta.Location = new System.Drawing.Point(0, 76);
            this.P3LblTotalMeta.Name = "P3LblTotalMeta";
            this.P3LblTotalMeta.Size = new System.Drawing.Size(584, 32);
            this.P3LblTotalMeta.TabIndex = 2;
            this.P3LblTotalMeta.Text = "En este momento hay 0 drones activos.";
            this.P3LblTotalMeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P3BtnLimpiarDgv
            // 
            this.P3BtnLimpiarDgv.FlatAppearance.BorderSize = 0;
            this.P3BtnLimpiarDgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P3BtnLimpiarDgv.Image = global::POO22B_FPA.Properties.Resources.P2_Limpiar;
            this.P3BtnLimpiarDgv.Location = new System.Drawing.Point(261, 3);
            this.P3BtnLimpiarDgv.Name = "P3BtnLimpiarDgv";
            this.P3BtnLimpiarDgv.Size = new System.Drawing.Size(80, 32);
            this.P3BtnLimpiarDgv.TabIndex = 1;
            this.P3BtnLimpiarDgv.UseVisualStyleBackColor = true;
            this.P3BtnLimpiarDgv.Click += new System.EventHandler(this.P3BtnLimpiarDgv_Click);
            // 
            // P3BtnRefrescar
            // 
            this.P3BtnRefrescar.FlatAppearance.BorderSize = 0;
            this.P3BtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P3BtnRefrescar.Image = global::POO22B_FPA.Properties.Resources.P3_Actualizar;
            this.P3BtnRefrescar.Location = new System.Drawing.Point(175, 3);
            this.P3BtnRefrescar.Name = "P3BtnRefrescar";
            this.P3BtnRefrescar.Size = new System.Drawing.Size(80, 32);
            this.P3BtnRefrescar.TabIndex = 0;
            this.P3BtnRefrescar.UseVisualStyleBackColor = true;
            this.P3BtnRefrescar.Click += new System.EventHandler(this.P3BtnRefrescar_Click);
            // 
            // P3BtnPausar
            // 
            this.P3BtnPausar.FlatAppearance.BorderSize = 0;
            this.P3BtnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P3BtnPausar.Image = global::POO22B_FPA.Properties.Resources.P3_Pausar;
            this.P3BtnPausar.Location = new System.Drawing.Point(89, 3);
            this.P3BtnPausar.Name = "P3BtnPausar";
            this.P3BtnPausar.Size = new System.Drawing.Size(80, 32);
            this.P3BtnPausar.TabIndex = 4;
            this.P3BtnPausar.UseVisualStyleBackColor = true;
            this.P3BtnPausar.Click += new System.EventHandler(this.P3BtnPausar_Click);
            // 
            // P3BtnAutomatico
            // 
            this.P3BtnAutomatico.FlatAppearance.BorderSize = 0;
            this.P3BtnAutomatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P3BtnAutomatico.Image = global::POO22B_FPA.Properties.Resources.P3_Automático;
            this.P3BtnAutomatico.Location = new System.Drawing.Point(3, 3);
            this.P3BtnAutomatico.Name = "P3BtnAutomatico";
            this.P3BtnAutomatico.Size = new System.Drawing.Size(80, 32);
            this.P3BtnAutomatico.TabIndex = 3;
            this.P3BtnAutomatico.UseVisualStyleBackColor = true;
            this.P3BtnAutomatico.Click += new System.EventHandler(this.P3BtnAutomatico_Click);
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
            this.P3DgvColID,
            this.P3DgvColNombre,
            this.P3DgvColX,
            this.P3DgvColY,
            this.P3DgvColRegresar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.P3DgvMetasInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.P3DgvMetasInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P3DgvMetasInfo.Location = new System.Drawing.Point(0, 108);
            this.P3DgvMetasInfo.Name = "P3DgvMetasInfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.P3DgvMetasInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.P3DgvMetasInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.P3DgvMetasInfo.Size = new System.Drawing.Size(584, 347);
            this.P3DgvMetasInfo.TabIndex = 8;
            this.P3DgvMetasInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.P3DgvMetasInfo_CellContentClick);
            // 
            // P3DgvColID
            // 
            this.P3DgvColID.HeaderText = "ID";
            this.P3DgvColID.Name = "P3DgvColID";
            this.P3DgvColID.ReadOnly = true;
            this.P3DgvColID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // P3DgvColNombre
            // 
            this.P3DgvColNombre.HeaderText = "Nombre";
            this.P3DgvColNombre.Name = "P3DgvColNombre";
            this.P3DgvColNombre.ReadOnly = true;
            // 
            // P3DgvColX
            // 
            this.P3DgvColX.HeaderText = "Posición en X";
            this.P3DgvColX.Name = "P3DgvColX";
            this.P3DgvColX.ReadOnly = true;
            // 
            // P3DgvColY
            // 
            this.P3DgvColY.HeaderText = "Posición en Y";
            this.P3DgvColY.Name = "P3DgvColY";
            this.P3DgvColY.ReadOnly = true;
            // 
            // P3DgvColRegresar
            // 
            this.P3DgvColRegresar.HeaderText = "Detener";
            this.P3DgvColRegresar.Name = "P3DgvColRegresar";
            // 
            // P3FlPnlBotones
            // 
            this.P3FlPnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P3FlPnlBotones.Controls.Add(this.P3BtnAutomatico);
            this.P3FlPnlBotones.Controls.Add(this.P3BtnPausar);
            this.P3FlPnlBotones.Controls.Add(this.P3BtnRefrescar);
            this.P3FlPnlBotones.Controls.Add(this.P3BtnLimpiarDgv);
            this.P3FlPnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.P3FlPnlBotones.Location = new System.Drawing.Point(0, 29);
            this.P3FlPnlBotones.Name = "P3FlPnlBotones";
            this.P3FlPnlBotones.Size = new System.Drawing.Size(584, 47);
            this.P3FlPnlBotones.TabIndex = 5;
            // 
            // DlgMonitorDrones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 455);
            this.ControlBox = false;
            this.Controls.Add(this.P3DgvMetasInfo);
            this.Controls.Add(this.P3LblTotalMeta);
            this.Controls.Add(this.P3FlPnlBotones);
            this.Controls.Add(this.FlpTopButtonsPractica3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgMonitorDrones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor de Drones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DlgPractica3_FormClosing);
            this.Load += new System.EventHandler(this.DlgPractica3_Load);
            this.FlpTopButtonsPractica3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.P3DgvMetasInfo)).EndInit();
            this.P3FlPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpTopButtonsPractica3;
        private System.Windows.Forms.Button BtnCLosePractica3;
        private System.Windows.Forms.Button BtnMaximizedPractica3;
        private System.Windows.Forms.Button BtnMinimizedPractica3;
        private System.Windows.Forms.Button P3BtnLimpiarDgv;
        private System.Windows.Forms.Button P3BtnRefrescar;
        private System.Windows.Forms.DataGridView P3DgvMetasInfo;
        public System.Windows.Forms.Label P3LblTotalMeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3DgvColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3DgvColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3DgvColX;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3DgvColY;
        private System.Windows.Forms.DataGridViewCheckBoxColumn P3DgvColRegresar;
        private System.Windows.Forms.Button P3BtnAutomatico;
        private System.Windows.Forms.Button P3BtnPausar;
        private System.Windows.Forms.FlowLayoutPanel P3FlPnlBotones;
    }
}