using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding.Interfaces
{
    public interface IBaseVehicle
    {
        int MoveForward(int accelerationFactor);
        int MoveBackwards(int accelerationFactor);
    }
}
