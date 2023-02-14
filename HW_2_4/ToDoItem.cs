 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4
{
    internal class ToDoItem
    {
        public ToDoItem(int id, string message) => (ID, Message) = (id, message);
        public DateTime CreationDate { get; init; } = DateTime.Now;
        public int ID { get; init; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"{ID} {Message}";
        }
    }
}
