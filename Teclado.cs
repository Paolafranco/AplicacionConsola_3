using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Teclado : GeneradorProductosTecnologicos
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }



        public string Escribir()
        {
            return "Porfavor, Verifique si está bien el teclado, el Mouse y el disco duro";
        }

        public string Borrar()
        {
            return "Si, todo esta bien muchas gracias";
        }

        public string Enumerar()
        {
            return "";
        }

        public string CapturaPantalla()
        {
            return "";
        }
        public Teclado() : base()
        {
        }

    }
}
