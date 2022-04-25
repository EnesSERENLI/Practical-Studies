using CarBuilder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    public class UseCar
    {
        public void CarUse(CarBuilderr builder)
        {
            builder.CarBrand();
            builder.CarModel();
            builder.CarColor();
        }
    }
}
