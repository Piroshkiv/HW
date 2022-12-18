using PW_2_2.Commands;
using System.Windows.Input;

namespace PW_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ToDoItem> toDoList = new List<ToDoItem>();

            List<Command> commands = new List<Command>()
            {
                new AddItem(toDoList),
                new AddReminder(toDoList),
                new AddReminderRc(toDoList),
                new Delete(toDoList),
                new GetAll(toDoList),
                new Update(toDoList)
            };

            string stringCommand;
            while ((stringCommand = Console.ReadLine()) != "exit")
            {
                string commandName = stringCommand.Split(' ')[0];
                string commandArgs = stringCommand.Substring(commandName.Length);
                try
                {
                    Command command = commands.Find(el => el.Name == commandName);
                    if (command is null)
                        throw new Exception();
                    command.Execute(commandArgs.Trim());
                }
                catch
                {
                    Console.WriteLine("check the spelling of commands");
                }

            }
        }
    }
}