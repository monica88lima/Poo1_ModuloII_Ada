using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_01
{
    public class Boletim
    {
        public string  NomeAluno { get; set; }
        public int Ano { get; set; }
        public int Semestre { get; set; }
        public List<string> LstMedias { get; set; } = new List<string>();

        public Boletim(string nome, int ano, int semestre)
        {
            this.NomeAluno = nome;
            this.Ano= VerificarAno(ano);
            this.Semestre = VerificarSemestre(semestre);

        }
              

        private int VerificarAno(int ano)
        {
            if(ano <= 1964)
            {
                Console.WriteLine("Dado Inválido. Digite um ano Valido:");
                int.TryParse(Console.ReadLine(), out ano);
                return VerificarAno(ano);
            }
            else
            {
                ano = ano;
            }
            
            return ano;
        }

        private int VerificarSemestre(int semestre)
        {
            if (semestre < 1 || semestre > 14)
            {
                Console.WriteLine("Dado Inválido. Digite um semestre Valido:");
                int.TryParse(Console.ReadLine(), out semestre);
               return VerificarSemestre(semestre);
            }
            else
            {
                semestre = semestre;
            }
            
            return semestre;

        }

       
    }
}
