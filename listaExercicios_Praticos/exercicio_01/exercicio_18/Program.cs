namespace exercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie uma classe Camera que deve ter como propriedades resolucaoMaxima e fotosTiradas e um método
             * tiraFoto que apenas aumenta o número de fotos tiradas. Crie uma classe Celular que tenha como propriedades
             * espacoDisponivel (em número de fotos), cameraFrontal e cameraTraseira. Tanto a cameraFrontal como a cameraTraseira
             * devem ser classes que herdam de Camera e tem como propriedades adicionais a resolucaoAtual
             * (não pode ser superior à resolucaoMaxima). Ambas apenas podem tirar fotos se houver espaço 
             * disponível no celular e a cameraFrontal deve ter resolucaoMaxima menor que a cameraTraseira.*/

            Console.WriteLine("Camera");


            //Camera novaMaquina = new Camera(32);
            //novaMaquina.TirarFoto();
            //novaMaquina.MostraQuantidadeDeFotos();
            //novaMaquina.TirarFoto();
            //novaMaquina.MostraQuantidadeDeFotos();
            //novaMaquina.TirarFoto();
            //novaMaquina.MostraQuantidadeDeFotos();


            Celular novoCelular = new Celular(8, 3, 4, 16);
            novoCelular.TirarFoto();
            novoCelular.TirarFoto();
            novoCelular.TirarFoto();
            novoCelular.TirarFoto();
            novoCelular.TirarFoto();
            novoCelular.MostraQuantidadeDeFotos();
            Console.WriteLine("O Espaço livre do celular  é: " + novoCelular.EspacoLivre);
        }
    }
}