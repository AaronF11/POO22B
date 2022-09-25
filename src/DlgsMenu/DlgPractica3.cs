using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO22B_FPA.src.Class;

namespace POO22B_FPA.src.DlgsMenu
{
    //---------------------------------------------------------------------
    //Clase que representa el diálogo de la práctica 3.
    //FPA. 25/09/2022.
    //---------------------------------------------------------------------
    public partial class DlgPractica3 : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public static DlgPractica3 Instancia;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgPractica3()
        {
            InitializeComponent();

            Instancia = this;
        }

        #region Eventos de tamaño de la ventana
        //╔═════════════════════════════════╗
        //║ Mover la posición de la ventana ║
        //╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void FlpTopButtonsPracticas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //╔════════════════╗
        //║ Cerrar ventana ║
        //╚════════════════╝
        private void BtnCLosePracticas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //╔═══════════════════╗
        //║ Maximizar ventana ║
        //╚═══════════════════╝
        private void BtnMaximizedPracticas_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;

        }

        //╔═══════════════════╗
        //║ Minimizar ventana ║
        //╚═══════════════════╝
        private void BtnMinimizedPracticas_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //╔═══════════════════════════╗
        //║ Carga inicial de ventana  ║
        //╚═══════════════════════════╝
        private void DlgPractica3_Load(object sender, EventArgs e)
        {
            BackColor = Properties.Settings.Default.BackColor;
            P3PnlBotones.BackColor = Properties.Settings.Default.SubMenusBackColor;
            P3BtnObtenerMetas.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P3BtnObtenerMetas.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3BtnLimpiarDgv.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P3BtnLimpiarDgv.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3DgvMetasInfo.BackgroundColor = Properties.Settings.Default.SubMenusBackColor;
            P3DgvMetasInfo.DefaultCellStyle.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P3DgvMetasInfo.DefaultCellStyle.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3DgvMetasInfo.ColumnHeadersDefaultCellStyle.BackColor = Properties.Settings.Default.SubMenusBackColor;
            P3DgvMetasInfo.ColumnHeadersDefaultCellStyle.ForeColor = Properties.Settings.Default.LettersForeColor;
        }
        #endregion

        //---------------------------------------------------------------------
        //Botón para limpiar la tabla de los metas.
        //---------------------------------------------------------------------
        private void P3BtnLimpiarDgv_Click(object sender, EventArgs e)
        {
            P3DgvMetasInfo.Rows.Clear();
        }

        //---------------------------------------------------------------------
        //Botón para obtener los datos de los Metas.
        //---------------------------------------------------------------------
        private void P3BtnObtenerMetas_Click(object sender, EventArgs e)
        {
            P3DgvMetasInfo.Rows.Clear();

            for (int i = 0; i < DlgPracticas.Instancia.P2PnlContenedor.Controls.Count; i++)
            {
                P3DgvMetasInfo.Rows.Add();
                P3DgvMetasInfo.Rows[i].Cells[0].Value = DlgPracticas.Instancia.Metas[i].Name + (" - " + i);
                P3DgvMetasInfo.Rows[i].Cells[1].Value = DlgPracticas.Instancia.Metas[i].Location.X;
                P3DgvMetasInfo.Rows[i].Cells[2].Value = DlgPracticas.Instancia.Metas[i].Location.Y;
                P3DgvMetasInfo.Rows[i].Cells[3].Value = DlgPracticas.Instancia.Metas[i].BackColor;
                P3DgvMetasInfo.Rows[i].Cells[3].Style.BackColor = DlgPracticas.Instancia.Metas[i].BackColor;
                P3DgvMetasInfo.Rows[i].Cells[4].Value = DlgPracticas.Instancia.Metas[i].Apagando;
            }
        }

        private void P3DgvMetasInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DlgPracticas.Instancia.Metas[e.RowIndex].Detener((bool)P3DgvMetasInfo.CurrentCell.Value);
            }
            catch (Exception) { }
        }
    }
}
