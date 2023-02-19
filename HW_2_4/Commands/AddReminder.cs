using HW_2_4.Commands.Exceptions;
 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4.Commands
{
    internal class AddReminder: Command
    {
        public AddReminder(IList<ToDoItem> toDoItems) : base(toDoItems) =>
            (Name, RequiredNumber) = ("add-reminder", 2);


        public override void Execute(IList<string> args)
        {
            base.Execute(args);

            string message;
            message = args[0];

            TimeOnly timeOnly;

            if(TimeOnly.TryParse(args[1], out timeOnly))
            {
                throw new ArgumentMismatchException()
                {
                    CommandName = Name,
                    Index = 1,
                    Argument = args[1],
                    ArgumentType = typeof(TimeOnly)
                };
            }

            ToDoItems.Add( new Reminder(ToDoItems.Count, message, timeOnly));
        }
    }
}
