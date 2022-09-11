using POO22B_FPA.src.DlgsMenu;
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


namespace POO22B_FPA
{
    //---------------------------------------------------------------------
    //Clase que representa el diálogo principal.
    //FPA. 25/08/2022.
    //---------------------------------------------------------------------
    public partial class DlgPrincipal : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        bool SubMenuTool = false;
        bool SubMenuHelp = false;
        int CodeColor = 1;


        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
            PnlToolsMenu.Visible = false;
            PnlHelpMenu.Visible = false;
        }

        #region Eventos de tamaño de la ventana
        //╔═════════════════════════════════╗
        //║ Mover la posición de la ventana ║
        //╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void FlpTopButtonsMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //╔════════════════╗
        //║ Cerrar ventana ║
        //╚════════════════╝
        private void BtnCLoseMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //╔═══════════════════╗
        //║ Minimizar ventana ║
        //╚═══════════════════╝
        private void BtnMinimizedMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Prácticas
        //╔═════════════════════════════════╗
        //║ Entra a la ventana de prácticas ║
        //╚═════════════════════════════════╝
        private void BtnPracticesMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            DlgPracticas dlgPracticas = new DlgPracticas();
            dlgPracticas.Show();

        }
        #endregion

        #region Configuración
        //╔═════════════════════════════════════╗
        //║ Entra a la barra de configuraciones ║
        //╚═════════════════════════════════════╝
        private void BtnToolsMenu_Click(object sender, EventArgs e)
        {
            if (SubMenuTool == false)
            {
                PnlToolsMenu.Visible = true;
                SubMenuTool = true;
            }
            else
            {
                PnlToolsMenu.Visible = false;
                SubMenuTool = false;
            }
        }

        //╔═════════════════╗
        //║ Menú modo claro ║
        //╚═════════════════╝
        private void BtnToolsLightMenu_Click(object sender, EventArgs e)
        {
            ChangeColorTheme(0);
        }

        //╔══════════════════╗
        //║ Menú modo oscuro ║
        //╚══════════════════╝
        private void BtnToolsDarkMenu_Click(object sender, EventArgs e)
        {
            ChangeColorTheme(1);
        }

        //╔═══════════════════╗
        //║ Menú modo moderno ║
        //╚═══════════════════╝
        private void BtnToolsModernMenu_Click(object sender, EventArgs e)
        {
            ChangeColorTheme(2);
        }
        #endregion

        #region Ayuda
        //╔═══════════════════════════╗
        //║ Entra a la barra de ayuda ║
        //╚═══════════════════════════╝
        private void BtnHelpMenu_Click(object sender, EventArgs e)
        {
            if (SubMenuHelp == false)
            {
                PnlHelpMenu.Visible = true;
                SubMenuHelp = true;
            }
            else
            {
                PnlHelpMenu.Visible = false;
                SubMenuHelp = false;
            }
        }

        //╔════════════════════════════╗
        //║ Entra al manual de usuario ║
        //╚════════════════════════════╝
        private void BtnHelpManualMenu_Click(object sender, EventArgs e)
        {

        }

        //╔══════════════════════════════════╗
        //║ Entra a la información acerca de ║
        //╚══════════════════════════════════╝
        private void BtnHelpAboutMenu_Click(object sender, EventArgs e)
        {

        }

        #endregion

        //╔════════════════════════════════════════════╗
        //║ Nota sobre la elaboración de este proyecto ║
        //╚════════════════════════════════════════════╝
        private void BtnMoreInfoMenu_Click(object sender, EventArgs e)
        {
            DlgMoreInfoMenu dlgMoreInfoMenu = new DlgMoreInfoMenu();
            dlgMoreInfoMenu.ShowDialog();
        }

        //╔═════════════════════════════════════════════════╗
        //║ Cambia el color de los componetes de la ventana ║
        //╚═════════════════════════════════════════════════╝
        public void ChangeColorTheme(int CodeColor)
        {
            Color Background;
            Color Letters;
            Color ButtonsBackground;
            Color SubMenuBackground;
            switch (CodeColor)
            {
                case 0:
                    //Definición de colores y recursos
                    Background = Color.FromArgb(255, 255, 255);
                    Letters = Color.FromArgb(17, 16, 29);
                    ButtonsBackground = Color.FromArgb(33, 105, 246);
                    SubMenuBackground = Color.FromArgb(255, 255, 255);
                    PtbLogoMenu.BackgroundImage = Properties.Resources.icons8_forward_64px_1;
                    //Asignación a componentes
                    this.BackColor = Background;
                    BtnPracticesMenu.ForeColor = Letters;
                    BtnToolsMenu.ForeColor = Letters;
                    BtnToolsLightMenu.ForeColor = Letters;
                    BtnToolsLightMenu.BackColor = ButtonsBackground;
                    BtnToolsDarkMenu.ForeColor = Letters;
                    BtnToolsDarkMenu.BackColor = ButtonsBackground;
                    BtnToolsModernMenu.ForeColor = Letters;
                    BtnToolsModernMenu.BackColor = ButtonsBackground;
                    PnlToolsMenu.BackColor = SubMenuBackground;
                    BtnHelpMenu.ForeColor = Letters;
                    BtnHelpManualMenu.ForeColor = Letters;
                    BtnHelpManualMenu.BackColor = ButtonsBackground;
                    BtnHelpAboutMenu.ForeColor = Letters;
                    BtnHelpAboutMenu.BackColor = ButtonsBackground;
                    PnlHelpMenu.BackColor = SubMenuBackground;
                    CCPtbProfileMenu.BorderColor = Color.RoyalBlue;
                    CCPtbProfileMenu.BorderColor2 = Color.RoyalBlue;
                    LblProfileMenu.ForeColor = Color.RoyalBlue;
                    this.CodeColor = CodeColor;
                    //Almacenamiento de colores para uso en DlgPracticas
                    Properties.Settings.Default.BackColor = Background;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.ButtonsBackColor = ButtonsBackground;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.SubMenusBackColor = SubMenuBackground;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.LettersForeColor = Letters;
                    Properties.Settings.Default.Save();
                    break;

                case 1:
                    //Definición de colores y recursos
                    Background = Color.FromArgb(17, 16, 29);
                    Letters = Color.FromArgb(255, 255, 255);
                    ButtonsBackground = Color.FromArgb(17, 16, 40);
                    SubMenuBackground = Color.FromArgb(17, 16, 29);
                    PtbLogoMenu.BackgroundImage = Properties.Resources.icons8_forward_64px_1;
                    //Asignación a componentes
                    this.BackColor = Background;
                    BtnPracticesMenu.ForeColor = Letters;
                    BtnToolsMenu.ForeColor = Letters;
                    BtnToolsLightMenu.ForeColor = Letters;
                    BtnToolsLightMenu.BackColor = ButtonsBackground;
                    BtnToolsDarkMenu.ForeColor = Letters;
                    BtnToolsDarkMenu.BackColor = ButtonsBackground;
                    BtnToolsModernMenu.ForeColor = Letters;
                    BtnToolsModernMenu.BackColor = ButtonsBackground;
                    PnlToolsMenu.BackColor = SubMenuBackground;
                    BtnHelpMenu.ForeColor = Letters;
                    BtnHelpManualMenu.ForeColor = Letters;
                    BtnHelpManualMenu.BackColor = ButtonsBackground;
                    BtnHelpAboutMenu.ForeColor = Letters;
                    BtnHelpAboutMenu.BackColor = ButtonsBackground;
                    PnlHelpMenu.BackColor = SubMenuBackground;
                    CCPtbProfileMenu.BorderColor = Color.RoyalBlue;
                    CCPtbProfileMenu.BorderColor2 = Color.RoyalBlue;
                    LblProfileMenu.ForeColor = Color.RoyalBlue;
                    this.CodeColor = CodeColor;
                    //Almacenamiento de colores para uso en DlgPracticas
                    Properties.Settings.Default.BackColor = Background;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.ButtonsBackColor = ButtonsBackground;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.SubMenusBackColor = SubMenuBackground;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.LettersForeColor = Letters;
                    Properties.Settings.Default.Save();
                    break;
                case 2:
                    //Definición de colores y recursos
                    Background = Color.FromArgb(47, 73, 208);
                    Letters = Color.FromArgb(255, 255, 255);
                    ButtonsBackground = Color.FromArgb(26, 43, 130);
                    SubMenuBackground = Color.FromArgb(47, 73, 208);
                    PtbLogoMenu.BackgroundImage = Properties.Resources.icons8_forward_64px;
                    //Asignación a componentes
                    this.BackColor = Background;
                    BtnPracticesMenu.ForeColor = Letters;
                    BtnToolsMenu.ForeColor = Letters;
                    BtnToolsLightMenu.ForeColor = Letters;
                    BtnToolsLightMenu.BackColor = ButtonsBackground;
                    BtnToolsDarkMenu.ForeColor = Letters;
                    BtnToolsDarkMenu.BackColor = ButtonsBackground;
                    BtnToolsModernMenu.ForeColor = Letters;
                    BtnToolsModernMenu.BackColor = ButtonsBackground;
                    PnlToolsMenu.BackColor = SubMenuBackground;
                    BtnHelpMenu.ForeColor = Letters;
                    BtnHelpManualMenu.ForeColor = Letters;
                    BtnHelpManualMenu.BackColor = ButtonsBackground;
                    BtnHelpAboutMenu.ForeColor = Letters;
                    BtnHelpAboutMenu.BackColor = ButtonsBackground;
                    PnlHelpMenu.BackColor = SubMenuBackground;
                    CCPtbProfileMenu.BorderColor = Letters;
                    CCPtbProfileMenu.BorderColor2 = Letters;
                    LblProfileMenu.ForeColor = Letters;
                    this.CodeColor = CodeColor;
                    //Almacenamiento de colores para uso en DlgPracticas
                    Properties.Settings.Default.BackColor = Background;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.ButtonsBackColor = ButtonsBackground;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.SubMenusBackColor = SubMenuBackground;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.LettersForeColor = Letters;
                    Properties.Settings.Default.Save();
                    break;
            }
        }
    }
}