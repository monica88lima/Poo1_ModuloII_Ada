using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_15
{
    public class Carro: Veiculo
    {
        public string TipoCombustivel { get; set; }

        public Carro(int rodas, bool usaCombustivel, string TipoCombustivel): base(rodas, usaCombustivel)
        {
            ValidaCombustivel(TipoCombustivel);
            ValidaRodas(rodas);
            this.UsaCombustivel = usaCombustivel;
        }

        private void ValidaCombustivel(string tipoCombustivel)
        {
            if (tipoCombustivel.ToUpper() == "ALCOOL" || tipoCombustivel.ToUpper() == "GASOLINA" || tipoCombustivel.ToUpper() == "FLEX")
            {
                TipoCombustivel = tipoCombustivel;
            }
            else
            {
                Console.WriteLine("Combustivel invalido. Digite Novamente:");
                tipoCombustivel = (Console.ReadLine());
                ValidaCombustivel(tipoCombustivel);
            }

        }
        public override void ValidaRodas(int qtdRodas)
        {
            base.ValidaRodas(qtdRodas);
        }
        
    }
}
