using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO22B_FPA.src.Class.P5
{
    //---------------------------------------------------------------------
    //Clase que representa una linea.
    //FPA. 10/11/2022.
    //---------------------------------------------------------------------
    internal class CLinea
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        PictureBox Ptb;
        Graphics g;
        Point x, y;
        Pen Pen;
        Color Color;
        int CX, CY, X, Y;


        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CLinea(PictureBox Contenedor, Graphics Graficos, Point x, Point y, int CX, int CY, int X, int Y, Color Color)
        {
            Ptb = Contenedor;
            g = Graficos;
            this.x = x;
            this.y = y;
            this.CX = CX;
            this.CY = CY;
            this.X = X;
            this.Y = Y;
            this.Color = Color;
        }

        public void Dibujar(int Tipo)
        {
            Pen = new Pen(Color, 3);
            if (Tipo == 1)
            {
                g.DrawLine(Pen, x, y);
            }
            if (Tipo == 2)
            {
                g.DrawLine(Pen, CX, CY, X, Y);
            }
        }

        public void Borrar()
        {
            Pen = new Pen(Ptb.BackColor, 10);
            g.DrawLine(Pen, x, y);
        }
    }
}
