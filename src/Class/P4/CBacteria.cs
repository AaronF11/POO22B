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
    //Clase que representa una Bacteria.
    //FPA. 29/09/2022.
    //---------------------------------------------------------------------
    public class CBacteria : CSerVivo
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
        public CBacteria(int XNacimiento, int YNacimiento, Control Area, List<CSerVivo> SeresVivos) : base(XNacimiento, YNacimiento, Area)
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
                Properties.Resources.BTipo1,
                Properties.Resources.BTipo2,
                Properties.Resources.BTipo3,
                Properties.Resources.BTipo4
            };

            //Inicialización de mensajes.
            Mensajes = new List<string>
            {
                "💀",
                "🧫",
                "🥣"
            };

            //Inicializa un random para las imágenes de fondo.
            Aleatorio = new Random();

            //Asignación de listas.
            this.SeresVivos = SeresVivos;
        }

        //---------------------------------------------------------------------
        //Nace la Bacteria.
        //---------------------------------------------------------------------
        public override void Nacer()
        {
            Thread Hilo;
            Random Aleatorio = new Random();

            //Nace la Persona después de un segundo y medio.
            Hilo = new Thread(() => {
                Thread.Sleep(1500);
                BackColor = Color.Transparent;
                BackgroundImage = Tipos[Aleatorio.Next(0, Tipos.Count)];
                BackgroundImageLayout = ImageLayout.Stretch;
                Nacio = true;
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
        //Desplaza la Bacteria a una velocidad determinada.
        //---------------------------------------------------------------------
        public override void Desplazar(int Velocidad)
        {
            //Variables de posición en X y Y.
            int X;
            int Y;

            //Inicialización de la velocidad de la Bacteria.
            this.Velocidad = Velocidad;

            //Desplaza la Bacteria por tiempo indefinido.
            //NOTA: Se utiliza un hilo de ejecución el cual deberá ser
            //finalizado al término del programa.
            ProcesoVida = new Thread(() =>
            {
                while (!Muerto)
                {
                    if (Nacio)
                    {
                        //Posición inicial.
                        X = Location.X;
                        Y = Location.Y;

                        if (Aleatorio.Next(2) == 1)
                        {
                            Norte = true;
                            Sur = false;
                        }
                        else
                        {
                            Norte = false;
                            Sur = true;
                        }

                        if (Aleatorio.Next(2) == 1)
                        {
                            Este = true;
                            Oeste = false;
                        }
                        else
                        {
                            Este = false;
                            Oeste = true;
                        }

                        //Determina el rebote.
                        if (X <= 0)
                        {
                            Oeste = false;

                            if (!Regresar)
                            {
                                Este = true;
                            }
                        }

                        if (X >= Area.Width - Width)
                        {
                            Este = false;
                            Oeste = true;
                        }

                        //Determina el rebote.
                        if (Y <= 0)
                        {
                            Norte = false;

                            if (!Regresar)
                            {
                                Sur = true;
                            }
                        }

                        if (Y >= Area.Height - Height)
                        {
                            Sur = false;
                            Norte = true;
                        }

                        //Calcula dezplazamiento.
                        if (Norte)
                        {
                            Y -= 1;
                        }

                        if (Sur)
                        {
                            Y += 1;
                        }

                        if (Este)
                        {
                            X += 1;
                        }

                        if (Oeste)
                        {
                            X -= 1;
                        }

                        //Posición final.
                        Location = new Point(X, Y);
                        Thread.Sleep(this.Velocidad);
                    }
                }
            });

            ProcesoVida.Start();
        }

        //---------------------------------------------------------------------
        //Al dar clic sobre la Bacteria.
        //---------------------------------------------------------------------
        protected override void Evento_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoBacteria;
            Notify.BalloonTipTitle = "Bacteria";
            Notify.BalloonTipText = Mensajes[Aleatorio.Next(0, Mensajes.Count)];
            Notify.ShowBalloonTip(1000);
            Notify.BalloonTipClicked += delegate
            {
                switch (Notify.BalloonTipText)
                {
                    case "🧫":
                        CBacteria Bacteria = new CBacteria(Aleatorio.Next(0, Area.Width),
                                                        Aleatorio.Next(0, Area.Height),
                                                        Area,
                                                        SeresVivos);
                        Bacteria.Nacer();
                        SeresVivos.Add(Bacteria);
                        break;

                    case "💀":
                        this.Dispose();
                        break;

                    case "🥣":
                        Comer();
                        break;
                }
            };
        }

        //---------------------------------------------------------------------
        //Alimenta a la Bacteria.
        //---------------------------------------------------------------------
        protected override void Comer()
        {
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoBacteria;
            Notify.BalloonTipTitle = "Quimiotrofía - Niveles de carbono y nitrógeno : " + Hambre.ToString();
            Notify.BalloonTipText = "☀️☀️☀️☀️☀️";
            Notify.ShowBalloonTip(1000);
            Notify.BalloonTipClicked += delegate
            {
                BackColor = Color.Transparent;
                Hambre += 150;
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
