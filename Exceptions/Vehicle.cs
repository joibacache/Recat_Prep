using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Vehicle
    {
        public List<string> Actions
        {
            get
            {
                var actions = new List<string>() { "mf - move forward", "mv = move backwards", "tl - turn left", "tr - turn right" };
                return actions; 
            }
        }

        public void ExecuteAction(string action)
        {
            var vehicleAction = Actions.Select(x => x.Substring(0,2)).Contains(action) ? action : throw new ArgumentException("Selected option is not available.",nameof(action));
            switch(vehicleAction.Substring(0,2))
            {
                case "mf":
                    Console.WriteLine("Moving Forward...");
                    break;
                case "mb":
                    Console.WriteLine("Moving Backwards...");
                    break;
                case "tl":
                    Console.WriteLine("Turning Left...");
                    break;
                case "tr":
                    Console.WriteLine("Turning Right...");
                    break;
            }
        }
    }

    
}
