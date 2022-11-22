using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO22B_FPA.src.Class.P4
{
    //---------------------------------------------------------------------
    //Clase que representa un Vegetal.
    //FPA. 29/09/2022.
    //---------------------------------------------------------------------
    public class CVegetal : CSerVivo
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //Atributo para el crecimiento:
        private bool Crecer;

        //Atributos para redondear los bordes del objeto:
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
        public CVegetal(int XNacimiento, int YNacimiento, Control Area, List<CSerVivo> SeresVivos) : base(XNacimiento, YNacimiento, Area)
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
                Properties.Resources.VTipo1,
                Properties.Resources.VTipo2,
                Properties.Resources.VTipo3,
                Properties.Resources.VTipo4,
                Properties.Resources.VTipo5,
                Properties.Resources.VTipo6
            };

            //Inicialización de mensajes.
            Mensajes = new List<string>
            {
                "🌱",
                "🏜",
                "🌧",
                "🥣"
            };

            //Asignación de listas.
            this.SeresVivos = SeresVivos;
        }

        //---------------------------------------------------------------------
        //Nace el Vegetal.
        //---------------------------------------------------------------------
        public override void Nacer()
        {
            Thread Hilo;
            Random Aleatorio = new Random();

            //Nace el Vegetal después de un segundo y medio.
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
        //Crece el Vegetal.
        //---------------------------------------------------------------------
        public void Crecimiento(bool Crecer)
        {
            Random Aleatorio = new Random();

            this.Crecer = Crecer;
            int Tamaño = Aleatorio.Next(0, 10);
            int i = 0;

            //Crece el tamaño del Vegetal de manera aleatoria.
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
        //Al dar clic sobre el Vegetal.
        //---------------------------------------------------------------------
        protected override void Evento_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoVegetal;
            Notify.BalloonTipTitle = "Vegetal";
            Notify.BalloonTipText = Mensajes[Aleatorio.Next(0, Mensajes.Count)];
            Notify.ShowBalloonTip(1000);
            Notify.BalloonTipClicked += delegate
            {
                switch (Notify.BalloonTipText)
                {
                    case "🌱":
                        CVegetal Vegetal = new CVegetal(Aleatorio.Next(0, Area.Width),
                                                        Aleatorio.Next(0, Area.Height),
                                                        Area,
                                                        SeresVivos);
                        Vegetal.Nacer();
                        SeresVivos.Add(Vegetal);
                        break;

                    case "🏜":
                        this.Dispose();
                        break;

                    case "🌧":
                        this.Crecimiento(Crecer);
                        break;

                    case "🥣":
                        Comer();
                        break;
                }
            };
        }

        //---------------------------------------------------------------------
        //Alimenta al Vegetal.
        //---------------------------------------------------------------------
        protected override void Comer()
        {
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoVegetal;
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
