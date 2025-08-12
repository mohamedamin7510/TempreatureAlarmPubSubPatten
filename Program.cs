using System.Diagnostics;
using TempreatureSensor;
Console.WriteLine("Hello in `TempreatureSensor` System for montirnig the teampreature  ");


Sensor sensor = new Sensor();
Display display = new Display();
Alarm alarm = new Alarm(30);
Broker broker = new Broker();

// listening 
broker.Subscribe("displayed",display.DisplayFiring);
broker.Subscribe("alarmed", alarm.alarmfiring);


while (true)
{

    Console.WriteLine("Please enter your number for identfing ur goal");
    Console.WriteLine("(1) Set the teampreature thrishhold ");
    Console.WriteLine("(2) Set the alarm value ");
    Console.WriteLine("(3)Exit ");
    var result = Console.ReadLine();


    switch (result)
    {
        case "1":
            Console.WriteLine("Please enter ur temperature value : ");
            var temp_value = int.Parse(Console.ReadLine()!);
            sensor.SetTeampreature(temp_value ,broker);
            break;

        case "2":
            Console.WriteLine("Please enter ur alarm value : ");
            var alarm_value = int.Parse(Console.ReadLine()!);
            alarm.changealarmvalue(alarm_value);

            break;

        case "3":
          
            return;


        default:
            Console.WriteLine("wrong input !!");
            break;

    }

}

