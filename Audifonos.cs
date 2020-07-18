using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Audifonos : GeneradorProductosTecnologicos
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }

       
        public new string Prender()
        {
            return $"Los audifonos {Id} {Marca} {Modelo} {base.Prender()}";
        }
        //Metodos
        public string Contestar()
        {
            return "";
        }
        public string Escuchar()
        {
            return "";
        }

        public string Hablar()
        {
            return "";
        }

        public string SubirVolumen()
        {
            return "";
        }

        public string BajarVolumen()
        {
            return "";
        }

        public string Colgar()
        {
            return "";
        }
        public Audifonos() : base()
        {
        }
        public new string Apagar()
        {
            return $"Los audifonos {Id} {Marca} {Modelo} {base.Apagar()}";
        }

    }
}


