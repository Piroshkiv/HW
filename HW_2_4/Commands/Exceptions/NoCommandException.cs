 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4.Commands.Exceptions
{
    internal class NoCommandException: CommandException
    {
        public NoCommandException(): base("this command does not exist") {  }

    }
}
