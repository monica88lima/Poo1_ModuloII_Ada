using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_03_classePessoa_GettersESetters
{
    public class Pessoa
    {

        
        public string PrimeiroNome { get; set; }

        private string Sobrenome { get; set; }

        
        public string SobrenomePublico
        {
            get
            {
                return Sobrenome;
            }
            set
            {
                Sobrenome = value;

            }
        }


        private string NomeCompletoPrivado;



        public string NomeCompleto
        {
            get => NomeCompletoPrivado;

        }

        public void fnNomeCompleto(string PrimeiroNome, string SegundoNome)
        {
            NomeCompletoPrivado = PrimeiroNome + " " + SegundoNome;
        }



        public string Email { get; set; }


    }

}
