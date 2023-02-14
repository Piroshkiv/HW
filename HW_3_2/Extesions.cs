 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2
{
    public static class Extesions
    {
        public static IEnumerable<T> WhereEquals<T>(this IEnumerable<T> src, T match)
        {
            foreach (var item in src)
            {
                if (match.Equals(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> WhereEquals<T>(this IEnumerable<T> src, Predicate<T> predicate)
        {
            foreach (var item in src)
            {
                if (predicate.Invoke(item))
                    yield return item;
            }
        }

    }
}

