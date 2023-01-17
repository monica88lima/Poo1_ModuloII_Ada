using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_15
{
    public class Veiculo
    {
        //propriedades rodas (1 a n), usaCombustivel (true/false)
        public int Rodas { get; set; }
        public bool UsaCombustivel { get; set; }

        public Veiculo(int rodas, bool usaCombustivel)
        {
           ValidaRodas(rodas);

           UsaCombustivel = usaCombustivel;

            
        }

        public virtual void ValidaRodas(int qtdRodas)
        {
            if(qtdRodas < 1 )
            {
                Console.WriteLine("Quantidade de rodas invalida. Digite Novamente:");
                qtdRodas = int.Parse(Console.ReadLine());
                ValidaRodas(qtdRodas);
            }
            else
            {
                Rodas = qtdRodas;
            }

        }
    }
}
