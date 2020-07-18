using System;

namespace AplicacionDeber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a Tecnologías Franco");
            //Instancias Cliente
            var empresa = new Empresa();
            
            Cliente vendedor = new Cliente
            {
                Nombre = "Paola",
                Apellido = "Franco"

            };
            //1ra Forma Comprador-Cliente
            var comprador = new Cliente("Andrea", "Franco")
            {
                Celular = empresa.RealizarCell("Xiaomi")
            };
            var comprador2 = new Cliente("Cecilia", "Franco")
            {
                Teclado = empresa.RealizarTeclado("Dell")
            };

            comprador.Computadora = empresa.RealizarCompu("Asus", "VivoBook S510", 900);
            comprador.Mouse = empresa.RealizarMouse("GT", "Karakoram", 20);
            comprador.DiscoDuro = empresa.RealizarDiscoDuro("Asus", "3,5", 97);
            comprador.TarjetaDeMemoria = empresa.RealizarTarjetaDeMemoria("Toshiba", "M203", 25);
            comprador.Tablet = empresa.RealizarTablet("Huawei", "MediaPad T3", 400);
            comprador.Parlantes = empresa.RealizarParlantes("Bose Home", "Speaker 500", 30);
            comprador.Impresora = empresa.RealizarImpresora("Epson Workforce", "WF-2630WF", 400);
            comprador.Camaras = empresa.RealizarCamaras("Asus", "Epson Workforce", 40);
            comprador.Audifonos = empresa.RealizarAudifonos("Sony", "Noise cancelling WH-1000XM3", 349);
            
            ProductosElectronicos Electronicos = new ProductosElectronicos
            {
                Nombre = "Martin"
            };

            //2da forma agregar prodcutos
            Audifonos audifonos = new Audifonos()
            {
                Marca = "Sony",
                Modelo = "Noise cancelling WH-1000XM3",
                Precio = 349
            };
            Computadora computadora = new Computadora()
            {
                Marca = "Asus",
                Modelo = "VivoBook S510",
                Precio = 900
            };
            Celular celular = new Celular()
            {
                Marca = "Xiaomi",
                Modelo = "Readme 8a",
                Precio = 190
            };
            Camaras camaras = new Camaras()
            {
                Marca = "Asus",
                Modelo = "Epson Workforce",
                Precio = 40
            };
            DiscoDuro discoDuro = new DiscoDuro()
            {
                Marca = "Asus",
                Modelo = "3,5",
                Precio = 97
            };
            Impresora impresora = new Impresora()
            {
                Marca = "Epson Workforce",
                Modelo = "WF-2630WF",
                Precio = 400
            };
            Mouse mouse = new Mouse()
            {
                Marca = "GT",
                Modelo = "Karakoram",
                Precio = 20
            };
            Parlantes parlante = new Parlantes()
            {
                Marca = "Bose Home",
                Modelo = "Speaker 500",
                Precio = 30
            };
            Tablet tablet = new Tablet()
            {
                Marca = "Epson Workforce",
                Modelo = "WF-2630WF",
                Precio = 400
            };
            TarjetaDeMemoria tarjetaDeMemoria = new TarjetaDeMemoria()
            {
                Marca = "Toshiba",
                Modelo = "M203",
                Precio = 25
            };
            Teclado teclado = new Teclado()
            {
                Marca = "Dell",
                Precio = 50
            };



            //Consola
            Console.WriteLine(vendedor.Saludar(comprador));
            Console.WriteLine("Ingresa tu nombre y apellido: ");
            Console.ReadLine();
            Console.WriteLine(vendedor.OfrecerProductos(comprador));

            Console.WriteLine("Gracias, tu compra es: ");
            string cliente = vendedor.Nombre;
            string pedir = comprador.Pedir(cliente, Electronicos);
            Console.WriteLine(pedir);

            string cell = celular.Prender();
            Console.WriteLine($"{comprador.Nombre} {cell}");
            Console.WriteLine(celular.Prender());
            Console.WriteLine(celular.Apagar());

            Console.WriteLine(comprador.IndicarCelL());
            Console.WriteLine(comprador.IndicarTablet());
            Console.WriteLine(comprador.IndicarParlantes());
            Console.WriteLine(comprador.IndicarImpresora());
            Console.WriteLine(comprador.IndicarCamaras());
            Console.WriteLine(comprador.IndicarAudifonos());

            Console.ReadKey();
        }
    }
}


