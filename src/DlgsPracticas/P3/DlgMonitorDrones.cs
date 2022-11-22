using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using POO22B_FPA.src.Class;
using POO22B_FPA;

namespace POO22B_FPA.src.DlgsMenu
{
    //---------------------------------------------------------------------
    //Clase que representa el diálogo de la práctica 3.
    //FPA. 25/09/2022.
    //---------------------------------------------------------------------
    public partial class DlgMonitorDrones : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private List<CMeta> Metas;
        private Thread Proceso;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgMonitorDrones(List<CMeta> Metas)
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            this.Metas = Metas;
            P3BtnRefrescar_Click(null, null);
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
            this.Dispose();
        }

        //╔═══════════════════╗
        //║ Maximizar ventana ║
        //╚═══════════════════╝
        private void BtnMaximizedPracticas_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                P3FlPnlBotones.Padding = new Padding(this.Width / 3, 0, 0, 0);
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Propiedades();
            }
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
            Propiedades();
        }

        //╔══════════════════════════════════╗
        //║ Método contenedor de propiedades ║
        //╚══════════════════════════════════╝
        private void Propiedades()
        {
            Properties.Settings.Default.Reset();
            BackColor = Properties.Settings.Default.BackColor;
            P3FlPnlBotones.BackColor = Properties.Settings.Default.SubMenusBackColor;
            P3FlPnlBotones.Padding = new Padding(this.Width / 5, 0, 0, 0);
            P3BtnAutomatico.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P3BtnAutomatico.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3BtnPausar.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P3BtnPausar.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3BtnRefrescar.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P3BtnRefrescar.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3BtnLimpiarDgv.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P3BtnLimpiarDgv.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3LblTotalMeta.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3DgvMetasInfo.BackgroundColor = Properties.Settings.Default.SubMenusBackColor;
            P3DgvMetasInfo.DefaultCellStyle.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P3DgvMetasInfo.DefaultCellStyle.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3DgvMetasInfo.ColumnHeadersDefaultCellStyle.BackColor = Properties.Settings.Default.SubMenusBackColor;
            P3DgvMetasInfo.ColumnHeadersDefaultCellStyle.ForeColor = Properties.Settings.Default.LettersForeColor;
        }

        //╔═══════════════════════════════════════════════╗
        //║ Evento que termina con el hilo de ejecución.  ║
        //╚═══════════════════════════════════════════════╝
        private void DlgPractica3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Reset();
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
        private void P3BtnRefrescar_Click(object sender, EventArgs e)
        {
            P3DgvMetasInfo.Rows.Clear();

            for (int i = 0; i < Metas.Count; i++)
            {
                P3DgvMetasInfo.Rows.Add();

                P3DgvMetasInfo.Rows[i].Cells[0].Value = Metas[i].ID;
                P3DgvMetasInfo.Rows[i].Cells[1].Value = Metas[i].Name;
                P3DgvMetasInfo.Rows[i].Cells[1].Style.BackColor = Metas[i].BackColor;
                P3DgvMetasInfo.Rows[i].Cells[2].Value = Metas[i].Location.X;
                P3DgvMetasInfo.Rows[i].Cells[3].Value = Metas[i].Location.Y;
                P3DgvMetasInfo.Rows[i].Cells[4].Value = Metas[i].Apagando;

                int Contador = P3DgvMetasInfo.RowCount - 1;
                P3LblTotalMeta.Text = "En este momento hay " + Contador + " drones activos.";
                P3LblTotalMeta.ForeColor = Properties.Settings.Default.LettersForeColor;
            }
        }

        //---------------------------------------------------------------------
        //Botón para obtener los datos de los Metas.
        //---------------------------------------------------------------------
        private void P3DgvMetasInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Metas[e.RowIndex].Detener((bool)P3DgvMetasInfo.CurrentCell.Value);
            }
            catch (Exception) { }
        }

        //---------------------------------------------------------------------
        //Botón para obtener los datos de los Metas automáticamente.
        //---------------------------------------------------------------------
        private void P3BtnAutomatico_Click(object sender, EventArgs e)
        {
            Proceso = new Thread(() =>
            {
                while (true)
                {
                    P3BtnRefrescar_Click(null, null);
                    Thread.Sleep(500);
                }
            });
            Proceso.Start();
        }

        //---------------------------------------------------------------------
        //Botón para pausar los datos de los Metas.
        //---------------------------------------------------------------------
        private void P3BtnPausar_Click(object sender, EventArgs e)
        {
            Proceso.Abort();
        }
    }
}
