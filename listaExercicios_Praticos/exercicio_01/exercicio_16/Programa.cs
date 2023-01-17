using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_16
{
    public class Programa
    {
        //propriedades duracao e generos (ação, comédia, suspense, drama, terror)
        public int Duracao { get; set; }
        public string Genero { get; set; }

        public Programa(int minutos, string genero)
        {
            this.Duracao = minutos;
            ValidaEntradaGenero(genero);
        }

        public void ValidaEntradaGenero(string genero)
        {
            string[] generosFilme = new string[5] { "ação", "comédia", "suspense", "drama", "terror" };

            if (generosFilme.Contains(genero))
            {
                Genero = genero;
            }
            else
            {
                Console.WriteLine("Digite um genero valido:");
                genero = Console.ReadLine();
                ValidaEntradaGenero(genero);
            }
        }
    }
}
