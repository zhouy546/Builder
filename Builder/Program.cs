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
            //向左制造引擎，颜色
            AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder Builder = new CarBuilder(car);
            //向右制造汽车框架结构
            VehicleDirector director = new CarDirector();
            Console.WriteLine(director.Build(Builder));
            Console.Read();
        }
    }
}
