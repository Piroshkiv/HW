 
using System.Collections;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{
    internal abstract class Vehicle : IComparable<Vehicle>, IComparer<Vehicle>
    {
        public Vehicle(double speed, double weight, string model) 
            => (Speed, Weight, Model) = (speed, weight, model);
        public double Speed { get; set; }
        public double Weight { get; set; }
        public string Model { get; init; }

        public int Compare(Vehicle? x, Vehicle? y)
        {
            return x.Speed.CompareTo(y.Speed);
        }

        public int CompareTo(Vehicle? other)
        {
            return this.Compare(this, other);
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vehicle drive");
        }

        public override string ToString()
        {
            return $"Type: {GetType()} Speed: {Speed} Weight: {Weight} Model: {Model}";
        }

    }
}
