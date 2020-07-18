using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class ProductosElectronicos : Mercancia
    {
    
    //Herencia
    public ProductosElectronicos() : base()
    {
        
    }
    public string Nombre { get; set; }

        //Metodos
        public string Encendido()
        {
            return $"Encendida";
        }
        public string Apagado()
        {
            return $"Apagado";
        }
    }
}
