 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_2_4.Commands.Exceptions;

namespace HW_2_4.Commands
{
    internal class AddItem : Command
    {
        public AddItem(List<ToDoItem> toDoItems): base(toDoItems) =>
            (Name, RequiredNumber) = ("add-item", 1);
        
        public override void Execute(IList<string> args)
        {
            base.Execute(args);

            string message;
            message = args[0];

            ToDoItems.Add(new ToDoItem(ToDoItems.Count, message));

        }
    }
}
