using HW_2_4;
using HW_2_4.Commands.Exceptions;
 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_2_4.Commands
{
    internal class Update: Command
    {
        public Update(IList<ToDoItem> toDoItems) : base(toDoItems) =>
            (Name, RequiredNumber) = ("update", 2);

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

            string message, stringTime, repetition;

            message = args[1];

            ToDoItem item = ToDoItems.Find(el => el.ID == index);
            ToDoItems.Remove(item);

            if (args.Count == 2)
            {
                ToDoItems.Add(new ToDoItem(index, message));
                return;
            }

            TimeOnly timeOnly;

            if (TimeOnly.TryParse(args[2], out timeOnly))
            {
                throw new ArgumentMismatchException()
                {
                    CommandName = Name,
                    Index = 1,
                    Argument = args[2],
                    ArgumentType = typeof(TimeOnly)
                };
            }

            if (args.Count == 3)
            {
                ToDoItems.Add(new Reminder(index, message, timeOnly));
                return;
            }

            repetition = args[3];
            ToDoItems.Add(new ReminderRC(index, message, timeOnly, repetition));
        }
    }
}
