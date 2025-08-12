using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempreatureSensor
{
    internal class Display
    {
        public  void DisplayFiring(object? obj, TempEventArgs? boom)
        {
            Console.WriteLine(" from display the tempreature is :  " + boom!.Tempreature);

        }
    }
}
