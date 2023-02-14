using HW_2_4.Commands.Exceptions;
 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4.Commands
{
    internal class Delete: Command
    {
        public Delete(IList<ToDoItem> toDoItems) : base(toDoItems) =>
            (Name, RequiredNumber) = ("delete", 1);

        public override void Execute(IList<string> args)
        {
            base.Execute(args);

            int index;

            if (int.TryParse(args[0], out index))
            {
                throw new ArgumentMismatchException()
                {
                    CommandName = Name,
                    Index = 1,
                    Argument = args[0],
                    ArgumentType = typeof(int)
                };
            }

            ToDoItems.RemoveAt(index);
        }
    }
}
