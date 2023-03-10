using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_03_classeTv
{
    class TV
    {
        public int canal;
        public int volume;
        public bool ligada;
        // CONSTRUTOR DA CLASSE
        public TV(string situacaoTv, int posicaoVolume, int posicaoCanal)
        {
            situacaoTv = situacaoTv.ToUpper();
            bool modoTv = situacaoTv == "LIGADA";


            if (!modoTv)
            {
                ligada = modoTv;
                canal = 0;
                volume = 0;
            }
            else
            {
                ligada = modoTv;
                canal = posicaoCanal;

                if(posicaoVolume> 100)
                {
                    volume = 100;
                }
                else if(posicaoVolume < 0)
                {
                    volume = 0;
                }
                else
                {
                    volume = posicaoVolume;
                }
                
            }
            

        }
        public void ValidaStatusTV()
        {
            if (!ligada)
                throw new Exception("Televisão está desligada, por favor, ligue-a!");
        }

        //Criar metodo - Liga/DesligaTV 
        public void Power(string LigaDesliga)
        {
            if (LigaDesliga.ToUpper() == "LIGA")
                ligada = true;
            else
                ligada = false;
        }


        //Criar metodo - MudaDeCanal
        public void MudaCanal(int canalNovo)
        {
            ValidaStatusTV();
            canal = canalNovo;
        }

        //Criar metodo - AumentaVolume
        public void AumentaVolume()
        {
            ValidaStatusTV();
            if(volume > 100)
            {
                volume = 100;
            }
            else
            volume++;
        }
        //Criar metodo - DiminuiVolume
        public void DiminuiuVolume()
        {
            ValidaStatusTV();
            if(volume < 0)
            {
                volume = 0;
            }
            else
            volume--;
        }







    }
}
