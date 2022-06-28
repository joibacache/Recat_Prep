using DynamicBinding.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding.Vehicles
{
    public class BaseVehicle : IBaseVehicle
    {
        public int Position { get; set; }
        public int MoveForward(int accelerationFactor)
        {
            Position += accelerationFactor;
            return Position;
        }

        public int MoveBackwards(int accelerationFactor)
        {
            Position -= accelerationFactor;
            return Position;
        }
    }
}
