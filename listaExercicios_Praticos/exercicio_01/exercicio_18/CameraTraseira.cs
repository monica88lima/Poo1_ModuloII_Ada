using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_18
{
    public class CameraTraseira:Camera
    {
        public int ResolucaoAtual { get; set; }
        public CameraTraseira(int resolucaoMaxima) : base(resolucaoMaxima)
        {

        }
    }
}
