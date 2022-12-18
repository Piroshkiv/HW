using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_2_2.Commands
{
    internal abstract class Command
    {
        public Command(List<ToDoItem> toDoItems) => ToDoItems = toDoItems;

        protected List<ToDoItem> ToDoItems { get; init; }
        public string Name { get; init; }
        public abstract void Execute(string args);
    }
}
