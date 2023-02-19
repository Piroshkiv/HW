 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3
{
    internal static class Extensions
    {
        public static T FirstOrDefault2<T>(this IEnumerable<T> src, Func<T, bool> func)
        {
            foreach (var item in src)
            {
                if (func(item))
                    return item;
            }
            return default;
        }
        public static T FirstOrDefault2<T>(this IEnumerable<T> src)
        {
            return FirstOrDefault2(src, (e)=> true);
        }

        public static IEnumerable<T> SkipWhile2<T>(this IEnumerable<T> src, Func<T, bool> func)
        {
            foreach (var item in src)
            {
                if (!func(item))
                {
                    yield return item;
                }
            }
        }


    }
}
