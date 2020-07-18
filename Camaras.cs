using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Camaras : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }



        //Metodos
        public new string Prender()
        {
            return $"La camara {Id} {Marca} {Modelo} {base.Prender()}";
        }
        public string Fotografiar()
        {
            return "";
        }

        public string Grabar()
        {
            return "";
        }
        //Constructor
        public Camaras() : base()
        {
        }
        public new string Apagar()
        {
            return $"La camara {Id} {Marca} {Modelo} {base.Apagar()}";

        }
    }
}
