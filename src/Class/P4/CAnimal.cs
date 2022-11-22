using POO22B_FPA.src.Class.P4.SubsCAnimal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace POO22B_FPA.src.Class.P4
{
    public class CAnimal : CSerVivo
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CAnimal(int XNacimiento, int YNacimiento, Control Area) : base(XNacimiento, YNacimiento, Area)
        {
            //Inicializa la lista de imagenes.
            Tipos = new List<Bitmap>
            {
                Properties.Resources.ATipo1,
                Properties.Resources.ATipo2,
                Properties.Resources.ATipo3,
                Properties.Resources.ATipo4
            };

            //Inicializa un random.
            Aleatorio = new Random();

            //Inicialización de mensajes.
            Mensajes = new List<string>
            {
                "😿",
                "🐾🐾🐾🐾🐾🐾",
                "🐽🐽🐽🐽🐽🐽",
                "🥣"
            };
        }

        //---------------------------------------------------------------------
        //Nace el Animal.
        //---------------------------------------------------------------------
        public override void Nacer()
        {
            Thread Hilo;
            Random Aleatorio = new Random();

            //Nace el Animal después de un segundo y medio.
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
        //Al dar clic sobre el Animal.
        //---------------------------------------------------------------------
        protected override void Evento_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoAnimal;
            Notify.BalloonTipTitle = "Animal";
            Notify.BalloonTipText = Mensajes[Aleatorio.Next(0, Mensajes.Count)];
            Notify.ShowBalloonTip(1000);
            Notify.BalloonTipClicked += delegate
            {
                switch (Notify.BalloonTipText)
                {
                    case "😿":
                        this.Dispose();
                        break;

                    case "🐾🐾🐾🐾🐾🐾":
                        this.Desplazar(2);
                        break;

                    case "🐽🐽🐽🐽🐽🐽":
                        this.Desplazar(100);
                        break;

                    case "🥣":
                        Comer();
                        break;
                }
            };
        }

        //---------------------------------------------------------------------
        //Alimenta al Animal.
        //---------------------------------------------------------------------
        protected override void Comer()
        {
            NotifyIcon Notify = new NotifyIcon();
            Notify.Visible = true;
            Notify.Icon = Properties.Resources.IcoAnimal;
            Notify.BalloonTipTitle = "Comiendo - Nivel de hambre : " + Hambre.ToString();
            Notify.BalloonTipText = "🥩🥩🥩🥩🥩";
            Notify.ShowBalloonTip(1000);
            Notify.BalloonTipClicked += delegate
            {
                BackColor = Color.Transparent;
                Hambre =+ 75;
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
