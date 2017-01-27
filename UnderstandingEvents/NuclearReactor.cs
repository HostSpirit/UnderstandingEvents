using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEvents
{
    public class NuclearReactor
    {
        public event EventHandler ReactorMeltdown;

        public void OnReactorMeltdown (MeltdownInfo i)
        {
            Console.WriteLine("Sh*t happens: reactor core meltdown!");
            ReactorMeltdown?.Invoke(this, i);           
        }

    }
}
