 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5
{
    public class LoggerConfig
    {
        public LoggerConfig()
        {

        }
        public LoggerConfig(LogType type, string message) => (Type, Message, Date) = (type, message, DateTime.Now);

        public LogType Type { get; init; }
        public string Message { get; init; }
        public DateTime Date { get; init; }
    }
}
