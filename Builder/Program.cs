using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder Builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            Console.WriteLine(director.Build(Builder));
            Console.Read();
        }
    }
}
