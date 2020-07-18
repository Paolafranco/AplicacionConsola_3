using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Tablet : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }



        public new string Prender()
        {
            return $"La tablet {Id} {Marca} {Modelo} {base.Prender()}";
        }
        public string Escribir()
        {
            return "";
        }
        public string Guardar()
        {
            return "";
        }

        public string Jugar()
        {
            return "";
        }

        public string Eliminar()
        {
            return "";
        }

        public string LLamar()
        {
            return "";
        }

        public string Contestar()
        {
            return "";
        }

        public string Colgar()
        {
            return "";
        }
        public Tablet() : base()
        {
        }
        public new string Apagar()
        {
            return $"La tablet {Id} {Marca} {Modelo} {base.Apagar()}";

        }

    }
}

