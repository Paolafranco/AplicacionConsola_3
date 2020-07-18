using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Cliente : GeneradorProductosTecnologicos
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Cliente() : base()
        {

        }
        public Cliente(string nombre, string apellido) : base()
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        
        private Celular celular;
        public Celular Celular
        {
            get { return celular; }
            set
            {
                celular = value;
            }
        }
        

        private Computadora computadora;
        public Computadora Computadora
        {
            get { return computadora; }
            set
            {
                computadora = value;
            }
        }

        private Teclado teclado;
        public Teclado Teclado
        {
            get { return teclado; }
            set
            {
                teclado = value;
            }
        }
        private Mouse mouse;
        public Mouse Mouse
        {
            get { return mouse; }
            set
            {
                mouse = value;
            }
        }
        private DiscoDuro discoDuro;
        public DiscoDuro DiscoDuro
        {
            get { return discoDuro; }
            set
            {
                discoDuro = value;
            }
        }
        private TarjetaDeMemoria tarjetaDeMemoria;
        public TarjetaDeMemoria TarjetaDeMemoria
        {
            get { return tarjetaDeMemoria; }
            set
            {
                tarjetaDeMemoria = value;
            }
        }
        private Tablet tablet;
        public Tablet Tablet
        {
            get { return tablet; }
            set
            {
                tablet = value;
            }
        }
        private Parlantes parlantes;
        public Parlantes Parlantes
        {
            get { return parlantes; }
            set
            {
                parlantes = value;
            }
        }
        private Impresora impresora;
        public Impresora Impresora
        {
            get { return impresora; }
            set
            {
                impresora = value;
            }
        }
        private Camaras camaras;
        public Camaras Camaras
        {
            get { return camaras; }
            set
            {
                camaras = value;
            }
        }
        private Audifonos audifonos;
        public Audifonos Audifonos
        {
            get { return audifonos; }
            set
            {
                audifonos = value;
            }
        }


        //Metodos
        public string Saludar(Cliente comprador)
        {
            return $"Hola, me llamo {Nombre} {Apellido} soy tu ascesora.";
        }
        public string OfrecerProductos(Cliente comprador)
        {
            return $"Gracias, {Nombre} {Apellido} en que le puedo ayudar?";
        }
        public string PedirProducto(string nombreVendedor, string prodcutoSeleccionado)
        {
            return $"Discuple {nombreVendedor} la seccion de {prodcutoSeleccionado} ";
        }
        public string IndicarCelL()
        {
            return $"Un {Celular.Modelo} y su id es {Celular.Id}";
        }
       
        public string IndicarTablet()
        {
            return $"Una {Tablet.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarParlantes()
        {
            return $"Una {Parlantes.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarImpresora()
        {
            return $"Una {Impresora.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarCamaras()
        {
            return $"Una {Camaras.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarAudifonos()
        {
            return $"Una {Audifonos.Modelo} y su id es {Computadora.Id}";
        }
        public string PagarProducto(decimal dinero, decimal ValorTotal)
        {
            var resta = dinero - ValorTotal;

            return $"Pago Exitoso - Su cambio es : {resta}";
        }

        internal string Pedir(string personaApedir, ProductosElectronicos electronicos)
        {
            throw new NotImplementedException();
        }
    }
}
    


