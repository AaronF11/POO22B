using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public int Velocidad;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CMeta(int Velocidad) : base()
        {
            InitializeComponent();
            this.Velocidad = Velocidad;
        }
    }
}
