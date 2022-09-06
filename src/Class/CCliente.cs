using POO22B_FPA.src.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO22B_FPA.src.Class
{
    //---------------------------------------------------------------------
    //Clase que representa una persona.
    //FPA. 01/09/22.
    //---------------------------------------------------------------------
    class CCliente : CPersona
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private string CodigoCliente;
        private double Saldo;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CCliente(int Genero, DateTime FechaNacimiento, string Nacionalidad, string codigoCliente)
            : base(Genero, FechaNacimiento, Nacionalidad)
        {
            this.CodigoCliente = codigoCliente;
            Saldo = 0;
        }

    }
}
