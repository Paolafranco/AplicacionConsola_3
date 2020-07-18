using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Impresora : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }


        public Impresora() : base()
        {
        }
        public new string Prender()
        {
            return $"La impresora {Id} {Marca} {Modelo} {base.Prender()}";

        }
        public string Imprimir()
        {
            return "";
        }

        public string Escanear()
        {
            return "";
        }

        public string Copiar()
        {
            return "";
        }
        
        public new string Apagar()
        {
            return $"La impresora {Id} {Marca} {Modelo} {base.Apagar()}";

        }
    }
}

