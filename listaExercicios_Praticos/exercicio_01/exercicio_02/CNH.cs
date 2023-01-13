using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02
{
    public class CNH
    {
        public string Pais { get; set; }
        public short Idade { get; set; }

        public CNH(short idade, string pais)
        {
            bool validar = ValidarIdade(pais, idade);
            if (validar)
            {
                this.Pais = pais;
                this.Idade = idade;
            }
            else
            {
                Console.WriteLine("Informação Incorreta");
            }


        }
        public CNH(short idade, string pais, string categoriaHabilitacao)
        {
            bool validar = ValidarIdade(pais, idade);
            validar = ValidarCategoriaHabilitacao(categoriaHabilitacao);

            if (validar)
            {
                this.Pais = pais;
                this.Idade = idade;
                
            }
            else
            {
                Console.WriteLine("Informação Incorreta");
            }

        }

        private bool ValidarCategoriaHabilitacao(string cat)
        {
            bool situacao;
            string[] categoriaHabilitacao = new string[] { "A", "B", "C", "D", "AB", "AC", "AD", "AE" };
            situacao = categoriaHabilitacao.Contains(cat);

            return situacao;


        }

        private bool ValidarIdade(string pais, short idade)
        {
            bool situacao;
            if (pais.ToUpper() == "US" || pais.ToUpper() == "CA")
            {
                if (idade >= 16)
                {
                    situacao = true;
                }
                else
                {
                    situacao = false;
                }
            }
            else if (pais.ToUpper() == "CH" || pais.ToUpper() == "RU")
            {
                if (idade >= 21)
                {
                    situacao = true;
                }
                else
                {
                    situacao = false;
                }
            }
            else if(pais.ToUpper() == "BR")
            {
                if (idade >= 18)
                {
                    Console.WriteLine("E necessario informar a categoria da habilitação:");
                    string categoriaHabilitacao = Console.ReadLine();
                    situacao = ValidarCategoriaHabilitacao(categoriaHabilitacao);
                    if (situacao)
                    {
                        situacao = true;
                    }
                    else
                    {
                        situacao = false;
                    }
                    
                }
                else
                {
                    situacao = false;
                }

            }
            else
            {
                if (idade >= 18)
                {
                    situacao = true;
                }
                else
                {
                    situacao = false;
                }

            }
            return situacao;

        }

    }
}
