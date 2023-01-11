using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2
{
    public static class Extesions
    {
        public static IEnumerable<T> WhereEquals<T>(this IEnumerable<T> items, T match)
        {
            foreach (var item in items)
            {
                if (match.Equals(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> WhereEquals<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                    yield return item;
            }
        }

    }
}
