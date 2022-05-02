using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Factory
    {
        public BaseEntity FactoryMethod(Model menu)
        {
            BaseEntity entity = null;
            switch (menu)
            {
                case Model.Hamburger:
                    entity = Hamburger.HamburgerInstance;
                    break;
                case Model.Extra:
                    entity = Extra.ExtraInstance;
                    break;
            }
            return entity;
        }
    }

    public enum Model
    {
        Hamburger,
        Extra
    }
}
