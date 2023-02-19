using HW_2_4.Commands.Exceptions;
 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4.Commands
{
    internal abstract class Command
    {
        public Command(IList<ToDoItem> toDoItems) => ToDoItems = toDoItems;

        protected IList<ToDoItem> ToDoItems { get; private init;}
        public string Name { get; init; }
        public int RequiredNumber { get; init; }
        public virtual void Execute(IList<string> args)
        {
            CheckArgumentNumbers(args.Count);
        }
        
        public void CheckArgumentNumbers(int existingNumber)
        {
            if (existingNumber < RequiredNumber)
                throw new NotEnoughtParametersException()
                {
                    CommandName = Name,
                    ExistingNumber = existingNumber,
                    RequiredNumber = RequiredNumber
                };
        }

        public static IList<string> ParseArgs(string stringCommand)
        {
            string[] command = stringCommand.Split('"');

            List<string> arguments = new List<string>();

            for (int i = 0; i < command.Length; i++)
            {
                if (i % 2 == 0)
                {
                    foreach (string arg in command[i].Split(' '))
                    {
                        if (!string.IsNullOrWhiteSpace(arg))
                            arguments.Add(arg.Trim());
                    }
                }
                else
                {
                    arguments.Add(command[i]);
                }
            }

            return arguments;

        }

    }
}
