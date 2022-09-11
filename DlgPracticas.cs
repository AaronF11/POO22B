using POO22B_FPA.src.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
        private List<Thread> Procesos;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgPracticas()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Procesos = new List<Thread>();
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
            foreach (Thread Proceso in Procesos)
            {
                Proceso.Abort();
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
        //Pruebas de diagonales en sesión C8.
        //---------------------------------------------------------------------
        private void P2BtnPD_Click(object sender, EventArgs e)
        {
            CMeta Meta;
            Thread ProcesoEjecucion;
            Random r = new Random();
            int R = r.Next(0, 256);
            int G = r.Next(0, 256);
            int B = r.Next(0, 256);

            Meta = new CMeta(r.Next(1, 3));
            Meta.BackColor = Color.FromArgb(R, G, B);
            Meta.BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\icons8_twitter_32px.png");
            Meta.BackgroundImageLayout = ImageLayout.Stretch;
            Meta.Location = new Point(10,10);
            Meta.Name = "P2PtxMeta";
            Meta.Size = new Size(32,32);
            P2PnlContenedor.Controls.Add(Meta);
            Meta.BringToFront();

            ProcesoEjecucion = new Thread(() =>
            {
                bool Norte = false;
                bool Sur = true;
                bool Este = true;
                bool Oeste = false;

                int X;
                int Y;

                X = Meta.Location.X;
                Y = Meta.Location.Y;

                while (true)
                {
                    if (Norte)
                    {
                        Y = Y - 1;
                    }

                    if (Sur)
                    {
                        Y = Y + 1;
                    }

                    if (Este)
                    {
                        X = X + 1;
                    }

                    if (Oeste)
                    {
                        X = X - 1;
                    }

                    if (Y <= 0)
                    {
                        Norte = false;
                        Sur = true;
                        Meta.BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Sur.png");
                    }

                    if (X <= 0)
                    {
                        Oeste = false;
                        Este = true;
                        Meta.BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Este.png");
                    }

                    if (X >= P2PnlContenedor.Width - 32)
                    {
                        Oeste = true;
                        Este = false;
                        Meta.BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Oeste.png");
                    }

                    if (Y >= P2PnlContenedor.Height - 32)
                    {
                        Norte = true;
                        Sur = false;
                        Meta.BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Norte.png");
                    }

                    Thread.Sleep(Meta.Velocidad);
                    Meta.Location = new Point(X,Y);
                }
            });

            ProcesoEjecucion.Start();
            Procesos.Add(ProcesoEjecucion);
            //MessageBox.Show("Proceso iniciado.");
        }
        #endregion
    }
}
