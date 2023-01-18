using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_18
{
    public class CameraFrontal : Camera
    {
        public int ResolucaoAtual { get; set; }

        public CameraFrontal(int resolucaoMaxima):base(resolucaoMaxima)
        {
                
        }
    }
        
}

