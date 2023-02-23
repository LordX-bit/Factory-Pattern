using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class Vehicle_Factory
    {
        public static IVehicle GetVehicle(int wheeCount)
        {
            switch (wheeCount)
            { 
                case 2:
                    return new Motorcycle();
                    case 3:
                    return new ThreeWheeler();
                case 4:
                    return new Car();
                default:
                    return new Car();
        }
      }
    }
}
