using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class GeneradorProductosTecnologicos
    {
        readonly Random random = new Random();

        public int Id { get; set; }
        public GeneradorProductosTecnologicos()
        {
            Id = random.Next();
        }

        public GeneradorProductosTecnologicos(int identificar)
        {
            Id = identificar;
        }

        public GeneradorProductosTecnologicos(string identificarCadena)
        {
            Id = Convert.ToInt32(identificarCadena);
        }

        public string Prender()
        {
            return "está prendido";
        }

        public string Apagar()
        {
            return "está apagado";
        }
    }
}

