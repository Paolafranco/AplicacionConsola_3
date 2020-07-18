﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public sealed class Impresora : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public object NombreProducto { get; private set; }

        public Impresora() : base()
        {
        }
        public override string Prender()
        {
            return $"{base.Prender()} {this.NombreProducto}{this.Modelo}{this.Marca}{base.Prender()}";
        }
        public static string Prender(string nombre)
        {
            return $"Los audifonos estan prendidos {nombre}";
        }
        public static string Imprimir()
        {
            return "";
        }

        public static string Escanear()
        {
            return "";
        }

        public static string Copiar()
        {
            return "";
        }

        public override string Apagar()
        {
            return $"{base.Apagar()} {this.NombreProducto}{this.Modelo}{this.Marca}{base.Apagar()}";
        }
        public static string Apagar(string nombre)
        {
            return $"Los audifonos estan apagados {nombre}";
        }
    }
}

