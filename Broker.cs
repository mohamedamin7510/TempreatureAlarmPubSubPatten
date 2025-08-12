using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempreatureSensor
{
    internal class Broker
    {
        Dictionary<string, Action<object?, TempEventArgs>> _actions = new Dictionary<string, Action<object?, TempEventArgs>>();

        public void Subscribe(string Key,Action<object ?,TempEventArgs> action)
        {
            if (!_actions.ContainsKey(Key))
            {
                
            _actions.Add(Key, action);
            }
        }

        public void Eventhandler( Sensor s,double tempreature)
        {
            s.SensorChanged = null!;
            foreach (var item in _actions)
            {                
                  s.SensorChanged += item.Value;                
            }
            s.SensorChanged.Invoke(null, new TempEventArgs() { Tempreature = tempreature });

        }


    }
}
