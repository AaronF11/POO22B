namespace POO22B_FPA.src.DlgsPracticas.P10
{
    partial class DlgDocente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.LblLastname = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlLeft.SuspendLayout();
            this.PnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.Controls.Add(this.BtnSave);
            this.PnlLeft.Controls.Add(this.BtnUpdate);
            this.PnlLeft.Controls.Add(this.BtnDelete);
            this.PnlLeft.Controls.Add(this.TxtAge);
            this.PnlLeft.Controls.Add(this.LblAge);
            this.PnlLeft.Controls.Add(this.TxtLastname);
            this.PnlLeft.Controls.Add(this.LblLastname);
            this.PnlLeft.Controls.Add(this.TxtName);
            this.PnlLeft.Controls.Add(this.LblName);
            this.PnlLeft.Controls.Add(this.TxtId);
            this.PnlLeft.Controls.Add(this.LblId);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Padding = new System.Windows.Forms.Padding(15);
            this.PnlLeft.Size = new System.Drawing.Size(200, 571);
            this.PnlLeft.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(15, 436);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(170, 40);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(15, 476);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(170, 40);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(15, 516);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(170, 40);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtAge
            // 
            this.TxtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAge.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtAge.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.ForeColor = System.Drawing.Color.White;
            this.TxtAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtAge.Location = new System.Drawing.Point(15, 235);
            this.TxtAge.Multiline = true;
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(170, 40);
            this.TxtAge.TabIndex = 13;
            this.TxtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblAge
            // 
            this.LblAge.BackColor = System.Drawing.Color.Transparent;
            this.LblAge.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblAge.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAge.ForeColor = System.Drawing.Color.White;
            this.LblAge.Location = new System.Drawing.Point(15, 210);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(170, 25);
            this.LblAge.TabIndex = 12;
            this.LblAge.Text = "Edad:";
            // 
            // TxtLastname
            // 
            this.TxtLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.TxtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLastname.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtLastname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastname.ForeColor = System.Drawing.Color.White;
            this.TxtLastname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtLastname.Location = new System.Drawing.Point(15, 170);
            this.TxtLastname.Multiline = true;
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(170, 40);
            this.TxtLastname.TabIndex = 11;
            this.TxtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblLastname
            // 
            this.LblLastname.BackColor = System.Drawing.Color.Transparent;
            this.LblLastname.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblLastname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastname.ForeColor = System.Drawing.Color.White;
            this.LblLastname.Location = new System.Drawing.Point(15, 145);
            this.LblLastname.Name = "LblLastname";
            this.LblLastname.Size = new System.Drawing.Size(170, 25);
            this.LblLastname.TabIndex = 10;
            this.LblLastname.Text = "Apellido";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.White;
            this.TxtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtName.Location = new System.Drawing.Point(15, 105);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(170, 40);
            this.TxtName.TabIndex = 9;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(15, 80);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(170, 25);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Nombre:";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtId.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.ForeColor = System.Drawing.Color.White;
            this.TxtId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtId.Location = new System.Drawing.Point(15, 40);
            this.TxtId.Multiline = true;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(170, 40);
            this.TxtId.TabIndex = 7;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblId
            // 
            this.LblId.BackColor = System.Drawing.Color.Transparent;
            this.LblId.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(15, 15);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(170, 25);
            this.LblId.TabIndex = 6;
            this.LblId.Text = "ID:";
            // 
            // PnlContainer
            // 
            this.PnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlContainer.Controls.Add(this.Dgv);
            this.PnlContainer.Location = new System.Drawing.Point(200, 0);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Padding = new System.Windows.Forms.Padding(15);
            this.PnlContainer.Size = new System.Drawing.Size(834, 571);
            this.PnlContainer.TabIndex = 1;
            // 
            // Dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv.ColumnHeadersHeight = 40;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColLastname,
            this.ColAge});
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.EnableHeadersVisualStyles = false;
            this.Dgv.GridColor = System.Drawing.Color.White;
            this.Dgv.Location = new System.Drawing.Point(15, 15);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(804, 541);
            this.Dgv.TabIndex = 0;
            this.Dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            this.Dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Nombre";
            this.ColName.Name = "ColName";
            // 
            // ColLastname
            // 
            this.ColLastname.HeaderText = "Apellido";
            this.ColLastname.Name = "ColLastname";
            // 
            // ColAge
            // 
            this.ColAge.HeaderText = "Edad";
            this.ColAge.Name = "ColAge";
            // 
            // DlgDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1034, 571);
            this.Controls.Add(this.PnlContainer);
            this.Controls.Add(this.PnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgDocente";
            this.Text = "DlgDocente";
            this.PnlLeft.ResumeLayout(false);
            this.PnlLeft.PerformLayout();
            this.PnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.Label LblLastname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAge;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}