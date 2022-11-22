using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO22B_FPA.src.Class.P4
{
    //---------------------------------------------------------------------
    //Clase que representa un Protoctista.
    //FPA. 29/09/2022.
    //---------------------------------------------------------------------
    public class CProtoctista : CSerVivo
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private bool Crecer;

        //Atributos para redondear los bordes del objeto.
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

        //Atrubuto para el almacenamiento de los Seres Vivos:
        private List<CSerVivo> SeresVivos;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CProtoctista(int XNacimiento, int YNacimiento, Control Area, List<CSerVivo> SeresVivos) : base(XNacimiento, YNacimiento, Area)
        {
            //Inicializa atributos de control.
            Nacio = false;
            Muerto = false;
            Crecer = false;

            //Inicializa atributos de navegación.
            Norte = false;
            Sur = false;
            Este = false;
            Oeste = false;
            Velocidad = 1;

            //Bordes redondeados del botón.
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            SendToBack();

            //Inicializa la lista de imagenes.
            Tipos = new List<Bitmap>
            {
                Properties.Resources.PRTipo1,
                Properties.Resources.PRTipo2
            };

            //Inicialización de mensajes.
            Mensajes = new List<string>
            {
                "🌱",
                "🏜",
                "🌊",
                "🥣"
            };

            //Inicializa un random para las imágenes de fondo.
            Aleatorio = new Random();

            //Asignación de listas.
            this.SeresVivos = SeresVivos;
        }

        //---------------------------------------------------------------------
        //Nace el Protoctista.
        //---------------------------------------------------------------------
        public override void Nacer()
        {
            Thread Hilo;
            Random Aleatorio = new Random();

            //Nace el Protoctista después de un segundo y medio.
            Hilo = new Thread(() => {
                Thread.Sleep(1500);
                BackColor = Color.Transparent;
                BackgroundImage = Tipos[Aleatorio.Next(0, Tipos.Count)];
                BackgroundImageLayout = ImageLayout.Stretch;
                Nacio = true;
                Crecer = true;
                Crecimiento(Crecer);
                while (Hambre > 0 && !Muerto)
                {
                    if (Hambre < 25)
                    {
                        BackColor = Color.Red;
                    }
                    if (Hambre == 1)
                    {
                        Dispose();
                    }

                    Thread.Sleep(500);
                    Hambre--;
                }
            });

            Hilo.Start();
        }

        //---------------------------------------------------------------------
        //Crece el Proctoctista.
        //---------------------------------------------------------------------
        public void Crecimiento(bool Crecer)
        {
            this.Crecer = Crecer;
            int Tamaño = Aleatorio.Next(0, 5);
            int i = 0;

            //Crece el tamaño del Protoctista de manera aleatoria.
            //NOTA: Se utiliza un hilo de ejecución el cual deberá ser
            //finalizado al término del programa.
            ProcesoVida = new Thread(() =>
            {
                while (!Muerto && i < Tamaño)
                {
                    if (Crecer)
                    {
                        for (i = 0; i < Tamaño; i++)
                        {
                            Size = new Size(Width + i, Height + i);
                            Thread.Sleep(100);
                        }
                        //Bordes redondeados del botón.
                        Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
                    }
                }
            });

            ProcesoVida.Start();
        }

        //---------------------------------------------------------------------
        //Al dar clic sobre el Protoctista.
        //---------------------------------------------------------------------
        protected override void Evento_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoProtoctista;
            Notify.BalloonTipTitle = "Protoctista";
            Notify.BalloonTipText = Mensajes[Aleatorio.Next(0, Mensajes.Count)];
            Notify.ShowBalloonTip(1000);
            Notify.BalloonTipClicked += delegate
            {
                switch (Notify.BalloonTipText)
                {
                    case "🌱":
                        CProtoctista Protoctista = new CProtoctista(Aleatorio.Next(0, Area.Width),
                                                        Aleatorio.Next(0, Area.Height),
                                                        Area,
                                                        SeresVivos);
                        Protoctista.Nacer();
                        SeresVivos.Add(Protoctista);
                        break;

                    case "🏜":
                        this.Dispose();
                        break;

                    case "🌊":
                        this.Crecimiento(Crecer);
                        break;

                    case "🥣":
                        Comer();
                        break;
                }
            };
        }

        //---------------------------------------------------------------------
        //Alimenta al Protoctista.
        //---------------------------------------------------------------------
        protected override void Comer()
        {
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoProtoctista;
            Notify.BalloonTipTitle = "Fotosintesis - Nivel de nutrientes : " + Hambre.ToString();
            Notify.BalloonTipText = "☀️☀️☀️☀️☀️";
            Notify.ShowBalloonTip(1000);
            Notify.BalloonTipClicked += delegate
            {
                BackColor = Color.Transparent;
                Hambre += 100;
            };
        }

        //---------------------------------------------------------------------
        //Destrucción del objeto.
        //---------------------------------------------------------------------
        protected override void Dispose(bool disposing)
        {
            Muerto = true;
            base.Dispose(disposing);
        }
    }
}
