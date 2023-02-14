 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    internal class User
    {
        public int ID { get; init; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateOnly BirhtDate { get; set; }

    }
}
