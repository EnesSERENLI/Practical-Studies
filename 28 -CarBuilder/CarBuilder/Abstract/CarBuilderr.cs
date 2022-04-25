using CarBuilder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder.Abstract
{
    public abstract class CarBuilderr
    {
        protected Car _car;

        public Car Car
        {
            get { return _car; }
        }
        public abstract void CarBrand();
        public abstract void CarModel();
        public abstract void CarColor();
    }
}
