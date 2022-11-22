using POO22B_FPA.src.Class;
using POO22B_FPA.src.Class.P4;
using POO22B_FPA.src.Class.P4.SubsCAnimal;
using POO22B_FPA.src.Class.P5;
using POO22B_FPA.src.DlgsMenu;
using POO22B_FPA.src.DlgsPracticas.P10;
using POO22B_FPA.src.DlgsPracticas.P5;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
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

        //Atributos de almacenamiento de objetos:
        protected List<CMeta> Metas;
        protected List<CSerVivo> SeresVivos;

        //Atributos para redondear los bordes:
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        //Atributos de las subclases de ser vivo:
        CPersona Persona;

        //Atributos de almacenamiento de URL's:
        List<string> URL;

        //Atributos de las clases de figuras:
        List<CFigura> Figuras;
        string Index;
        int Grosor;
        int Alto;
        int Largo;
        int Radio;
        int Perimetro;
        Color Borde;
        Color Relleno;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgPracticas()
        {
            InitializeComponent();

            //Prácticas 2, 3 y 4
            CheckForIllegalCrossThreadCalls = false;

            //Práctica 2 y 3
            Metas = new List<CMeta>();

            //Práctica 4
            SeresVivos = new List<CSerVivo>();
            P4FlPnlContenedorBotonesHorizontales.Visible = false;
            Reproductor.Dock = DockStyle.Fill;
            Reproductor.uiMode = "none";
            Reproductor.Visible = false;
            URL = new List<string>
            {
                @"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Chi chi chimo chi.mp4",
                @"C:\Users\aaron\source\repos\POO22B_FPA\Resources\September (Bdash x Miranda Derrick).mp4",
                @"C:\Users\aaron\source\repos\POO22B_FPA\Resources\xd.mp4",
                @"C:\Users\aaron\source\repos\POO22B_FPA\Resources\zilverk bailando xd.mp4"
            };

            //Práctica 5
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
            Application.Restart();
        }

        //╔═══════════════════╗
        //║ Maximizar ventana ║
        //╚═══════════════════╝
        private void BtnMaximizedPracticas_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            Propiedades();
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

            foreach (CSerVivo Proceso in SeresVivos)
            {
                Proceso.Dispose();
            }
        }

        //╔═══════════════════════════╗
        //║ Carga inicial de ventana  ║
        //╚═══════════════════════════╝
        private void DlgPracticas_Load(object sender, EventArgs e)
        {
            Propiedades();
        }

        //╔══════════════════════════════════╗
        //║ Método contenedor de propiedades ║
        //╚══════════════════════════════════╝
        private void Propiedades()
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
            P0LblPrueba.ForeColor = Properties.Settings.Default.LettersForeColor;
            P0BtnPrueba.ForeColor = Properties.Settings.Default.LettersForeColor;
            P0BtnPrueba.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P0BtnPrueba.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P0BtnPrueba.Width, P0BtnPrueba.Height, 25, 25));
            P0LblPersonas.ForeColor = Properties.Settings.Default.LettersForeColor;
            P0BtnPersonas.ForeColor = Properties.Settings.Default.LettersForeColor;
            P0BtnPersonas.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P0BtnPersonas.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P0BtnPersonas.Width, P0BtnPersonas.Height, 25, 25));
            P0FlPnlEjemplo.Padding = new Padding(this.Width / 3, this.Height / 3, 0, 0);

            //Tap 1


            //Tap 2
            P2FlPnlContenedorBotones.BackColor = Properties.Settings.Default.SubMenusBackColor;
            P2FlPnlContenedorBotones.Padding = new Padding(0, this.Height / 4, 0, 0);
            P2BtnPD.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P2BtnPD.ForeColor = Properties.Settings.Default.LettersForeColor;
            P2BtnPD.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P2BtnPD.Width, P2BtnPD.Height, 25, 25));
            P2BtnPX.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P2BtnPX.ForeColor = Properties.Settings.Default.LettersForeColor;
            P2BtnPX.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P2BtnPX.Width, P2BtnPX.Height, 25, 25));
            P2BtnPY.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P2BtnPY.ForeColor = Properties.Settings.Default.LettersForeColor;
            P2BtnPY.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P2BtnPY.Width, P2BtnPY.Height, 25, 25));
            P2BtnLimpiar.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P2BtnLimpiar.ForeColor = Properties.Settings.Default.LettersForeColor;
            P2BtnLimpiar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P2BtnLimpiar.Width, P2BtnLimpiar.Height, 25, 25));
            P2BtnMonitor.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P2BtnMonitor.ForeColor = Properties.Settings.Default.LettersForeColor;
            P2BtnMonitor.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P2BtnMonitor.Width, P2BtnMonitor.Height, 25, 25));


            //Tap 3
            P3BtnMonitor.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P3BtnMonitor.ForeColor = Properties.Settings.Default.LettersForeColor;
            P3BtnMonitor.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P3BtnMonitor.Width, P3BtnMonitor.Height, 25, 25));
            P3FlPnlContenedor.Padding = new Padding(Width / 3, Height / 3, 0, 0);


            //Tap 4
            P4PnlContenedor.BackColor = Properties.Settings.Default.SubMenusBackColor;
            P4FlPnlContenedorBotonesVerticales.BackColor = Properties.Settings.Default.SubMenusBackColor;
            P4FlPnlContenedorBotonesHorizontales.BackColor = Properties.Settings.Default.SubMenusBackColor;
            Reproductor.Dock = DockStyle.Fill;
            Reproductor.uiMode = "none";
            //1.-
            P4BtnSerVivo.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P4BtnSerVivo.ForeColor = Properties.Settings.Default.LettersForeColor;
            P4BtnSerVivo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P4BtnSerVivo.Width, P4BtnSerVivo.Height, 25, 25));
            //2.-
            P4BtnAbrirPanelHorizontal.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P4BtnAbrirPanelHorizontal.ForeColor = Properties.Settings.Default.LettersForeColor;
            P4BtnAbrirPanelHorizontal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P4BtnAbrirPanelHorizontal.Width, P4BtnAbrirPanelHorizontal.Height, 25, 25));
            //2.1.-
            P4BtnAnimal.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P4BtnAnimal.ForeColor = Properties.Settings.Default.LettersForeColor;
            P4BtnAnimal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P4BtnAnimal.Width, P4BtnAnimal.Height, 25, 25));
            //2.2.-
            P4BtnPlanta.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P4BtnPlanta.ForeColor = Properties.Settings.Default.LettersForeColor;
            P4BtnPlanta.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P4BtnPlanta.Width, P4BtnPlanta.Height, 25, 25));
            //2.3.-
            P4BtnHongo.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P4BtnHongo.ForeColor = Properties.Settings.Default.LettersForeColor;
            P4BtnHongo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P4BtnHongo.Width, P4BtnHongo.Height, 25, 25));
            //2.4.-
            P4BtnProtoctista.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P4BtnProtoctista.ForeColor = Properties.Settings.Default.LettersForeColor;
            P4BtnProtoctista.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P4BtnProtoctista.Width, P4BtnProtoctista.Height, 25, 25));
            //2.5.-
            P4BtnBacteria.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P4BtnBacteria.ForeColor = Properties.Settings.Default.LettersForeColor;
            P4BtnBacteria.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P4BtnBacteria.Width, P4BtnBacteria.Height, 25, 25));
            //3.0
            P4BtnPersona.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P4BtnPersona.ForeColor = Properties.Settings.Default.LettersForeColor;
            P4BtnPersona.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P4BtnPersona.Width, P4BtnPersona.Height, 25, 25));
            P4BtnLimpiar.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P4BtnLimpiar.ForeColor = Properties.Settings.Default.LettersForeColor;
            P4BtnLimpiar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P4BtnLimpiar.Width, P4BtnLimpiar.Height, 25, 25));


            //Tap 5
            P5BtnFiguras.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P5BtnFiguras.ForeColor = Properties.Settings.Default.LettersForeColor;
            P5BtnFiguras.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P5BtnFiguras.Width, P5BtnFiguras.Height, 25, 25));

            //Tap 6

            //Tap 7

            //Tap 8

            //Tap 9

            //Tap 10
            P10LblTitulo.ForeColor = Properties.Settings.Default.LettersForeColor;
            P10BtnProyectoFinal.ForeColor = Properties.Settings.Default.LettersForeColor;
            P10BtnProyectoFinal.BackColor = Properties.Settings.Default.ButtonsBackColor;
            P10BtnProyectoFinal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, P10BtnProyectoFinal.Width, P10BtnProyectoFinal.Height, 25, 25));
            Tp10.Padding = new Padding(this.Width / 2, this.Height / 2, 0, 0);
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
            CPersonaPrueba Persona1;
            CPersonaPrueba Persona2;
            CPersonaPrueba Persona3;

            Persona1 = new CPersonaPrueba(0, DateTime.Today, "Mexicana");
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
                //BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Este.png"),
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
                //BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Sur.png"),
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
                //BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Sur-Este.png"),
                BackgroundImageLayout = ImageLayout.Stretch
            };

            Meta.Enciende();
            Meta.Eleva(10);
            Meta.Desplazar(1);

            Metas.Add(Meta);
        }

        //---------------------------------------------------------------------
        //Destruye los drones en ejecución.
        //---------------------------------------------------------------------
        private void P2BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (CMeta Proceso in Metas)
            {
                Proceso.Termina();
            }

            Metas.Clear();
            Properties.Settings.Default.Reset();
            P2PnlContenedor.Controls.Clear();
        }

        //---------------------------------------------------------------------
        //Abre monitor de los drones en ejecución.
        //---------------------------------------------------------------------
        private void P2BtnMonitor_Click(object sender, EventArgs e)
        {
            DlgMonitorDrones dlgPractica3 = new DlgMonitorDrones(Metas);
            dlgPractica3.Show();
        }
        #endregion

        #region Práctica 3

        //---------------------------------------------------------------------
        //Abre monitor de los drones en ejecución.
        //---------------------------------------------------------------------
        private void P3BtnMonitor_Click(object sender, EventArgs e)
        {
            DlgMonitorDrones dlgPractica3 = new DlgMonitorDrones(Metas);
            dlgPractica3.Show();
        }
        #endregion

        #region Práctica 4

        //---------------------------------------------------------------------
        //Destruye los Seres Vivos en ejecución.
        //---------------------------------------------------------------------
        private void P4BtnLimpiar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            foreach (CSerVivo Proceso in SeresVivos)
            {
                Proceso.Dispose();
            }

            P4PtbContenedor.Controls.Clear();
        }

        //---------------------------------------------------------------------
        //Botón crear un Ser Vivo.
        //---------------------------------------------------------------------
        private void P4BtnSerVivo_Click(object sender, EventArgs e)
        {
            int Personas = 0;
            int Otros;
            SoundPlayer Sound;

            foreach (CSerVivo Ser in SeresVivos)
            {
                if (Ser == Persona)
                {
                    Personas++;
                }
            }

            Otros = SeresVivos.Count - Personas;

            if (Personas > Otros)
            {
                Sound = new SoundPlayer(Properties.Resources.Sound2);
                Sound.Play();
            }
            if (Personas < Otros)
            {
                Sound = new SoundPlayer(Properties.Resources.Sound1);
                Sound.Play();
            }
        }

        //---------------------------------------------------------------------
        //Botón para expandir o contrater panel con los tipos de Seres Vivos.
        //---------------------------------------------------------------------
        private void P4BtnAbrirPanelHorizontal_Click(object sender, EventArgs e)
        {
            if (P4FlPnlContenedorBotonesHorizontales.Visible == false)
            {
                P4FlPnlContenedorBotonesHorizontales.Visible = true;
            }
            else
            {
                P4FlPnlContenedorBotonesHorizontales.Visible = false;
            }
        }

        //---------------------------------------------------------------------
        //Botón crear un Animal.
        //---------------------------------------------------------------------
        private void P4BtnAnimal_Click(object sender, EventArgs e)
        {
            CAnimal Animal = new CAnimal(10, 10, P4PtbContenedor);
            Animal.Nacer();
            Animal.Desplazar(1);
            SeresVivos.Add(Animal);
        }

        //---------------------------------------------------------------------
        //Botón crear una Planta.
        //---------------------------------------------------------------------
        private void P4BtnPlanta_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            CVegetal Vegetal = new CVegetal(Aleatorio.Next(0, P4PtbContenedor.Width),
                                            Aleatorio.Next(0, P4PtbContenedor.Height),
                                            P4PtbContenedor,
                                            SeresVivos);
            Vegetal.Nacer();
            SeresVivos.Add(Vegetal);
        }

        //---------------------------------------------------------------------
        //Botón crear una Hongo.
        //---------------------------------------------------------------------
        private void P4BtnHongo_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            CHongo Hongo = new CHongo(Aleatorio.Next(0, P4PtbContenedor.Width),
                                      Aleatorio.Next(0, P4PtbContenedor.Height),
                                      P4PtbContenedor,
                                      SeresVivos);
            Hongo.Nacer();
            SeresVivos.Add(Hongo);
        }

        //---------------------------------------------------------------------
        //Botón crear un Protoctista.
        //---------------------------------------------------------------------
        private void P4BtnProtoctista_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            CProtoctista Protoctista = new CProtoctista(Aleatorio.Next(0, P4PtbContenedor.Width),
                                            Aleatorio.Next(0, P4PtbContenedor.Height),
                                            P4PtbContenedor,
                                            SeresVivos);
            Protoctista.Nacer();
            SeresVivos.Add(Protoctista);
        }

        //---------------------------------------------------------------------
        //Botón crear una Bacteria.
        //---------------------------------------------------------------------
        private void P4BtnBacteria_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            CBacteria Bacteria = new CBacteria(Aleatorio.Next(0, P4PtbContenedor.Width),
                                            Aleatorio.Next(0, P4PtbContenedor.Height),
                                            P4PtbContenedor,
                                            SeresVivos);
            Bacteria.Nacer();
            Bacteria.Desplazar(1);
            SeresVivos.Add(Bacteria);
        }

        //---------------------------------------------------------------------
        //Botón crear una Persona.
        //---------------------------------------------------------------------
        private void P4BtnPersona_Click(object sender, EventArgs e)
        {
            Persona = new CPersona(P4PtbContenedor.Width / 2,
                                            P4PtbContenedor.Height / 2,
                                            P4PtbContenedor,
                                            SeresVivos);
            Persona.Nacer();
            Persona.Desplazar(1);
            SeresVivos.Add(Persona);
        }

        //---------------------------------------------------------------------
        //Easter-Egg.
        //---------------------------------------------------------------------
        private void P4BtnGif_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            if (Reproductor.Visible == false)
            {
                Reproductor.Visible = true;
                Reproductor.URL = URL[Aleatorio.Next(0, URL.Count)];
                Reproductor.Ctlcontrols.play();
            }
            else
            {
                Reproductor.Visible = false;
                Reproductor.Ctlcontrols.stop();
            }
        }

        #endregion

        //---------------------------------------------------------------------
        //Abre el Proyecto Final.
        //---------------------------------------------------------------------
        private void P10BtnProyectoFinal_Click(object sender, EventArgs e)
        {
            DlgLogin login = new DlgLogin();
            login.Show();
            this.Dispose();
        }

        #region Práctica 5
        //---------------------------------------------------------------------
        //Abre la ventana para dibujar figuras.
        //---------------------------------------------------------------------
        private void P5BtnFiguras_Click(object sender, EventArgs e)
        {
            DlgFiguras Figuras = new DlgFiguras();
            Figuras.Show();
        }
        #endregion
    }
}
