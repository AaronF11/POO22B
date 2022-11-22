using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace POO22B_FPA.src.Class.P10
{
    //---------------------------------------------------------------------
    //Clase que envia alertas por SMS.
    //FPA. 02/11/2022.
    //---------------------------------------------------------------------
    public class CAlertas
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //Atributos de almacenamiento de respuestas:
        List<string> Mensajes;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CAlertas()
        {
            //Inicializa los atributos de almacenamiento de respuestas.
            Mensajes = new List<string>
            {
                "Sesión iniciada",
                "Nueva cuenta creada",
                "Inserción",
                "Actualización",
                "Eliminación"
            };
        }

        //---------------------------------------------------------------------
        //Envia un SMS de la acción ejecutada en el programa.
        //---------------------------------------------------------------------
        public void SMS(int Mensaje)
        {
            //var accountSid = "ACf7f398b17e15b4bf54a7ead081169300";
            //var authToken = "1954db3b42d375d34119574216a8d0de";
            //TwilioClient.Init(accountSid, authToken);

            //var messageOptions = new CreateMessageOptions(
            //    new PhoneNumber("+523223624573"));
            //messageOptions.MessagingServiceSid = "MG91c2ff2b6cb60b30b461078c90571b13";
            //messageOptions.Body = $"Operación .- {Mensaje} - {Mensajes[Mensaje]}";

            //MessageResource.Create(messageOptions);
        }

        //---------------------------------------------------------------------
        //Envia un SMS de la acción y la persona ejecutada en el programa.
        //---------------------------------------------------------------------
        public void SMS(int Mensaje, string Persona)
        {
            //var accountSid = "ACf7f398b17e15b4bf54a7ead081169300";
            //var authToken = "1954db3b42d375d34119574216a8d0de";
            //TwilioClient.Init(accountSid, authToken);

            //var messageOptions = new CreateMessageOptions(
            //    new PhoneNumber("+523223624573"));
            //messageOptions.MessagingServiceSid = "MG91c2ff2b6cb60b30b461078c90571b13";
            //messageOptions.Body = $"Operación .- {Mensaje} - {Mensajes[Mensaje]} por {Persona}";

            //MessageResource.Create(messageOptions);
        }

        //---------------------------------------------------------------------
        //Envia un SMS de la acción sobre la tabla manipulada
        //y ejecutada en el programa.
        //---------------------------------------------------------------------
        public void SMS(string Tabla, int Mensaje)
        {
            //var accountSid = "ACf7f398b17e15b4bf54a7ead081169300";
            //var authToken = "1954db3b42d375d34119574216a8d0de";
            //TwilioClient.Init(accountSid, authToken);

            //var messageOptions = new CreateMessageOptions(
            //    new PhoneNumber("+523223624573"));
            //messageOptions.MessagingServiceSid = "MG91c2ff2b6cb60b30b461078c90571b13";
            //messageOptions.Body = $"Operación .- {Mensaje} - {Mensajes[Mensaje]} en tabla {Tabla}";

            //MessageResource.Create(messageOptions);
        }
    }
}
