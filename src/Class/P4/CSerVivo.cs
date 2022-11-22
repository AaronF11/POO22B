using POO22B_FPA.src.DlgsMenu;
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
    //Clase que representa un Ser vivo.
    //FPA. 29/09/2022.
    //---------------------------------------------------------------------
    public abstract class CSerVivo : Button
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //Atributos del nacimiento:
        protected int XNacimiento;
        protected int YNacimiento;

        //Atributos del área de desplazamiento:
        protected Control Area;
        protected bool Norte;
        protected bool Sur;
        protected bool Este;
        protected bool Oeste;
        protected int Velocidad;

        //Atributos de control:
        protected bool Nacio;
        protected bool Muerto;
        protected bool Regresar;

        //Atributos de ejecución:
        protected Thread ProcesoVida;

        //Atributos para redondear los bordes del botón:
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

        //Atributos de tipos de imagenes del ser vivo:
        protected List<Bitmap> Tipos;

        //Atributos de tipos de aleatorio:
        protected Random Aleatorio;

        //Atributos de mensajes:
        protected List<string> Mensajes;

        //Atributo de nivel de hambre:
        protected int Hambre;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CSerVivo(int XNacimiento, int YNacimiento, Control Area)
        {
            //Inicialización de atributos del nacimiento.
            this.XNacimiento = XNacimiento;
            this.YNacimiento = YNacimiento;

            //Inicialización de atributos del área de desplazamiento:
            this.Area = Area;
            this.Area.Controls.Add(this);

            //Inicializa atributos de navegación.
            Norte = false;
            Sur = true;
            Este = true;
            Oeste = false;
            Velocidad = 0;

            //Inicializa atributos de control.
            Nacio = false;
            Muerto = false;
            Regresar = false;

            //Iniciliza atributos de ejecución.
            ProcesoVida = null;

            //Contruye el Ser vivo.
            Location = new Point(this.XNacimiento, this.YNacimiento);
            BackColor = Color.Black;
            Name = "Ser Vivo";
            Size = new Size(32, 32);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BringToFront();

            //Bordes redondeados del botón.
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //Asigna método clic.
            Click += new EventHandler(Evento_Click);

            //Asignación de nivel de hambre.
            Hambre = 100;
        }

        //---------------------------------------------------------------------
        //Nace el Ser Vivo.
        //---------------------------------------------------------------------
        public virtual void Nacer()
        {
            Thread Hilo;
            Random Aleatorio;
            int R;
            int G;
            int B;
            Color ColorAleatorio;

            //Ser vivo se colorea.
            Aleatorio = new Random();
            R = Aleatorio.Next(0, 256);
            G = Aleatorio.Next(0, 256);
            B = Aleatorio.Next(0, 256);
            ColorAleatorio = Color.FromArgb(R, G, B);

            //Nace el ser vivo después de un segundo y medio.
            Hilo = new Thread(() => {
                Thread.Sleep(1500);
                BackColor = ColorAleatorio;
                Nacio = true;
            });

            Hilo.Start();
        }

        //---------------------------------------------------------------------
        //Desplaza el Ser Vivo a una velocidad determinada.
        //---------------------------------------------------------------------
        public virtual void Desplazar(int Velocidad)
        {
            //Variables de posición en X y Y.
            int X;
            int Y;

            //Inicialización de la velocidad del Ser Vivo.
            this.Velocidad = Velocidad;

            //Desplaza el Ser vivo por tiempo indefinido.
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

                        //Posición final.
                        Location = new Point(X, Y);
                        Thread.Sleep(this.Velocidad);
                    }
                }
            });

            ProcesoVida.Start();
        }

        //---------------------------------------------------------------------
        //Alimenta al Ser Vivo.
        //---------------------------------------------------------------------
        protected abstract void Comer();


        //---------------------------------------------------------------------
        //Evento clic del ser vivo.
        //---------------------------------------------------------------------
        protected abstract void Evento_Click(object sender, EventArgs e);

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
