using HW_2_4;
using HW_2_4.Commands;
 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_2_4.Commands
{
    internal class Help: Command
    {
        public Help(IList<ToDoItem> toDoItems, IList<Command> commands) : base(toDoItems) =>
             (Name, _commands, RequiredNumber) = ("help", commands, 0);

        IList<Command> _commands; 

        public override void Execute(IList<string> args)
        {
            base.Execute(args);

            foreach (var item in _commands)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
