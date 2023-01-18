using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_14
{
    public class Album
    {/*Faça uma classe Album (de figurinhas) que tem como propriedades a quantidade de figurinhas e um array de
             * figurinhasColadas que recebe os números das figurinhas
             * coladas. Garanta que o array de figurinhasColadas apenas pode crescer. Tenha também um método 
             * colarFigurinha que permita colar figurinhas que existam no álbum e que não foram coladas ainda.*/

        public int QtdFigurinhas { get; set; }

        private List<int> FigurinhasColadas { get; set; }
        private int[] Figurinhas_Coladas { get; set; }


        public Album(int quantidadeFigurinhaDoAlbum)
        {
            this.QtdFigurinhas = quantidadeFigurinhaDoAlbum;
            FigurinhasColadas = new List<int>();

        }



        public void ColarFiguras(int[] novasFigurinhas)
        {
            foreach (int f in novasFigurinhas)
            {
                if (f <= QtdFigurinhas && f >0)
                {
                    if (!FigurinhasColadas.Contains(f))
                    {
                        FigurinhasColadas.Add(f);
                    }


                    Figurinhas_Coladas = FigurinhasColadas.ToArray();


                }

            }
        }
        public void ExibirAlbum()
        {
            Array.Sort(Figurinhas_Coladas);
            foreach (int i in Figurinhas_Coladas)
            {
                Console.WriteLine("Figura Colada:" + i);
            }
        }
    }
}