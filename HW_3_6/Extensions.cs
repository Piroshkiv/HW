 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_6
{
    static class Extensions
    {
        public static string Distinct1( this IEnumerable<string> src)
        {
            var res = string.Join(" ", src.Select(s => s.StringDistinct()).ToArray() );

            return res.StringDistinct();

        }

        public static string StringDistinct(this string str)
        {
            char[] del = (" .,<>()[]{}*!@#=?-:;%\r\n\t\\/" + '"').ToCharArray();
            return string.Join(" ", str.Split(del).Distinct());
        }

    }
}
