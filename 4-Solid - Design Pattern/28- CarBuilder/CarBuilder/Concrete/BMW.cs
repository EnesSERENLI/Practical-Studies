using CarBuilder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder.Concrete
{
    public class BMW : CarBuilderr
    {
        public BMW()
        {
            _car = new Entity.Car();
        }
        public override void CarBrand()
        {
            Console.WriteLine("BMW");
        }

        public override void CarColor()
        {
            Console.WriteLine("Purple");
        }

        public override void CarModel()
        {
            Console.WriteLine("i4");
        }
    }
}
