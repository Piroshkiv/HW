using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_2_2.Commands
{
    internal class AddItem : Command
    {
        public AddItem(List<ToDoItem> toDoItems): base(toDoItems) =>
            Name = "add-item";
        

        public override void Execute(string args)
        {
            string message, stringTime;
            message = args.Split('"')[1];

            ToDoItems.Add(new ToDoItem(ToDoItems.Count, args));
        }
    }
}
