 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_6.EX2
{
    public class AsyncFileWriter
    {
        public async Task WriteAsync(string path, string text)
        {
            using StreamWriter reader = new StreamWriter(path);
            await reader.WriteAsync(text);
        }
    }
}
