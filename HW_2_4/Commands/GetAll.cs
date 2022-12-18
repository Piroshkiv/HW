using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_2_2.Commands
{
    internal class GetAll:Command
    {
        public GetAll(List<ToDoItem> toDoItems) : base(toDoItems) =>
            Name = "get-all";

        public override void Execute(string args)
        {
            ToDoItems.OrderBy(el => el.ID).ToList().ForEach(el => Console.WriteLine(el));
        }
    }
}
