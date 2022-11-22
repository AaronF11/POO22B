using POO22B_FPA.src.Class.P4.SubsCAnimal;
using POO22B_FPA.src.Class.P4;
using POO22B_FPA.src.Class;
using POO22B_FPA.src.Class.P5;
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
using Bunifu.Framework.Lib;
using System.Drawing.Imaging;

namespace POO22B_FPA.src.DlgsPracticas.P5
{
    //---------------------------------------------------------------------
    //Clase que representa el diálogo de figuras.
    //FPA. 25/08/2022.
    //---------------------------------------------------------------------
    public partial class DlgFiguras : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        Bitmap Lienzo;
        Graphics Graficos;
        bool Pintar = false;
        Point x, y;
        int Indice;
        int X, Y, SX, SY, CX, CY;
        Color Color;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgFiguras()
        {
            InitializeComponent();
            Lienzo = new Bitmap(PtbContenedor.Width, PtbContenedor.Height);
            Graficos = Graphics.FromImage(Lienzo);
            Graficos.Clear(PtbContenedor.BackColor);
            PtbContenedor.Image = Lienzo;
        }

        //---------------------------------------------------------------------
        //Permite dibujar cuando haces el mouse hacia abajo.
        //---------------------------------------------------------------------
        private void PtbContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            Pintar = true;
            y = e.Location;

