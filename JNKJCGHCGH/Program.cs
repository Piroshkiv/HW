using HW_3_2;
using System.Linq;

namespace JNKJCGHCGH
{
    class C
    {
        public int Property { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                C o = new() { Property = 0 };
                Thread thread1 = new(() => Concat(o));
                Thread thread2 = new(() => Concat(o));
                Thread thread3 = new(() => Concat(o));

                thread1.Start();
                thread2.Start();
                thread3.Start();

                thread1.Join();
                thread2.Join();
                thread3.Join();

                Console.WriteLine(((C)o).Property);
            }

        }

        public static void Concat(object o)
        {
            for (int j = 0; j < 1000; j++)
            {
                lock (o)
                {
                    ((C)o).Property++;
                }
            }
        }
    }
}