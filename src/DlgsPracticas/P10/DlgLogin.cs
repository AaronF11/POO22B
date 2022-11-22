using POO22B_FPA.src.Class.P10;
using POO22B_FPA.src.DlgsPracticas.P10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO22B_FPA
{
    public partial class DlgLogin : Form
    {
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Atributos.
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Contructor.
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public DlgLogin()
        {
            InitializeComponent();

            //Bordes redondeados de la ventana.
            Redondear();
            //Información de los componentes.
            InfoComponentes();
        }

        #region Configuración de la ventana
        //---------------------------------------------------------------------
        //Permitir mover la ventana por la pantalla.
        //---------------------------------------------------------------------
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void DlgLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //---------------------------------------------------------------------
        //Redondea los bordes de la ventana.
        //---------------------------------------------------------------------
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
        private void Redondear()
        {
            //Componentes a los que se le aplica el redondeo.
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            TxtName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtName.Width, TxtName.Height, 15, 15));
            TxtPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtName.Width, TxtName.Height, 15, 15));
            BtnLog_in.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtName.Width, TxtName.Height, 15, 15));
        }

        //---------------------------------------------------------------------
        //Muestra información sobre el componente en el que se encuentra
        //el puntero.
        //---------------------------------------------------------------------
        private void InfoComponentes()
        {
            TltDescription.SetToolTip(PtbIcon, "Usuario");
            TltDescription.SetToolTip(TxtName, "Ingresa un usuario");
            TltDescription.SetToolTip(TxtPassword, "Ingresa una contraseña");
        }

        //---------------------------------------------------------------------
        //Validación de las cajas de texto.
        //---------------------------------------------------------------------
        private void ValidacionTXT()
        {
            if (TxtName.Text == "")
            {
                NotifyIcon Notify = new NotifyIcon();
                Notify.Visible = true;
                Notify.Icon = Properties.Resources.IcoPersona;
                Notify.BalloonTipTitle = "Nombre - 👻";
                Notify.BalloonTipText = "Hace falta ingresar un nombre de usuario";
                Notify.ShowBalloonTip(1000);
                TxtName.Focus();
            }
            if (TxtPassword.Text == "")
            {
                NotifyIcon Notify = new NotifyIcon();
                Notify.Visible = true;
                Notify.Icon = Properties.Resources.IcoPersona;
                Notify.BalloonTipTitle = "Contraseña - 🔑";
                Notify.BalloonTipText = "Hace falta ingresar una contraseña";
                Notify.ShowBalloonTip(1000);
                TxtPassword.Focus();
            }
            if (TxtName.Text != "" && TxtPassword.Text != "")
            {
                try
                {
                    CDataBase db = new CDataBase();
                    db.Verification(TxtName, TxtPassword);
                    this.Dispose();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        #endregion

        //---------------------------------------------------------------------
        //Abre el Loading.
        //---------------------------------------------------------------------
        private void BtnLog_in_Click(object sender, EventArgs e)
        {
            ValidacionTXT();
        }

        //---------------------------------------------------------------------
        //Cierra la aplicación.
        //---------------------------------------------------------------------
        private void PtbClose_Click(object sender, EventArgs e)
        {
            DlgPracticas dlgPracticas = new DlgPracticas();
            dlgPracticas.Show();
            this.Dispose();
        }

        //---------------------------------------------------------------------
        //Abre y cierra el panel de opciones.
        //---------------------------------------------------------------------
        private void PtbOptions_Click(object sender, EventArgs e)
        {
            if (FlPnlOptions.Width == 67)
            {
                FlPnlOptions.Width = 0;
            }
            else
            {
                FlPnlOptions.Width = 67;
            }
        }

        //---------------------------------------------------------------------
        //Recupera la contraseña del usuario.
        //---------------------------------------------------------------------
        private void LnkLblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        //---------------------------------------------------------------------
        //Abre la ventana de registro.
        //---------------------------------------------------------------------
        private void LnkLblSign_Up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DlgRegister dlgRegister = new DlgRegister();
            dlgRegister.Show();
            this.Dispose();
        }

        //---------------------------------------------------------------------
        //Crea la base de datos si es que no existe aún.
        //---------------------------------------------------------------------
        private void DlgLogin_Load(object sender, EventArgs e)
        {
            CDataBase db = new CDataBase();
            db.Create_db();
        }
    }
}
