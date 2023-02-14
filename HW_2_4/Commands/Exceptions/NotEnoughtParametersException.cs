 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4.Commands.Exceptions
{
    internal class NotEnoughtParametersException: CommandException
    {
        public NotEnoughtParametersException() : base("too few arguments")
        {

        }

        public int RequiredNumber { get; init; }
        public int ExistingNumber { get; init; }
    }
}
