namespace exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie uma classe Restaurante com as propriedades cidade, delivery (verdadeiro ou falso),
             * pedidosPendentes e tempo de entrega estimado (calculado com base nos pedidos pendentes, sendo 10 + 2 * 
             * pedidosPendentes em minutos). Os restaurantes devem ser capazes de realizar entregas desde que o cliente esteja localizado 
             * na mesma cidade e, para isso, 
             * precisamos de um método entregaPedido que devolve como resultado se é possível realizar a entrega para um determinado cliente 
             * ou não e, em caso positivo, o tempo estimado de entrega.*/


            Console.WriteLine("-------------Restaurante ----------");

            Restaurante restaurante = new Restaurante();
            do
            {
                
                Console.WriteLine("Informe o nome do Cliente:");
                string nome = Console.ReadLine();

                Console.WriteLine("Delivery? (S)Sim ou (N) Não:");
                string delivery = Console.ReadLine();

                if (delivery.ToUpper() == "S")
                {
                    Console.WriteLine("Informe a cidade de Destino:");
                    string cidade = Console.ReadLine();

                    bool FazEntrega = restaurante.EntregarPedido(cidade);

                    if (FazEntrega)
                    {
                        Console.WriteLine("Informe o seu pedido:");
                        string pedido = Console.ReadLine();

                        restaurante.ContadorDePedidos();
                        restaurante.ApresentarMensagem();

                    }
                    else
                    {
                        Console.WriteLine("Não realizamos entrega nesta localidade :(");
                    }

                }
                else
                {
                    Console.WriteLine("Informe o seu pedido:");
                    string pedido = Console.ReadLine();
                    restaurante.ContadorDePedidos();
                    restaurante.ApresentarMensagem();

                }
                

            }while(true);
            

            
        }
    }
}