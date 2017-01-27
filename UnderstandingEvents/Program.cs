using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            NuclearReactor halfLife = new NuclearReactor();
            CrisisCenter FEAR = new CrisisCenter(halfLife);
            MeltdownInfo currentReactorState = new MeltdownInfo(2500);
            halfLife.OnReactorMeltdown(currentReactorState);
            Console.ReadKey();

        }
    }
}
