using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Computadora : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }


        public Computadora() : base()
        {
        }


        public new string Prender()
        {
            return $"La computadora {Id} {Marca} {Modelo} {base.Prender()}";
        }
        public string Escribir()
        {
            return "";
        }

        public string Guardar()
        {
            return "";
        }

        public string Eliminar()
        {
            return "";
        }

        public string Buscar()
        {
            return "";
        }

        public new string Apagar()
        {
            return $"La computadora {Id} {Marca} {Modelo} {base.Apagar()}";
        }
    }
}
