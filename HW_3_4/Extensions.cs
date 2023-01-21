using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    public static class Extensions
    {

        public static void CW<T>(this IEnumerable<T> src)
        {
            foreach (var item in src)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void CW(this object item)
        {
            Console.WriteLine(item.ToString());
        }




    }
}
