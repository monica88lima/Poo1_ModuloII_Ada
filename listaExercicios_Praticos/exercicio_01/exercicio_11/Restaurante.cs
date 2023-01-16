using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_11
{
    /*Crie uma classe Restaurante com as propriedades cidade, delivery (verdadeiro ou falso),
            * pedidosPendentes e tempo de entrega estimado (calculado com base nos pedidos pendentes, sendo 10 + 2 * 
            * pedidosPendentes em minutos). Os restaurantes devem ser capazes de realizar entregas desde que o cliente esteja localizado 
            * na mesma cidade e, para isso, 
            * precisamos de um método entregaPedido que devolve como resultado se é possível realizar a entrega para um determinado cliente 
            * ou não e, em caso positivo, o tempo estimado de entrega.*/
    public class Restaurante
    {
        public string  Cidade { get; set; }
        public bool Delivery { get; set; }
        private int PedidosPendentes { get; set; }
        private int TempoEstimadoEntrega { get; set; }


        public void ApresentarMensagem()
        {
            int tempoParaEntregar = EstimarTempo(PedidosPendentes);
            string mensagem = $"O Tempo estimado para entrega do seu pedido é:{tempoParaEntregar} minutos.";
            Console.WriteLine(mensagem); 
        }

        public int EstimarTempo(int qtdDePedidos)
        {
            int tempoEstimado = 10 + 2 * qtdDePedidos;
            return tempoEstimado;
        }

        public void ContadorDePedidos()
        {
            this.PedidosPendentes++;
        }
                
        public  bool EntregarPedido(string cidade)
        {
            bool entrega;
            if (cidade.ToUpper() == "OSASCO")
            {
                entrega = true;
            }
            else
            {
                entrega = false;
            }
            return entrega;
        }
    }
   
}
