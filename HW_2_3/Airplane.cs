using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{
    internal class Airplane : Vehicle, IFlyble
    {
        public Airplane(double speed, double weight, string model, double flyAltitude) : base(speed, weight, model)
        {
            FlyAltitude = flyAltitude;
        }

        public double FlyAltitude { get; init; }

        public override void Drive()
        {
            Console.WriteLine("Airplane drive");
        }

        public void Fly()
        {
            Console.WriteLine("Airplane fly");
        }

        public override string ToString()
        {
            return base.ToString() + $" Fly altitude: {FlyAltitude}";
        }
    }
}
