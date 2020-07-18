using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Parlantes : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }


        public new string Prender()
        {
            return $"Los parlantes {Id} {Marca} {Modelo} {base.Prender()}";
        }
        public string Escuchar()
        {
            return "";
        }
        public Parlantes() : base()
        {
        }
        public new string Apagar()
        {
            return $"Los parlantes {Id} {Marca} {Modelo} {base.Apagar()}";
        }


    }
}