/*Mercancia
Mercancia mercancia= new Mercancia
{
    Marca = "",
    Modelo = "",
};

//Computadora
Computadora computadora = new Computadora
{
    Marca = "Asus",
    Modelo = "VivoBook S510",
    Precio = 800
};

Computadora compradorCompu = new Computadora
{
    Marca = "Asus",
    Modelo = "VivoBook S510",
    Precio = 800
};

mercancia.Computador = compradorCompu;
string prenderCompu = compradorCompu.Prender();
string escribirtext = compradorCompu.Escribir();
string guardarInfo = compradorCompu.Guardar();
string eliminarInfo = compradorCompu.Eliminar();
string BuscarInfo = compradorCompu.Buscar();
string apagarCompu = compradorCompu.Apagar();


//Teclado
Teclado compradorTeclado = new Teclado
{
    Modelo = "Rectangular",
    Precio = 30,
};

mercancia.Cliente = compradorTeclado;
string mensaje1 = "Teclado";
string saludo1 = compradorTeclado.Escribir(mensaje1);
string catalogoTeclado = compradorTeclado.Borrar();
string confirmar1 = compradorTeclado.Enumerar();
string guardar1 = compradorTeclado.CapturaPantalla();


//Mouse
Mouse compradormouse = new Mouse
{
    Modelo = "Rectangular",
    Precio = 12,
};

mercancia.Clientes = compradormouse;
string mensaje2 = "Mouse";
string saludo2 = compradormouse.MoverIzquierdo(mensaje2);
string catalogoMouse = compradormouse.MoverDerecho();
string confirmar2 = compradormouse.Subir();
string guardar2 = compradormouse.Bajar();


//Discoduro
DiscoDuro compradorDisco = new DiscoDuro
{
    Modelo = "3,5",
    Marca = "",
    Memoria = "64 GB",
    Precio = 97
};

mercancia.Compras = compradorDisco;
string mensaje3 = "Disco Duro";
string saludo3 = compradorDisco.Almacenar(mensaje3);
string catalogoDisco = compradorDisco.GuardaInfor();
string confirmar3 = compradorDisco.Registrar();
string guardar3 = compradorDisco.EliminaInfor();


//cliente
Cliente comprador = new Cliente
{
    Nombre = nombre,
    Apellido = "apellido",

};

mercancia.Propietarios = comprador;
string mensaje = "Paola";
string saludo = comprador.Saludar(mensaje);
string catalogoCompu = comprador.Comprar();
string confirmar = comprador.Confirmar();
string guardar = comprador.Guardar();


//Tarjeta de memoria
TarjetaDeMemoria compradorTarjeta = new TarjetaDeMemoria
{
    Id = new Random().Next(),
    Marca = "Toshiba",
    Modelo = "M203",
    Precio = 25
};

mercancia.Tarjeta = compradorTarjeta;
string resiveInfor = compradorTarjeta.Recibir();
string grabaInfor = compradorTarjeta.Grabar();
string almacenaInfor = compradorTarjeta.Almacenar();


//Celular
Celular compradorCelular = new Celular
{
    Id = new Random().Next(),
    Marca = "Xiaomi",
    Modelo = "Readme 8a",
    Color = "Negro",
    Precio = 185
};

mercancia.Celulares = compradorCelular;
string escribirTexto = compradorCelular.Escribir();
string llamar = compradorCelular.LLamar();
string colgar = compradorCelular.Colgar();
string guardarTexto = compradorCelular.Guardar();
string jugar = compradorCelular.Jugar();
string eliminarTexto = compradorCelular.Eliminar();


//Tablet
Tablet compradorTablet = new Tablet
{
    Marca = "Huawei",
    Modelo = "MediaPad T3",
    Color = "Blanca",
    Precio = 400
};

mercancia.Tablets = compradorTablet;
string prender = compradorTablet.Prender();
string escribirTex = compradorTablet.Escribir();
string guardarTex = compradorTablet.Guardar();
string jugaar = compradorTablet.Jugar();
string eliminarTex = compradorTablet.Eliminar();
string llamarT = compradorTablet.LLamar();
string contestar = compradorTablet.Contestar();
string colgarT = compradorTablet.Colgar();
string apagarT = compradorTablet.Apagar();


//Parlantes
Parlantes compradorParlantes = new Parlantes
{
    Marca = "Bose Home",
    Modelo = "Speaker 500",
    Precio = 30
};

mercancia.Parlante = compradorParlantes;
string escuchar = compradorParlantes.Escuchar();
string prenderP = compradorParlantes.Prender();
string apagar = compradorParlantes.Apagar();


//Impresora
Impresora compradorImpresora = new Impresora
{
    Marca = "Epson Workforce",
    Modelo = "WF-2630WF",
    Precio = 900
};

mercancia.Impresoras = compradorImpresora;
string imprimir = compradorImpresora.Imprimir();
string escanear = compradorImpresora.Escanear();
string copiar = compradorImpresora.Copiar();


//Camara
Camaras compradorCamara = new Camaras
{
    Id = new Random().Next(),
    Marca = "Epson Workforce",
    Modelo = "WF-2630WF",
    Precio = 900
};

mercancia.Camara = compradorCamara;
string prenderC = compradorCamara.Prender();
string fotos = compradorCamara.Fotografiar();
string grabar = compradorCamara.Grabar();
string apagarC = compradorCamara.Apagar();


//Audifonos
Audifonos compradorAudifono = new Audifonos
{
    Marca = "Epson Workforce",
    Precio = 900
};

mercancia.Audifono = compradorAudifono;
string contestarA = compradorAudifono.Contestar();
string escucharA = compradorAudifono.Escuchar();
string subirVolumen = compradorAudifono.SubirVolumen();
string bajarVolumen = compradorAudifono.BajarVolumen();
string colgarA = compradorAudifono.Colgar();

//Empresa
Empresa compradorEmpresa = new Empresa
{
    Nombre = nombre,
};

mercancia.Empresas = compradorEmpresa;*/
