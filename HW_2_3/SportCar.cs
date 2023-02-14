 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{
    internal class SportCar : Car
    {
        public SportCar(double speed, double weight, string model) : base(speed, weight, model)
        {

        }

        public override void Drive()
        {
            Console.WriteLine("Sport car drive");
        }
    }
}
