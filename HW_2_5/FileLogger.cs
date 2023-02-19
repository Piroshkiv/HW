using Newtonsoft.Json;
 
 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static HW_2_5.Loger;

namespace HW_2_5
{
    public class FileLogger: Loger
    {
        public FileLogger(string path) => _path = path;

        private string _path;

        public override void Log(LoggerConfig log)
        {
            


            using StreamWriter streamWriter = new StreamWriter(File.Open(_path, FileMode.Append));
            streamWriter.WriteLine(Serialize(log));
        }


    }
}
