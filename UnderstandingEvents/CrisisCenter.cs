using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEvents
{
    public class CrisisCenter
    {
        public CrisisCenter (NuclearReactor monitoringObject)
        {
            monitoringObject.ReactorMeltdown += MonitoringObject_ReactorMeltdown;
        }

        private void MonitoringObject_ReactorMeltdown(object sender, EventArgs e)
        {
            MeltdownInfo i = e as MeltdownInfo;
            Console.WriteLine("Meltdown detected, core temperature is: " + i.CoreTemperature);
            DispatchTeam();
            

        }

        private void DispatchTeam ()
        {
            Console.WriteLine("Sending response team now...");
        }

    }
}
