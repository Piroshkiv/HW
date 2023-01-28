using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_5
{
    public class AsyncFileReader
    {
        public async Task<string> ReadToEndAsync(string path)
        {
            using StreamReader reader = new StreamReader(path);
            return await reader.ReadToEndAsync();
        }

        public async Task<string> ConcatFilesAsync(string path1, string path2)
        {
            var res = Task.WhenAll( ReadToEndAsync(path1), ReadToEndAsync(path2));
            return string.Join(" ", await res );
        }

    }
}
