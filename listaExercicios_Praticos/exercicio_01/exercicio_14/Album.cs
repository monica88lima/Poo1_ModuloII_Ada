using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_14
{
    public class Album
    {
        public string[] Figurinha { get; set; }
        public int QtdFigurinhas { get; set; }
        public int[] NumerosFigurinhas { get; set; }
        public int[] FigurinhasColadas { get; protected set; }
        public int ContadorFigurinhasColadas { get; set; }
        public int[] NumerosFigurinhasLivres { get; set; }

        public Album(int quantidadeFigurinhaDoAlbum)
        {
            this.QtdFigurinhas = quantidadeFigurinhaDoAlbum;
            FigurinhasColadas = new int[QtdFigurinhas];
            NumerosFigurinhas = MontarAlbum(quantidadeFigurinhaDoAlbum);
        }

        private int[] MontarAlbum(int qtdDeFigurinhas)
        {
            int[] numeroDasFigurinhas = new int[qtdDeFigurinhas];


            for (int i = 1; i <= qtdDeFigurinhas; i++)
            {
                numeroDasFigurinhas[i] = i;
                Figurinha[i] = "L";
            }
            return numeroDasFigurinhas;
        }

        public int[] ColarFiguras(int[] novasFigurinhas)
        {


            for (int i = 0; i <= novasFigurinhas.Length; i++)
            {
                for (int j = 0; j <= NumerosFigurinhasLivres.Length; j++)
                {
                    if (novasFigurinhas[i] == NumerosFigurinhasLivres[j])
                    {
                        FigurinhasColadas[ContadorFigurinhasColadas] = novasFigurinhas[i];
                        ContadorFigurinhasColadas++;
                    }

                }
            }
            return FigurinhasColadas;

        }

        public void VerificadorFigurinhasLivre()
        {
            Array.Sort(FigurinhasColadas);

            Array.Sort(NumerosFigurinhasLivres);

            for (int i = 0; i <= QtdFigurinhas; i++)
            {
                if(FigurinhasColadas[i] == NumerosFigurinhasLivres[i])
                {

                }
                else
                {
                    NumerosFigurinhasLivres[i] = i;

                }
                
            }
        }
    }
}
