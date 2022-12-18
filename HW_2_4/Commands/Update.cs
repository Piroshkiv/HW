using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PW_2_2.Commands
{
    internal class Update: Command
    {
        public Update(List<ToDoItem> toDoItems) : base(toDoItems) =>
            Name = "update";

        public override void Execute(string args)
        {

            int id = int.Parse(args.Split(' ')[0]);

            
            string message, stringTime, repetition;

            message = args.Split('"')[1];
            args = args.Split('"')[2].Trim();

            ToDoItem item = ToDoItems.Find(el => el.ID == id);
            ToDoItems.Remove(item);

            if (string.IsNullOrWhiteSpace(args))
            {
                ToDoItems.Add(new ToDoItem(id, message));
                return;
            }

            stringTime = args.Split(' ')[0];

            if (args.Split(' ').Length == 1)
            {
                ToDoItems.Add(new Reminder(id, message, TimeOnly.Parse(stringTime) ));
                return;
            }
            repetition = args.Split(' ')[1];

            ToDoItems.Add(new ReminderRC(id, message, TimeOnly.Parse(stringTime), repetition));
        }
    }
}
