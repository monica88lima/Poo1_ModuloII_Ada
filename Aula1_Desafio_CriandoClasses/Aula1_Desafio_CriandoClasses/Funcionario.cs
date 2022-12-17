using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_Desafio_CriandoClasses
{
    internal class Funcionario:Pessoa
    {
        public string Time { get; set; }
        public int Id { get; set; }
        public Cargo cargo { get; set; }
        public enum Cargo
        {
            QA,
            Dev,
            DevOps,
            PM,
            Estagiario,
        }
    }
}
