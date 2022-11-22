using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO22B_FPA.src.Class.P4.SubsCAnimal
{
    //---------------------------------------------------------------------
    //Clase que representa un Homo Sapien.
    //FPA. 29/09/2022.
    //---------------------------------------------------------------------
    public class CPersona : CHomoSapien
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //Atrubuto para el almacenamiento de los Seres Vivos:
        private List<CSerVivo> SeresVivos;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CPersona(int XNacimiento, int YNacimiento, Control Area, List<CSerVivo> SeresVivos) : base(XNacimiento, YNacimiento, Area)
        {
            //Inicializa la lista de imagenes.
            Tipos = new List<Bitmap>
            {
                Properties.Resources.PTipo1,
                Properties.Resources.PTipo2
            };

            //Inicialización de lista de mensajes.
            Mensajes = new List<string>
            {
                "Hola, soy una persona social",
                "Hasta la proxima",
                "No me toques, por favor",
                "🥣"
            };

            //Inicializa un random.
            Aleatorio = new Random();

            //Asignación de listas.
            this.SeresVivos = SeresVivos;
        }

        //---------------------------------------------------------------------
        //Nace la Persona.
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
        //Desplaza la Persona a una velocidad determinada.
        //---------------------------------------------------------------------
        public override void Desplazar(int Velocidad)
        {
            //Variables de posición en X y Y.
            int X;
            int Y;

            //Inicialización de la velocidad de la Persona.
            this.Velocidad = Velocidad;

            //Desplaza la Persona por tiempo indefinido.
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
        //Al dar clic sobre la Persona.
        //---------------------------------------------------------------------
        protected override void Evento_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoPersona;
            Notify.BalloonTipTitle = "Persona";
            Notify.BalloonTipText = Mensajes[Aleatorio.Next(0, Mensajes.Count)];
            Notify.ShowBalloonTip(1000);
            Notify.BalloonTipClicked += delegate
            {
                switch (Notify.BalloonTipText)
                {
                    case "Hola, soy una persona social":
                        CPersona Persona = new CPersona(Area.Width / 2,
                                                        Area.Height / 2,
                                                        Area,
                                                        SeresVivos);
                        Persona.Nacer();
                        Persona.Desplazar(1);
                        SeresVivos.Add(Persona);
                        break;

                    case "Hasta la proxima":
                        this.Dispose();
                        break;

                    case "🥣":
                        Comer();
                        break;
                }
            };
        }

        //---------------------------------------------------------------------
        //Alimenta a la Persona.
        //---------------------------------------------------------------------
        protected override void Comer()
        {
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoPersona;
            Notify.BalloonTipTitle = "Comiendo - Nivel de hambre : " + Hambre.ToString();
            Notify.BalloonTipText = "🥩🥩🥩🥩🥩";
            Notify.ShowBalloonTip(1000);
            Notify.BalloonTipClicked += delegate
            {
                BackColor = Color.Transparent;
                Hambre += 50;
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
