using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Mercancia : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NombreProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public Cliente Persona { get; set; }
        public ProductosElectronicos Productos { get; set; }
      


        public Mercancia() : base()
        {
        }
    }
}