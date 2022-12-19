using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_2_2.Commands
{
    internal class AddReminder: Command
    {
        public AddReminder(List<ToDoItem> toDoItems) : base(toDoItems) =>
            Name = "add-reminder";

        public override void Execute(string args)
        {
            string message, stringTime;

            message = args.Split('"')[1];
            args = args.Split('"')[2];

            stringTime = args.Split(' ')[1];

            ToDoItems.Add( new Reminder(ToDoItems.Count, message, TimeOnly.Parse(stringTime)));
        }
    }
}
