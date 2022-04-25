using CarBuilder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder.Concrete
{
    public class Mercedes:CarBuilderr
    {
        public Mercedes()
        {
            _car = new Entity.Car();
        }

        public override void CarBrand()
        {
            Console.WriteLine("Mercedes");
        }

        public override void CarColor()
        {
            Console.WriteLine("Black");
        }

        public override void CarModel()
        {
            Console.WriteLine("Maybach");
        }
    }
}
