using POO22B_FPA.src.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace POO22B_FPA
{
    //---------------------------------------------------------------------
    //Clase que representa el diálogo principal.
    //FPA. 25/08/2022.
    //---------------------------------------------------------------------
    public partial class DlgPracticas : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgPracticas()
        {
            InitializeComponent();
        }

        #region Eventos de tamaño de la ventana
        //╔═════════════════════════════════╗
        //║ Mover la posición de la ventana ║
        //╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void FlpTopButtonsPracticas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //╔════════════════╗
        //║ Cerrar ventana ║
        //╚════════════════╝
        private void BtnCLosePracticas_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgPrincipal dlgPrincipal = new DlgPrincipal();
            dlgPrincipal.Show();
        }

        //╔═══════════════════╗
        //║ Maximizar ventana ║
        //╚═══════════════════╝
        private void BtnMaximizedPracticas_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal )this.WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;

        }

        //╔═══════════════════╗
        //║ Minimizar ventana ║
        //╚═══════════════════╝
        private void BtnMinimizedPracticas_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Botón de prueba
        //---------------------------------------------------------------------
        //Al dar clic en el botón de pruebas.
        //---------------------------------------------------------------------
        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            CPelota MiPelota1;
            CPelota MiPelota2;

            MiPelota1 = new CPelota(25, 1, "Policloruro de Vinilo", "China");
            MiPelota2 = new CPelota(25, 1, "Policloruro de Vinilo", "China");

            MessageBox.Show(MiPelota1.Inflar(5).GetMessage());
            MessageBox.Show(MiPelota2.Inflar(7).GetMessage());
        }
        #endregion

        private void BtnPersonas_Click(object sender, EventArgs e)
        {
            CPersona Persona1;
            CPersona Persona2;
            CPersona Persona3;

            Persona1 = new CPersona(0, DateTime.Today, "Mexicana");
            Persona2 = new CCliente(1,DateTime.Today,"Colombia", "COL123");
            Persona3 = new CCliente(0, DateTime.Today, "Cubana", "COB456");

            Persona1.SetNombre("Maria");
            Persona2.SetNombre("José");
            Persona3.SetNombre("Consuelo");

            MessageBox.Show($"Persona 1: {Persona1.GetNombre()}, Persona 2: {Persona2.GetNombre()}, Persona 3: {Persona3.GetNombre()}");
        }
    }
}
