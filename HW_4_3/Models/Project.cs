 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_3.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedDate { get; set; }
        public int ClientId { get; set; }
        
        public Client Client { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
