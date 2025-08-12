using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempreatureSensor
{
    internal class Alarm
    {
        private int alarmedvalue { get; set; }


        public Alarm(int alarmedvalue )
        {
            this.alarmedvalue = alarmedvalue;
        }
        public void alarmfiring(object? obj, TempEventArgs? boom)
        {

            var sensor = obj as Sensor;
            Sensor s = new Sensor();
            if (boom.Tempreature > this.alarmedvalue)
            {

                Console.WriteLine($"Watch out the degree above {this.alarmedvalue}");

            }

        }
        public void changealarmvalue(int alarmedvalue)
        {
           this. alarmedvalue = alarmedvalue;
        }

    }
}
