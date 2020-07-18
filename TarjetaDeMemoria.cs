using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class TarjetaDeMemoria : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }


        public TarjetaDeMemoria() : base()
        {
        }

        public string Recibir()
        {
            return "";
        }

        public string Grabar()
        {
            return "";
        }


        public string Almacenar()
        {
            return "";
        }
    }
}