            CX = e.X;
            CY = e.Y;
        }

        //---------------------------------------------------------------------
        //Dibuja la opcion seleccionada.
        //---------------------------------------------------------------------
        private void PtbContenedor_MouseMove(object sender, MouseEventArgs e)
        {
            if (Pintar)
            {
                if (Indice == 1)
                {
                    x = e.Location;
                    CLinea Linea = new CLinea(PtbContenedor, Graficos, x, y, CX, CY, X, Y, Color);
                    Linea.Dibujar(1);
                    y = x;
                }
                if (Indice == 2)
                {
                    x = e.Location;
                    CLinea Linea = new CLinea(PtbContenedor, Graficos, x, y, CX, CY, X, Y, Color);
                    Linea.Borrar();
                    y = x;
                }
            }
            PtbContenedor.Refresh();

            X = e.X;
            Y = e.Y;
            SX = e.X - CX;
            SY = e.Y - CY;
        }

        //---------------------------------------------------------------------
        //Desactiva el seguir pintando.
        //---------------------------------------------------------------------
        private void PtbContenedor_MouseUp(object sender, MouseEventArgs e)
        {
            Pintar = false;

            SX = X - CX;
            SY = Y - CY;

            if (Indice == 3)
            {
                CElipse Elipse = new CElipse(Graficos, CX, CY, SX, SY, Color);
                Elipse.Dibujar();
            }
            if (Indice == 4)
            {
                CCuadrilatero Cuadrilatero = new CCuadrilatero(Graficos, CX, CY, SX, SY, Color);
                Cuadrilatero.Dibujar();
            }
            if (Indice == 5)
            {
                CLinea Linea = new CLinea(PtbContenedor, Graficos, x, y, CX, CY, X, Y, Color);
                Linea.Dibujar(2);
            }
        }

        //---------------------------------------------------------------------
        //Remoldea la figura.
        //---------------------------------------------------------------------
        private void PtbContenedor_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graficos = e.Graphics;

            if (Pintar)
            {
                if (Indice == 3)
                {
                    CElipse Elipse = new CElipse(Graficos, CX, CY, SX, SY, Color);
                    Elipse.Dibujar();
                }
                if (Indice == 4)
                {
                    CCuadrilatero Cuadrilatero = new CCuadrilatero(Graficos, CX, CY, SX, SY, Color);
                    Cuadrilatero.Dibujar();
                }
                if (Indice == 5)
                {
                    CLinea Linea = new CLinea(PtbContenedor, Graficos, x, y, CX, CY, X, Y, Color);
                    Linea.Dibujar(2);
                }
            }
        }

        //---------------------------------------------------------------------
        //Limpia el area de dibujo.
        //---------------------------------------------------------------------
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Graficos.Clear(Color.White);
            PtbContenedor.Image = Lienzo;
            Indice = 0;
        }

        //---------------------------------------------------------------------
        //Dibuja lineas como un lapiz.
        //---------------------------------------------------------------------
        private void BtnLapiz_Click(object sender, EventArgs e)
        {
            Indice = 1;
        }

        //---------------------------------------------------------------------
        //Borra los trazos como una goma.
        //---------------------------------------------------------------------
        private void BtnBorrador_Click(object sender, EventArgs e)
        {
            Indice = 2;
        }

        //---------------------------------------------------------------------
        //Dibuja un elipse.
        //---------------------------------------------------------------------
        private void BtnElipse_Click(object sender, EventArgs e)
        {
            Indice = 3;
        }

        //---------------------------------------------------------------------
        //Dibuja un cuadrilatero.
        //---------------------------------------------------------------------
        private void BtnCuadrilatero_Click(object sender, EventArgs e)
        {
            Indice = 4;
        }

        //---------------------------------------------------------------------
        //Dibuja una linea recta.
        //---------------------------------------------------------------------
        private void BtnLinea_Click(object sender, EventArgs e)
        {
            Indice = 5;
        }

        //---------------------------------------------------------------------
        //Abre el dlg de colores.
        //---------------------------------------------------------------------
        private void BtnColores_Click(object sender, EventArgs e)
        {
            CdBordes.ShowDialog();
            Color = CdBordes.Color;
            BtnColorSeleccionado.BackColor = CdBordes.Color;
        }

        //---------------------------------------------------------------------
        //Metodo para calcular el color en la paleta de colores.
        //---------------------------------------------------------------------
        static Point Set_Point(PictureBox Ptb, Point Pt)
        {
            float x = 1f * Ptb.Width / Ptb.Width;
            float y = 1f * Ptb.Height / Ptb.Height;
            return new Point((int)(Pt.X * x), (int)(Pt.Y * y));
        }

        //---------------------------------------------------------------------
        //Selecciona el color en la paleta de colores.
        //---------------------------------------------------------------------
        private void PtbPaletaColores_MouseClick(object sender, MouseEventArgs e)
        {
            Point Punto = Set_Point(PtbPaletaColores, e.Location);
            Color = ((Bitmap)PtbPaletaColores.Image).GetPixel(Punto.X, Punto.Y);
            BtnColorSeleccionado.BackColor = Color;
        }

        //---------------------------------------------------------------------
        //Valida los colores antes y despues.
        //---------------------------------------------------------------------
        private void Validar(Bitmap Bitmap, Stack<Point> SP, int x, int y, Color Antes, Color Ahora)
        {
            Color CX = Bitmap.GetPixel(x, y);
            if (CX == Antes)
            {
                SP.Push(new Point(x, y));
                Bitmap.SetPixel(x, y, Ahora);
            }
        }

        //---------------------------------------------------------------------
        //Metodo para rellenar figuras.
        //---------------------------------------------------------------------
        public void Rellenar(Bitmap Bitmap, int x, int y, Color Ahora)
        {
            Color Antes = Bitmap.GetPixel(x, y);
            Stack<Point> SP = new Stack<Point>();
            SP.Push(new Point(x, y));
            Bitmap.SetPixel(x, y, Ahora);
            if (Antes == Ahora) return;
            while (SP.Count > 0)
            {
                Point PT = (Point)SP.Pop();
                if (PT.X > 0 && PT.Y > 0 && PT.X < Bitmap.Width - 1 && PT.Y < Bitmap.Height - 1)
                {
                    Validar(Bitmap, SP, PT.X - 1, PT.Y, Antes, Ahora);
                    Validar(Bitmap, SP, PT.X, PT.Y - 1, Antes, Ahora);
                    Validar(Bitmap, SP, PT.X + 1, PT.Y, Antes, Ahora);
                    Validar(Bitmap, SP, PT.X, PT.Y + 1, Antes, Ahora);
                }
            }
        }

        //---------------------------------------------------------------------
        //Evento mouse_clic del contenedor.
        //---------------------------------------------------------------------
        private void PtbContenedor_MouseClick(object sender, MouseEventArgs e)
        {
            if (Indice == 7)
            {
                Point Punto = Set_Point(PtbContenedor, e.Location);
                Rellenar(Lienzo, Punto.X, Punto.Y, Color);
            }
        }

        //---------------------------------------------------------------------
        //Evento mouse_clic del contenedor.
        //---------------------------------------------------------------------
        private void BtnRellenar_Click(object sender, EventArgs e)
        {
            Indice = 7;
        }

        //---------------------------------------------------------------------
        //Botón para guardar imagen del dibujo.
        //---------------------------------------------------------------------
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var file = new SaveFileDialog();
            file.Filter = "Image(*.png)|*.png|(*.*|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Bitmap Bitmap = Lienzo.Clone(new Rectangle(0, 0, PtbContenedor.Width, PtbContenedor.Height), Lienzo.PixelFormat);
                Bitmap.Save(file.FileName, ImageFormat.Png);
            }
        }
    }
}
