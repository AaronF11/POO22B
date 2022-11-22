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
    //Clase que representa una Elipse.
    //FPA. 15/11/2022.
    //---------------------------------------------------------------------
    internal class CElipse : CFigura
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        Graphics g;
        int CX, CY, SX, SY;
        Pen Pen;
        Color Color;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CElipse(Graphics Graficos, int CX, int CY, int SX, int SY, Color Color)
        {
            g = Graficos;
            this.CX = CX;
            this.CY = CY;
            this.SX = SX;
            this.SY = SY;
            this.Color = Color;
        }

        //---------------------------------------------------------------------
        //Metodo para dibujar elipse.
        //---------------------------------------------------------------------
        public override void Dibujar()
        {
            Pen = new Pen(Color, 3);
            g.DrawEllipse(Pen, CX, CY, SX, SY);
        }
    }
}
