 
 
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW_2_4.Commands.Exceptions
{
    internal class ArgumentMismatchException: CommandException
    {
        public ArgumentMismatchException(): base("the argument does not match the given type")
        {

        }

        public int Index { get; init; }
        public string Argument { get; init; }
        public Type ArgumentType { get; init; }
    }
}
