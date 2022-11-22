using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO22B_FPA.src.Class.P4.SubsCAnimal
{
    //---------------------------------------------------------------------
    //Clase que representa una Mammalia.
    //FPA. 29/09/2022.
    //---------------------------------------------------------------------
    public class CMammalia : CCordado
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CMammalia(int XNacimiento, int YNacimiento, Control Area) : base(XNacimiento, YNacimiento, Area)
        {

        }
    }
}
