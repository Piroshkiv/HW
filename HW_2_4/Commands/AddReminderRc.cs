using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_2_2.Commands
{
    internal class AddReminderRc: Command
    {
        public AddReminderRc(List<ToDoItem> toDoItems) : base(toDoItems) =>
            Name = "add-reminder-rc";


        public override void Execute(string args)
        {
            string message, stringTime,repetition;

            message = args.Split('"')[1];
            args = args.Split('"')[2];

            stringTime = args.Split(' ')[1];
            repetition = args.Split(' ')[2];

            ToDoItems.Add(new ReminderRC(ToDoItems.Count, message, TimeOnly.Parse(stringTime),repetition));
        }
    }
}
