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

namespace POO22B_FPA.src.Class
{
    //---------------------------------------------------------------------
    //Clase que representa un dron.
    //FPA. 08/09/22.
    //---------------------------------------------------------------------
    public partial class CMeta : PictureBox
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //Atributos de l base:
        private int XBase;
        private int YBase;

        //Atributos del área de vuelo:
        private Control Area;

        //Atributos de navegación:
        private int Altura;
        private bool Norte;
        private bool Sur;
        private bool Este;
        private bool Oeste;
        private int Velocidad;

        //Atributos de control:
        public bool Encendido;
        public bool Regresar;
        public bool Apagando
        {
            get; set;
        }

        //Atributos de ejecución:
        Thread Hilo;


        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CMeta(int XBase, int YBase, Control Area) : base()
        {
            InitializeComponent();

            //Inicializa atributos a la base.
            this.XBase = XBase;
            this.YBase = YBase;

            //Inicializa atributos del área de vuelo.
            this.Area = Area;
            this.Area.Controls.Add(this);

            //Inicializa atributos de navegación.
            Altura = 0;
            Norte = false;
            Sur = true;
            Este = true;
            Oeste = false;
            Velocidad = 0;

            //Inicializa atributos de control.
            Encendido = false;
            Regresar = false;
            Apagando = false;

            //Iniciliza atributos de ejecución.
            Hilo = null;

            //Contruye el dron.
            Location = new Point(this.XBase, this.YBase);
            BackColor = Color.Black;
            Name = "Meta";
            Size = new Size(32, 32);
            BringToFront();

            //Asigna método clic.
            Click += new EventHandler(EnClic);
        }

        //---------------------------------------------------------------------
        //Enciende el dron.
        //---------------------------------------------------------------------
        public void Enciende()
        {
            Thread Hilo;
            Random Aleatorio;
            int R;
            int G;
            int B;
            Color ColorAleatorio;

            //Meta se colorea.
            Aleatorio = new Random();
            R = Aleatorio.Next(0, 256);
            G = Aleatorio.Next(0, 256);
            B = Aleatorio.Next(0, 256);
            ColorAleatorio = Color.FromArgb(R, G, B);

            //Enciende el dron después de un segundo.
            Hilo = new Thread(() => {
                Thread.Sleep(1000);
                BackColor = ColorAleatorio;
                Encendido = true;
            });

            Hilo.Start();
        }

        //---------------------------------------------------------------------
        //Eleva el dron.
        //---------------------------------------------------------------------
        public void Eleva(int Altura)
        {
            this.Altura = Altura;
        }

        //---------------------------------------------------------------------
        //Desplaza el dron a una velocidad determinada.
        //---------------------------------------------------------------------
        public void Desplazar(int Velocidad)
        {
            //Variables de posición en X y Y.
            int X;
            int Y;

            //Inicialización de la velocidad del dron.
            this.Velocidad = Velocidad;

            //Desplaza el dron por tiempo indefinido.
            //NOTA: Se utiliza un hilo de ejecución el cual deberá ser
            //finalizado al término del programa.
            Hilo = new Thread(() =>
            {
                while (true)
                {
                    if (Encendido)
                    {
                        //Posición inicial.
                        X = Location.X;
                        Y = Location.Y;

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

                        //Determina el rebote.
                        if (X <= 0)
                        {
                            Oeste = false;

                            if (!Regresar)
                            {
                                Este = true;
                            }

                            BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Este.png");
                        }


                        if (X >= Area.Width - Width)
                        {
                            Este = false;
                            Oeste = true;
                            BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Oeste.png");
                        }

                        //Determina el rebote.
                        if (Y <= 0)
                        {
                            Norte = false;

                            if (!Regresar)
                            {
                                Sur = true;
                            }

                            BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Sur.png");
                        }

                        if (Y >= Area.Height - Height)
                        {
                            Sur = false;
                            Norte = true;
                            BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Norte.png");
                        }

                        //Posición final.
                        Location = new Point(X, Y);
                        Thread.Sleep(this.Velocidad);
                    }
                }
            });

            Hilo.Start();
            Apagando = false;
        }

