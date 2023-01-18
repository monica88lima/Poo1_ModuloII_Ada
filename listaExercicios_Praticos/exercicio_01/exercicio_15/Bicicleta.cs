using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_15
{
    public class Bicicleta:Veiculo
    {
        //(infantil: true/false - tem que ter mais que 2 rodas)

        public bool Infantil { get; set; }

        public Bicicleta(int rodas, bool usaCombustivel, string classificacaoBike) : base(rodas, usaCombustivel)
        {
            VerificarBicicleta(classificacaoBike, rodas);
        }

        private void VerificarBicicleta(string tipo, int rodas)
        {
            if(tipo.ToUpper() =="INFANTIL"&& rodas >2)
            {
                Infantil = true;
            }
            else
            {
                
                Infantil = false;
            }
        }
    }
}
