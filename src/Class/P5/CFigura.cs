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
    //Clase que representa una Figura.
    //FPA. 10/11/2022.
    //---------------------------------------------------------------------
    public abstract class CFigura
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CFigura()
        {

        }

        //---------------------------------------------------------------------
        //Dibuja la figura en el contenedor.
        //---------------------------------------------------------------------
        public abstract void Dibujar();

    }
}
