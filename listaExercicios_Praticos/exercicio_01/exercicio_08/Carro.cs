using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_08
{
    public class Carro
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double CapacidadeDoTanque { get; set; }

        public string TipoDeCombustivel { get; set; }

        public void Abastecer(double litrosCombustivel, string tipo)
        {
            if (litrosCombustivel <= CapacidadeDoTanque && (tipo.ToUpper() == TipoDeCombustivel.ToUpper() || TipoDeCombustivel.ToUpper() == "FLEX"))
            {
                Console.WriteLine("Abastecendo carro, aguarde!");

                double precoCombustivel = 0.00;
                double valorAPagar = litrosCombustivel * precoCombustivel;

                if(tipo == "gasolina")
                {
                    precoCombustivel = 5.62;
                    
                }
                else
                {
                    precoCombustivel = 4.16;
                }
                valorAPagar = litrosCombustivel * precoCombustivel;
                Console.WriteLine("Carro modelo:" + Modelo + "\nValor a pagar:"+ valorAPagar);
            }
            else
            {
                Console.WriteLine($"Carro:{Modelo}\nSolicitação incompatível com as permissões do veiculo");
            }
        }
    }
}
