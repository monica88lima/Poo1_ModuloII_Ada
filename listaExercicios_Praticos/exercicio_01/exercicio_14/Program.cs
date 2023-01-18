namespace exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça uma classe Album (de figurinhas) que tem como propriedades a quantidade de figurinhas e um array de
             * figurinhasColadas que recebe os números das figurinhas
             * coladas. Garanta que o array de figurinhasColadas apenas pode crescer. Tenha também um método 
             * colarFigurinha que permita colar figurinhas que existam no álbum e que não foram coladas ainda.*/


            Console.WriteLine("Album Figurinha");
            Album novo = new Album(4);
            novo.ColarFiguras(new int[] { 1, 2, 3 });
            novo.ColarFiguras(new int[] { 1, 2, 4 , 4});
            //novo.ColarFiguras(new int[] { 7, 8,9, 10});
            //novo.ColarFiguras(new int[] { 45, 11, 23, 12 });

            novo.ExibirAlbum();
            
        }
    }
}