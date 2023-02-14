 
using System.Collections;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{
    internal static class ExtensionMethods
    {
        public static IEnumerable<Vehicle> FindAll(this IEnumerable<Vehicle> vehicles, Predicate<Vehicle> match)
        {
            foreach (Vehicle item in vehicles)
            {
                if (match(item))
                    yield return item;
            }
        }
        public static Vehicle Find(this IEnumerable<Vehicle> vehicles, Predicate<Vehicle> match)
        {
            return vehicles.FindAll(match).First();
        }

        public static void Write(this IEnumerable<Vehicle> vehicles)
        {
            StringBuilder stringBuilder = new StringBuilder("");
            foreach (Vehicle item in vehicles)
            {
                stringBuilder.Append( $"{item.ToString()} \n");
            }

            Console.WriteLine(stringBuilder);
        }

    }
}
