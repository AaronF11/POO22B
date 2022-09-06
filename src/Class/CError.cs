using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO22B_FPA
{
    //---------------------------------------------------------------------
    //Clase que representa un error.
    //FPA. 23/08/2022.
    //---------------------------------------------------------------------
    public class CError
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private int IDError;
        private int IDLanguage;
        private string Message;


        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CError(int IDError, int IDLanguage)
        {
            this.IDError = IDError;
            this.IDLanguage = IDLanguage;

        }

        //---------------------------------------------------------------------
        //Obtiene el código del error.
        //---------------------------------------------------------------------
        public int GetCode()
        {
            return IDError;
        }

        //---------------------------------------------------------------------
        //Obtiene el código del mensaje.
        //---------------------------------------------------------------------
        public int GetLanguage()
        {
            return IDLanguage;
        }

        //---------------------------------------------------------------------
        //Obtiene el código del mensaje.
        //---------------------------------------------------------------------
        public string GetMessage()
        {
            string Message = "";

            if (IDLanguage == 1)
            {
                switch (IDError)
                {
                    case 0:
                        Message = "Pelota inflada con éxito";//Exitoso
                        break;

                    case 1:
                        Message = "No se pudo inflar la pelota.";//Genérico
                        break;

                    case 2:
                        Message = "La pelota está ponchada.";//Espécifico 2
                        break;

                    case 3:
                        Message = "Válvula defectuosa";//Espécifico 3
                        break;

                    case 4:
                        Message = "Inflado excedido";//Espécifico 4
                        break;

                    default:
                        Message = "Ocurrió un error al intentar inflar la pelota";
                        break;
                }
            }

            if (IDLanguage == 2)
            {
                switch (IDError)
                {
                    case 0:
                        Message = "Successufully inflated ballon";//Exitoso
                        break;

                    case 1:
                        Message = "Can't inflate the ballon";//Genérico
                        break;

                    case 2:
                        Message = "Ball is struck out";//Espécifico 2
                        break;

                    case 3:
                        Message = "Defective valve";//Espécifico 3
                        break;

                    case 4:
                        Message = "Overinflated ballon";//Espécifico 4
                        break;

                    default:
                        Message = "An Error ocurred while trying to inflate the ballon";
                        break;
                }
            }

            return Message;
        }
    }
}
