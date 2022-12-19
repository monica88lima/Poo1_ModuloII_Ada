namespace exercicio_02_classeCaneta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando objeto Caneta");

            Caneta objeto1 = new Caneta()
            {
                Marca = "Bic",
                Cor = "Azul",
                tipo = Caneta.Tipo.Esferografica
            };

            Caneta objeto2 = new Caneta()
            {
                Marca = "Stabilo",
                Cor = "Rosa",
                tipo = Caneta.Tipo.hidrografica
            };

            Console.WriteLine(objeto2.tipo);
            Console.WriteLine(objeto1.tipo);
        }
    }
}