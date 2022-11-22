using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO22B_FPA.src.DlgsPracticas.P10
{
    public partial class DlgContainer : Form
    {
        public DlgContainer()
        {
            InitializeComponent();
        }

        private void DlgContainer_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
