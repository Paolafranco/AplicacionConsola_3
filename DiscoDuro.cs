using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
   
    public class DiscoDuro : GeneradorProductosTecnologicos
    {
        public string Modelo { get; set; }
        public string Memoria { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }


        public string Almacenar(string nombre)
        {
            return "";
        }

        public string GuardaInfor()
        {
            return "";
        }

        public string Registrar()
        {
            return "";
        }

        public string EliminaInfor()
        {
            return "";
        }

        public DiscoDuro() : base()
        {
        }
    }
}

