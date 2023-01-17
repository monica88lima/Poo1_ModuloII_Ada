namespace exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça uma classe SmartWatch com a 
             * contagem dos passos diários de uma pessoa (pedômetro). Garanta utilizando acessors (get/set) 
             * que os passos apenas podem ser incrementados e um método resetOnMidnight() que reseta os passos para 0.*/

            Console.WriteLine("Contador de Passos");

            SmartWatch novo = new SmartWatch();
            novo.ContarPassos(250);
            Console.WriteLine($"Ao acordar sai para comprar pão, caminhei --> {novo.Pedometro} passos");

            novo.ContarPassos(10);
            Console.WriteLine($"Preparando o café da manhã, caminhei -->{novo.Pedometro} passos");

            novo.ContarPassos(68);
            Console.WriteLine($"Me preparando para sair, caminhei -->{novo.Pedometro} passos");

            novo.resetOnMidnight();
            Console.WriteLine($"Resetei o SmartWatch--> {novo.Pedometro} passos");

            novo.ContarPassos(1500);
            Console.WriteLine($"Sai para trabalhar, caminhei --> {novo.Pedometro} passos");

        }
    }
}