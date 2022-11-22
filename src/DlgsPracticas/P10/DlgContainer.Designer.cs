namespace POO22B_FPA.src.DlgsPracticas.P10
{
    partial class DlgContainer
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
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlContainer
            // 
            this.PnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.PnlContainer.Controls.Add(this.LblHora);
            this.PnlContainer.Controls.Add(this.LblFecha);
            this.PnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(1034, 571);
            this.PnlContainer.TabIndex = 0;
            // 
            // LblHora
            // 
            this.LblHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblHora.Font = new System.Drawing.Font("Nirmala UI", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblHora.Location = new System.Drawing.Point(0, 0);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(1034, 525);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "HORA";
            this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFecha
            // 
            this.LblFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblFecha.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblFecha.Location = new System.Drawing.Point(0, 525);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(1034, 46);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // DlgContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1034, 571);
            this.Controls.Add(this.PnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgContainer";
            this.Load += new System.EventHandler(this.DlgContainer_Load);
            this.PnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer Timer;
    }
}