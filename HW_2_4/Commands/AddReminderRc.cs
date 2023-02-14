using HW_2_4.Commands.Exceptions;
 
using System.Collections;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4.Commands
{
    internal class AddReminderRc: Command
    {
        public AddReminderRc(IList<ToDoItem> toDoItems) : base(toDoItems) =>
            (Name, RequiredNumber) = ("add-reminder-rc", 3);

        public override void Execute(IList<string> args)
        {
            base.Execute(args);

            string message, repetition;

            message = args[0];

            TimeOnly timeOnly;

            if (TimeOnly.TryParse(args[1], out timeOnly))
            {
                throw new ArgumentMismatchException()
                {
                    CommandName = Name,
                    Index = 1,
                    Argument = args[1],
                    ArgumentType = typeof(TimeOnly)
                };
            }

            repetition = args[2];

            ToDoItems.Add(new ReminderRC(ToDoItems.Count, message, timeOnly ,repetition));
        }
    }
}
