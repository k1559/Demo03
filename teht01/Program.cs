using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            kiuas kiuas = new kiuas();
            kiuas.IsOn = true;
            kiuas.Temperature = 80;
            kiuas.Humidity = 90.2;
            kiuas.ThrowWater();
            Console.WriteLine("Temperature is " + kiuas.Temperature);
            Console.WriteLine("Humidity is " + kiuas.Humidity);
        }
    }
}
