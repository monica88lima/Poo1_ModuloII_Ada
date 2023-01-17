using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_13
{
    public class SmartWatch
    {
        public int Pedometro { get; protected set; }
        public SmartWatch()
        {

        }

        public void ContarPassos(int passos)
        {
            this.Pedometro += passos;
        }

        public void resetOnMidnight()
        {
            this.Pedometro = 0;
        }
    }
}
