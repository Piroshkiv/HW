 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3.Mail
{
    delegate void AdmissionHandler(Newspaper newspaper);  
    internal class MailDepartment
    {

        event AdmissionHandler Notify;
        public void Subscribe(AdmissionHandler handler) =>
            Notify += handler;
        
        public void Unsubscribe(AdmissionHandler handler)=>
            Notify -= handler;

        public void AddNewspaper(Newspaper newspaper) =>
             Notify?.Invoke(newspaper);
        
    }
}
