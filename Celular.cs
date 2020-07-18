using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Celular : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public float Precio { get; set; }




        //Metodos
        public new string Prender()
        {
            return $"El celular {Id} {Marca} {Modelo} {base.Prender()}";
        }
        public string Escribir()
        {
            return "";
        }

        public string LLamar()
        {
            return "";
        }


        public string Colgar()
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

        public Celular() : base()
        {
        }
        public new string Apagar()
        {
            return $"El celular {Id} {Marca} {Modelo} está {base.Apagar()}";

        }
    }
}
