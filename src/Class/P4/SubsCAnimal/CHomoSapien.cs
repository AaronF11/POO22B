using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO22B_FPA.src.Class.P4.SubsCAnimal
{
    //---------------------------------------------------------------------
    //Clase que representa un Homo Sapien.
    //FPA. 29/09/2022.
    //---------------------------------------------------------------------
    public class CHomoSapien : CHominidae
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CHomoSapien(int XNacimiento, int YNacimiento, Control Area) : base(XNacimiento, YNacimiento, Area)
        {

        }
    }
}
