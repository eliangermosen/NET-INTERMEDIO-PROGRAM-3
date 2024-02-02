using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    internal class Dado
    {
        Random valorRandom = new Random();
        public Dado()
        {
            Valor = valorRandom.Next(1, 7);
        }

        private int Valor {  get; set; }
        public int Resultado
        {
            get { return Valor; }
        }
    }
}
