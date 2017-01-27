using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEvents
{
    public class MeltdownInfo : EventArgs
    {
        public int CoreTemperature { get; private set; }
        public MeltdownInfo (int coreTemp)
        {
            this.CoreTemperature = coreTemp;
        }


    }
}
