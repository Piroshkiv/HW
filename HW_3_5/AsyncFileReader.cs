using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_5
{
    internal class AsyncFileReader
    {
        public async Task<string> ReadToEndAsync(string path)
        {
            using StreamReader reader = new StreamReader(path);
            Thread.Sleep(3000);
            Console.WriteLine(1);
            return await reader.ReadToEndAsync();
        }

        public async Task<string> ConcatFilesAsync(string path1, string path2)
        {
            string str1 = "";
            string str2 = "";
            Task task1 = new Task(() => str1 = ReadToEndAsync(path1).Result);
            Task task2 = new Task(() => str2 = ReadToEndAsync(path2).Result);

            task1.Start();
            task2.Start();

            Task.WaitAll(task1, task2);
            
            return str1 + str2;
        }

    }
}
