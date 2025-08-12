using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempreatureSensor
{
    internal class Sensor
    {
        public Action<object? , TempEventArgs> SensorChanged;

        private double Teampreature;

        public void SetTeampreature(double newtemp ,Broker broker )
        {
            Teampreature = newtemp;

            broker.Eventhandler(this,newtemp);

        }








    }
}
