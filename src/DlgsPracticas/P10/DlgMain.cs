using POO22B_FPA.src.Class.P10;
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
using System.Xml.Linq;

namespace POO22B_FPA.src.DlgsPracticas.P10
{
    public partial class DlgMain : Form
    {
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Atributos.
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        string Name;
        string Mail;

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Contructor.
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public DlgMain()
        {
            InitializeComponent();

            //Bordes redondeados de la ventana.
            Redondear();

            CDataBase db = new CDataBase();
            db.Send(LblName, LblMail);
            if (LblName.Text != "AARON FLORES PASOS")
            {
                CCPtbProfile.BackgroundImage = Properties.Resources.P10_Perfil;
                CCPtbProfile.BackgroundImageLayout = ImageLayout.Center;
                CCPtbProfile.BackColor = Color.AliceBlue;
            }
            Name = LblName.Text;
            Mail = LblMail.Text;

            OpenForm(new DlgContainer());
        }

        #region Configuración de la ventana
        //---------------------------------------------------------------------
        //Permitir mover la ventana por la pantalla.
        //---------------------------------------------------------------------
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void DlgMain_MouseDown(object sender, MouseEventArgs e)
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

            PnlSelection.Height = BtnEmployers.Height;
            PnlSelection.Top = BtnEmployers.Top;
            PnlSelection.Left = BtnEmployers.Left;
            BtnEmployers.BackColor = Color.FromArgb(46, 51, 73);
        }

        //---------------------------------------------------------------------
        //Abre y cierra el panel de opciones.
        //---------------------------------------------------------------------
        private void PtbOptions_Click(object sender, EventArgs e)
        {
            if (PnlLeft.Width == 250)
            {
                PnlLeft.Width = 50;
                PtbIcon.Width = 50;
                LblName.Text = "";
                LblMail.Text = "";
            }
            else
            {
                PnlLeft.Width = 250;
                PtbIcon.Width = 248;
                LblName.Text = Name;
                LblMail.Text = Mail;
            }
        }

        //---------------------------------------------------------------------
        //Termina y cierra la aplicación.
        //---------------------------------------------------------------------
        private void BtnCLosePracticas_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //---------------------------------------------------------------------
        //Maximiza la ventana.
        //---------------------------------------------------------------------
        private void BtnMaximizedPracticas_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));

            }

            else if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
                StartPosition = FormStartPosition.CenterScreen;
            }
        }

        //---------------------------------------------------------------------
        //Minimiza la ventana.
        //---------------------------------------------------------------------
        private void BtnMinimizedPracticas_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void OpenForm(object Form)
        {
            if (PnlContainer.Controls.Count > 0)
            {
                PnlContainer.Controls.RemoveAt(0);
            }
            Form Frm = Form as Form;
            Frm.TopLevel = false;
            Frm.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(Frm);
            PnlContainer.Tag = Frm;
            Frm.Show();
        }

        private void BtnEmployers_Click(object sender, EventArgs e)
        {
            OpenForm(new DlgDocente());
            PnlSelection.Height = BtnEmployers.Height;
            PnlSelection.Top = BtnEmployers.Top;
            PnlSelection.Left = BtnEmployers.Left;
            BtnEmployers.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnTeachers_Click(object sender, EventArgs e)
        {
            OpenForm(new DlgMaestros());
            PnlSelection.Height = BtnTeachers.Height;
            PnlSelection.Top = BtnTeachers.Top;
            PnlSelection.Left = BtnTeachers.Left;
            BtnTeachers.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            OpenForm(new DlgAlumnos());
            PnlSelection.Height = BtnStudents.Height;
            PnlSelection.Top = BtnStudents.Top;
            PnlSelection.Left = BtnStudents.Left;
            BtnStudents.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnBuilds_Click(object sender, EventArgs e)
        {
            OpenForm(new DlgEdificios());
            PnlSelection.Height = BtnBuilds.Height;
            PnlSelection.Top = BtnBuilds.Top;
            PnlSelection.Left = BtnBuilds.Left;
            BtnBuilds.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnTI_Click(object sender, EventArgs e)
        {
            OpenForm(new DlgEquiposIT());
            PnlSelection.Height = BtnTI.Height;
            PnlSelection.Top = BtnTI.Top;
            PnlSelection.Left = BtnTI.Left;
            BtnTI.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void PtbIcon_Click(object sender, EventArgs e)
        {
            OpenForm(new DlgContainer());
        }

        private void BtnEmployers_Leave(object sender, EventArgs e)
        {
            BtnEmployers.BackColor = Color.FromArgb(22, 33, 50);
        }

        private void BtnTeachers_Leave(object sender, EventArgs e)
        {
            BtnTeachers.BackColor = Color.FromArgb(22, 33, 50);
        }

        private void BtnStudents_Leave(object sender, EventArgs e)
        {
            BtnStudents.BackColor = Color.FromArgb(22, 33, 50);
        }

        private void BtnBuilds_Leave(object sender, EventArgs e)
        {
            BtnBuilds.BackColor = Color.FromArgb(22, 33, 50);
        }

        private void BtnTI_Leave(object sender, EventArgs e)
        {
            BtnTI.BackColor = Color.FromArgb(22, 33, 50);
        }
    }
}