        //---------------------------------------------------------------------
        //Apaga el dron.
        //---------------------------------------------------------------------
        public bool Apagar()
        {
            if (Altura == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //---------------------------------------------------------------------
        //Termina el dron.
        //---------------------------------------------------------------------
        public void Termina()
        {
            Hilo.Abort();
        }

        //---------------------------------------------------------------------
        //Al dar clic sobre el dron.
        //---------------------------------------------------------------------
        private void EnClic(object sender, EventArgs e)
        {
            if (Location.X == 0 && Location.Y == 0)
            {
                Regresar = false;
                Apagando = false;
            }

            else
            {
                Norte = true;
                Sur = false;
                Este = false;
                Oeste = true;

                Regresar = true;
            }
        }

        //Avance personal.

        //---------------------------------------------------------------------
        //Regresa al punto de origen el dron.
        //---------------------------------------------------------------------
        public void Detener(bool Apagando)
        {
            this.Apagando = Apagando;

            if (Apagando == true)
            {
                if (Location.X == 0 && Location.Y == 0)
                {
                    Regresar = false;
                }
            }

            else
            {
                Norte = true;
                Sur = false;
                Este = false;
                Oeste = true;

                Regresar = true;
            }
        }

        //---------------------------------------------------------------------
        //Desplazamiento sobre eje X.
        //---------------------------------------------------------------------
        public void EjeX(int Velocidad)
        {
            //Variables de posición en X y Y.
            int X;
            int Y;

            //Inicialización de la velocidad del dron.
            this.Velocidad = Velocidad;

            //Desplaza el dron por tiempo indefinido.
            //NOTA: Se utiliza un hilo de ejecución el cual deberá ser
            //finalizado al término del programa.
            Hilo = new Thread(() =>
            {
                while (true)
                {
                    if (Encendido)
                    {
                        //Posición inicial.
                        X = Location.X;
                        Y = Location.Y;

                        //Calcula dezplazamiento.
                        if (Este)
                        {
                            X += 1;
                        }

                        if (Oeste)
                        {
                            X -= 1;
                        }

                        //Determina el rebote.
                        if (X <= 0)
                        {
                            Oeste = false;

                            if (!Regresar)
                            {
                                Este = true;
                            }

                            BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Este.png");
                        }


                        if (X >= Area.Width - Width)
                        {
                            Este = false;
                            Oeste = true;
                            BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Oeste.png");
                        }

                        //Posición final.
                        Location = new Point(X, Y);
                        Thread.Sleep(this.Velocidad);
                    }
                }
            });

            Hilo.Start();
            Apagando = false;
        }

        public void EjeY(int Velocidad)
        {
            //Variables de posición en X y Y.
            int X;
            int Y;

            //Inicialización de la velocidad del dron.
            this.Velocidad = Velocidad;

            //Desplaza el dron por tiempo indefinido.
            //NOTA: Se utiliza un hilo de ejecución el cual deberá ser
            //finalizado al término del programa.
            Hilo = new Thread(() =>
            {
                while (true)
                {
                    if (Encendido)
                    {
                        //Posición inicial.
                        X = Location.X;
                        Y = Location.Y;

                        //Calcula dezplazamiento.
                        if (Norte)
                        {
                            Y -= 1;
                        }

                        if (Sur)
                        {
                            Y += 1;
                        }

                        //Determina el rebote.
                        if (Y <= 0)
                        {
                            Norte = false;

                            if (!Regresar)
                            {
                                Sur = true;
                            }

                            BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Sur.png");
                        }

                        if (Y >= Area.Height - Height)
                        {
                            Sur = false;
                            Norte = true;
                            BackgroundImage = Image.FromFile(@"C:\Users\aaron\source\repos\POO22B_FPA\Resources\Norte.png");
                        }

                        //Posición final.
                        Location = new Point(X, Y);
                        Thread.Sleep(this.Velocidad);
                    }
                }
            });

            Hilo.Start();
            Apagando = false;
        }
    }
}