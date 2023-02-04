namespace HW_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AsyncFileReader reader = new();
            Console.WriteLine(reader.ConcatFilesAsync("Hello.txt", "World.txt").Result);

        }
    }
}