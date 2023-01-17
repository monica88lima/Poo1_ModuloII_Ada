using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    public  class Perfil
    {
        /*Faça uma classe Perfil que tem as seguintes informações:
            * nome, avatar (foto de perfil) e tema. Utilize acessors (get/set) para garantir
            * que o tema só pode ser "light" ou "dark" e que a foto de perfil deve ser uma url (iniciada com http ou https).*/

        public string Nome{ get; protected set; }
        private string Avatar;
        private string Tema;

        public string _Tema { get { return Tema; } set { Tema = value; } }
        public string _Avatar { get { return Avatar; } set { Avatar= value; } }

        public Perfil(string nome,string url, string tema )
        {
            this.Nome = nome;   
            _Avatar = ValidarAvatar(url);
            _Tema = ValidarTema(tema);
        }

        private string ValidarAvatar( string url)
        {
            string avatar = "";
           

            if(url.ToUpper().Contains("HTTP")|| url.ToUpper().Contains("HTTPS"))
            {
                avatar = url;
            }
            else
            {
                SolicitarNovaEntrada("AVATAR");
            }
            return avatar;
        }
        private string ValidarTema(string tema)
        {
            string cor = "";


            if (tema.ToUpper().Contains("LIGHT") || tema.ToUpper().Contains("DARK"))
            {
                cor = tema;
            }
            else
            {
                SolicitarNovaEntrada("TEMA");
            }
            return cor;
        }
        private void SolicitarNovaEntrada(string tipoIncorreto)
        {
            if(tipoIncorreto.ToUpper() == "AVATAR")
            {
                Console.WriteLine("Digite um novo URL para concluir seu Avatar:");
                _Avatar = Console.ReadLine().ToUpper();
            }
            else if(tipoIncorreto.ToUpper() == "TEMA")
            {
                Console.WriteLine("Digite um novo TEMA (Dark ou Light) para concluir seu Avatar:");
                _Tema = Console.ReadLine().ToUpper();
            }
            else
            {
                throw new Exception();
            }
        }
        
    }
}
