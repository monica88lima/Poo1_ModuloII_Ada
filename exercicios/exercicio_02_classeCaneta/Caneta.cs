using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02_classeCaneta
{
    internal class Caneta
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public Tipo tipo { get; set; }

        public enum Tipo
        {
            Esferografica,
            hidrografica,
        }
    }
}
 