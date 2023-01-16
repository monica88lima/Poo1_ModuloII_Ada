namespace exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Deseja-se montar uma classe Sorteio que tem o número de pessoas inscritas e um método 
             * sorteiaPremio que sorteia um número que corresponderá ao número de inscrição do 
             * participante e declara o vencedor.*/

            Console.WriteLine("Exercicio -10");

            Sorteio inscrito1 = new Sorteio();
            inscrito1.NumeroDeInscritos = 5;

            
            inscrito1.NomesInscritos.Add("Ana ");
            inscrito1.NomesInscritos.Add("Bia");
            inscrito1.NomesInscritos.Add("Carol");
            inscrito1.NomesInscritos.Add("Dani");
            inscrito1.NomesInscritos.Add("Elisa");

            

            inscrito1.DeclararVencedor(inscrito1.SortearPremio());
        }
    }
}