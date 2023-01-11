using HW_2_4.Commands;
using HW_2_4.Commands.Exceptions;
using HW_2_5;

namespace HW_2_4
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
            commands.Add(new Help(toDoList, commands));

            Loger loger = new ConsoleLogger();

            string stringCommand;
            while ((stringCommand = Console.ReadLine()) != "exit")
            {

                var commandArgs = Command.ParseArgs(stringCommand) ;
                string commandName = commandArgs[0];

                commandArgs.RemoveAt(0);
                try
                {
                    Command command = commands.Find(el => el.Name == commandName);
                    if (command is null)
                        throw new NoCommandException()
                        {
                            CommandName = commandName
                        };
                    command.Execute(commandArgs);
                    loger.Log(new LoggerConfig(LogType.Info, "command completed successfully"));
                }
                catch(CommandException ex)
                {
                    loger.Log(new LoggerConfig( LogType.Error, ex.Message));
                }
            }
        }
    }
}