using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{
    internal class Bus : Vehicle
    {
        public Bus(double speed, double weight, string model) : base(speed, weight, model)
        {

        }
        public override void Drive()
        {
            Console.WriteLine("Bus drive");
        }
    }
}
