using HW_3_2;
using System.Linq;

namespace JNKJCGHCGH
{
    class C
    {
        public int Property { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<object> list = (List<object>)(IEnumerable<string>)(new List<string>());

        }

        public static void Concat(object o)
        {
            for (int j = 0; j < 1000; j++)
            {
                lock (o)
                {
                    ((C)o).Property++;
                }
            }
        }
    }
}