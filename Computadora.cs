using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public  class Computadora : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public object NombreProducto { get; private set; }

        public Computadora() : base()
        {
        }


        //Metodos estaticos y sobre carga de metodos
        public override string Prender()
        {
            return $"La Computadora {this.NombreProducto}, {this.Modelo}, {this.Marca} está {base.Prender()}";
        }
        public static string Prender(string nombre)
        {
            return $"Los audifonos estan prendidos {nombre}";
        }
        //Metodos abtractos, y metodos selllados
        public virtual void Escribir(string nombre)
        {
        }

        public abstract class Teclado : Computadora
        {
            public abstract override void Escribir(string nombre);
        }

        public class F : Teclado
        {
            public override void Escribir(string nombre)
            {
            }
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

        public override string Apagar()
        {
            return $"Gracias, La Computadora {this.NombreProducto}, {this.Modelo}, {this.Marca} está {base.Apagar()}";
        }
        public static string Apagar(string nombre)
        {
            return $"La computadora estan apagados {nombre}";
        }
    }
}
