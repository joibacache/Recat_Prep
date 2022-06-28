using DynamicBinding.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    public class VehicleControl
    {
        public int MoveForward(Car vehicle)
        {
            return vehicle.MoveForward(10);
        }

        public int MoveForward(Truck vehicle)
        {
            return vehicle.MoveForward(3);
        }
    }
}
