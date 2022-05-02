using CarBuilder.Abstract;
using CarBuilder.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarBuilderr realCar = new Audi();
            UseCar use = new UseCar();
            use.CarUse(realCar);
            Console.WriteLine(realCar.Car.ToString());
            Console.Read();
        }
    }
}
