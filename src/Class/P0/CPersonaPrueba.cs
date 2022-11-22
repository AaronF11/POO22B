using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO22B_FPA.src.Class
{
    //---------------------------------------------------------------------
    //Clase que representa una persona.
    //FPA. 30/08/2022.
    //---------------------------------------------------------------------
    public class CPersonaPrueba
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private string Nombre;
        private int Genero;
        private DateTime FechaNacimiento;
        private int Etnia;
        private string Nacionalidad;


        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CPersonaPrueba(int Genero, DateTime FechaNacimiento, string Nacionalidad)
        {
            Nombre = "";
            this.Genero = Genero;
            this.FechaNacimiento = FechaNacimiento;
            Etnia = 0;
            this.Nacionalidad = Nacionalidad;
        }

        //---------------------------------------------------------------------
        //Asigna el nombre de la persona.
        //---------------------------------------------------------------------
        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        //---------------------------------------------------------------------
        //Obtiene el nombre de la persona.
        //---------------------------------------------------------------------
        public string GetNombre()
        {
            return Nombre;
        }
    }
}
