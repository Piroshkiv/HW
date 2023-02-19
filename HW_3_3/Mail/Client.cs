 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3.Mail
{
    internal class Client
    {
        public Client(string name) => Name = name;
       
        public string Name { get; set; }
        public void Subscribe(MailDepartment mailDepartment) =>
            mailDepartment.Subscribe(Notify);
        public void Unsubscribe(MailDepartment mailDepartment) =>
            mailDepartment.Unsubscribe(Notify);

        public void Notify(Newspaper newspaper) =>
            Console.WriteLine( $"Name: {Name}\t Newspaper {newspaper.Name}");
        

    }
}
