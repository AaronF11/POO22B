using POO22B_FPA.src.Class;
using POO22B_FPA.src.DlgsMenu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace POO22B_FPA
{
    //---------------------------------------------------------------------
    //Clase que representa el diálogo principal.
    //FPA. 25/08/2022.
    //---------------------------------------------------------------------
    public partial class DlgPracticas : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public List<CMeta> Metas;
        public static DlgPracticas Instancia;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgPracticas()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Metas = new List<CMeta>();

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
            DlgPrincipal dlgPrincipal = new DlgPrincipal();
            dlgPrincipal.Show();
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

        //╔═══════════════════╗
        //║ Cierra los hilos  ║
        //╚═══════════════════╝
        private void DlgPracticas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Reset();
            foreach (CMeta Proceso in Metas)
            {
                Proceso.Termina();
            }
        }

        //╔═══════════════════════════╗
        //║ Carga inicial de ventana  ║
        //╚═══════════════════════════╝
        private void DlgPracticas_Load(object sender, EventArgs e)
        {
            //Ventana
            this.BackColor = Properties.Settings.Default.BackColor;
            //Tap Control
            TpTest.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp1.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp2.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp3.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp4.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp5.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp6.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp7.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp8.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp9.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Tp10.BackColor = Properties.Settings.Default.SubMenusBackColor;
            //Tap Test
            BtnPrueba.BackColor = Properties.Settings.Default.ButtonsBackColor;
            BtnPrueba.ForeColor = Properties.Settings.Default.LettersForeColor;
            BtnPersonas.BackColor = Properties.Settings.Default.ButtonsBackColor;
            BtnPersonas.ForeColor = Properties.Settings.Default.LettersForeColor;
            //Tap 1

            //Tap 2
            P2PnlContenedorBotones.BackColor = Properties.Settings.Default.SubMenusBackColor;
            P2BtnPD.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P2BtnPD.ForeColor = Properties.Settings.Default.LettersForeColor;
            P2BtnPX.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P2BtnPX.ForeColor = Properties.Settings.Default.LettersForeColor;
            P2BtnPY.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P2BtnPY.ForeColor = Properties.Settings.Default.LettersForeColor;

            //Tap 3
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

            //Tap 4

            //Tap 5

            //Tap 6

            //Tap 7

            //Tap 8

            //Tap 9

            //Tap 10
        }
        #endregion

        #region Botones de prueba
        //---------------------------------------------------------------------
        //Al dar clic en el botón de pruebas.
        //---------------------------------------------------------------------
        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            CPelota MiPelota1;
            CPelota MiPelota2;

            MiPelota1 = new CPelota(25, 1, "Policloruro de Vinilo", "China");
            MiPelota2 = new CPelota(25, 1, "Policloruro de Vinilo", "China");

            MessageBox.Show(MiPelota1.Inflar(5).GetMessage());
            MessageBox.Show(MiPelota2.Inflar(7).GetMessage());

            //Thread HiloPrueba;

            //HiloPrueba = new Thread(() =>
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        CMeta Meta;

            //        Meta = new CMeta(10, 10, P2PnlContenedor)
            //        {
            //            BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Sur-Este.png"),
            //            BackgroundImageLayout = ImageLayout.Stretch
            //        };

            //        Meta.Enciende();
            //        Meta.Eleva(10);
            //        Meta.Desplazar(1);

            //        Drones.Add(Meta);
            //        Thread.Sleep(2000);
            //    }
            //});

            //HiloPrueba.Start();
        }

        //---------------------------------------------------------------------
        //Al dar clic en el botón de personas.
        //---------------------------------------------------------------------
        private void BtnPersonas_Click(object sender, EventArgs e)
        {
            CPersona Persona1;
            CPersona Persona2;
            CPersona Persona3;

            Persona1 = new CPersona(0, DateTime.Today, "Mexicana");
            Persona2 = new CCliente(1, DateTime.Today, "Colombia", "COL123");
            Persona3 = new CCliente(0, DateTime.Today, "Cubana", "COB456");

            Persona1.SetNombre("Maria");
            Persona2.SetNombre("José");
            Persona3.SetNombre("Consuelo");

            MessageBox.Show($"Persona 1: {Persona1.GetNombre()}, Persona 2: {Persona2.GetNombre()}, Persona 3: {Persona3.GetNombre()}");
        }
        #endregion

        #region Práctica 2

        //---------------------------------------------------------------------
        //Botón de dron en desplazamiento sobre eje X.
        //---------------------------------------------------------------------
        private void P2BtnPX_Click(object sender, EventArgs e)
        {
            CMeta Meta;

            Meta = new CMeta(0, 0, P2PnlContenedor)
            {
                BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Este.png"),
                BackgroundImageLayout = ImageLayout.Stretch
            };

            Meta.Enciende();
            Meta.Eleva(0);
            Meta.EjeX(1);

            Metas.Add(Meta);
        }

        //---------------------------------------------------------------------
        //Botón de dron en desplazamiento sobre eje X.
        //---------------------------------------------------------------------
        private void P2BtnPY_Click(object sender, EventArgs e)
        {
            CMeta Meta;

            Meta = new CMeta(0, 0, P2PnlContenedor)
            {
                BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Sur.png"),
                BackgroundImageLayout = ImageLayout.Stretch
            };

            Meta.Enciende();
            Meta.Eleva(0);
            Meta.EjeY(1);

            Metas.Add(Meta);
        }

        //---------------------------------------------------------------------
        //Pruebas de diagonales en sesión C8.
        //---------------------------------------------------------------------
        private void P2BtnPD_Click(object sender, EventArgs e)
        {
            CMeta Meta;

            Meta = new CMeta(10, 10, P2PnlContenedor)
            {
                BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Sur-Este.png"),
                BackgroundImageLayout = ImageLayout.Stretch
            };

            Meta.Enciende();
            Meta.Eleva(10);
            Meta.Desplazar(1);

            Metas.Add(Meta);
        }
        #endregion

        #region Práctica 3
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

            for (int i = 0; i < P2PnlContenedor.Controls.Count; i++)
            {
                P3DgvMetasInfo.Rows.Add();
                P3DgvMetasInfo.Rows[i].Cells[0].Value = Metas[i].Name + (" - "+ i);
                P3DgvMetasInfo.Rows[i].Cells[1].Value = Metas[i].Location.X;
                P3DgvMetasInfo.Rows[i].Cells[2].Value = Metas[i].Location.Y;
                P3DgvMetasInfo.Rows[i].Cells[3].Value = Metas[i].BackColor;
                P3DgvMetasInfo.Rows[i].Cells[3].Style.BackColor = Metas[i].BackColor;
                P3DgvMetasInfo.Rows[i].Cells[4].Value = Metas[i].Apagando;
            }
        }

        private void P3DgvMetasInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Metas[e.RowIndex].Detener((bool)P3DgvMetasInfo.CurrentCell.Value);
            }
            catch (Exception) { }
        }

        private void Tp2_Click(object sender, EventArgs e)
        {
            DlgPractica3 dlgPractica3 = new DlgPractica3();
            dlgPractica3.Show();
        }
        #endregion
    }
}
