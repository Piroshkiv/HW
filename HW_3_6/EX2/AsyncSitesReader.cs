 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_6.EX2
{
    public class AsyncSitesReader
    {
        public async Task<string> ReadSite(string path)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            string sourse = await response.Content.ReadAsStringAsync();
            return sourse;
        }




    }
}
