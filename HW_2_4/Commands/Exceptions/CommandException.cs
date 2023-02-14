 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4.Commands.Exceptions
{
    internal abstract class CommandException: Exception
    {
        public CommandException(string message)
        : base(message) { }
        public string CommandName { get; init; }
    }
}
