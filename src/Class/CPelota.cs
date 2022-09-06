using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO22B_FPA
{
    //---------------------------------------------------------------------
    //Clase que representa una pelota.
    //FPA. 18/08/2022.
    //---------------------------------------------------------------------
    public class CPelota
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private int Libras;
        private double Diametro;
        private int Tipo;
        private string Material;
        private string PaisOrigen;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CPelota(double Diametro, int Tipo, string Material, string PaisOrigen)
        {
            Libras = 0;
            this.Diametro = Diametro;
            this.Tipo = Tipo;
            this.Material = Material;
            this.PaisOrigen = PaisOrigen;
        }

        //---------------------------------------------------------------------
        //Infla la pelota.
        //---------------------------------------------------------------------
        public CError Inflar(int Libras)
        {
            bool Ponchada = true;

            if (Libras > 6)
            {
                return new CError(4, 2);
                //return new CError(2, "Fuga detectada");
            }
            else
            {
                //TODO: Algoritmo de inflado.

                this.Libras = Libras;

                if (Ponchada)
                {
                    return new CError(2, 2);
                }
                else
                {
                    return new CError(0, 2);
                }
            }
        }
    }
}
