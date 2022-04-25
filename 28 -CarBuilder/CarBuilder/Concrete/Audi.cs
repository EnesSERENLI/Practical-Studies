using CarBuilder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarBuilder.Concrete
{
    public class Audi : CarBuilderr
    {
        public Audi()
        {
            _car = new Entity.Car();
        }

        public override void CarBrand()
        {
            Console.WriteLine("Audi");
        }

        public override void CarColor()
        {
            Console.WriteLine("White");
        }

        public override void CarModel()
        {
            Console.WriteLine("A8");
        }
    }
}
