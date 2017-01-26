using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new instance from Car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Fiat Multipla";
            car.Color = "Brown";
            car.Engine = 0.8;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 4;
            car.Accelerate();
            car.PrintData();
            car.Brake(7);
            Car.SomeProperty = 56;
            car.PrintData();

            //create another car object
            string model = "Speedster";
            
            Car nascar = new Car(model);
            nascar.PrintData();
            nascar.Color = "Black";
            Console.WriteLine("Color is " + nascar.Color);
        }
    }
}
