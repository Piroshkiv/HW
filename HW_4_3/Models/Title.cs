 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_3.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
