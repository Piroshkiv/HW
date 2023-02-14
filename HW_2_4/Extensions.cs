 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4
{
    internal static class ExtensionMethods
    {
        public static IEnumerable<TSource> FindAll<TSource>(this IEnumerable<TSource> elements, Predicate<TSource> match) 
        {
            foreach (TSource item in elements)
            {
                if (match(item))
                    yield return item;
            }
        }
        public static TSource Find<TSource>(this IEnumerable<TSource> elements, Predicate<TSource> match)
        {
            return elements.FindAll(match).First();
        }
    }
}

