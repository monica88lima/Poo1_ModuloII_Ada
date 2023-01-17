namespace exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça uma classe Perfil que tem as seguintes informações:
             * nome, avatar (foto de perfil) e tema. Utilize acessors (get/set) para garantir
             * que o tema só pode ser "light" ou "dark" e que a foto de perfil deve ser uma url (iniciada com http ou https).*/

            Console.WriteLine("Montar Perfil");

            Console.WriteLine("Digite seu nome:");
            string nome= Console.ReadLine();

            Console.WriteLine("Digite o URL da foto do seu AVATAR:");
            string avatar = Console.ReadLine();

            Console.WriteLine("Digite o Tema que deseja ativar: (DARK) OU (LIGHT):");
            string tema = Console.ReadLine();

            Perfil perfilNovo = new Perfil(nome, avatar, tema);

            Console.WriteLine($"Perfil Criado: Seja bem vindo {perfilNovo.Nome}\n" +
                $"Sua Foto:{perfilNovo._Avatar}\n" +
                $"Seu Tema será:{perfilNovo._Tema}");

        }
    }
}