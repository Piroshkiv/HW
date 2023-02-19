 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_3_1
{
    public class LinkedNode<T>
    {

        public LinkedNode(T value) =>
            Value = value;

        public LinkedNode<T>? Next { get; set; }
        public T Value { get; set; }
    }
}
