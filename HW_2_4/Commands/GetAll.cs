 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4.Commands
{
    internal class GetAll:Command
    {
        public GetAll(IList<ToDoItem> toDoItems) : base(toDoItems) =>
             (Name, RequiredNumber) = ("get-all", 0);

        public override void Execute(IList<string> args)
        {
            base.Execute(args);

            ToDoItems.OrderBy(el => el.ID).ToList().ForEach(el => Console.WriteLine(el));
        }
    }
}
