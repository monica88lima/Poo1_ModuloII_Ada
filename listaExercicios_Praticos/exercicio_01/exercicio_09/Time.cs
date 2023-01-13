using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_09
{
    public class Time
    {
        public string NomePais { get; set; }
        public string NomeTime { get; set; }
        public int PontuacaoTime { get; set; }
        public Time(string pais, string time, int pontos)
        {
            this.NomePais = pais;
            this.NomeTime = time;
            this.PontuacaoTime = pontos;
        }

        public void Pontuar(string status)
        {
            if (status.ToUpper() == "W")
            {
                PontuacaoTime += 3;
            }
            else if (status.ToUpper() == "L")
            {
                PontuacaoTime += 0;
            }
            else if (status.ToUpper() == "D")
            {
                PontuacaoTime += 1;

            }
            else
            {
                Console.WriteLine("Caracter inválido");
            }
        }
    }
}
