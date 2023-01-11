namespace HW_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 10, 12, 13, 14 };

            list.Add(12);

            list.Remove(13);

            list[5] = 10;

            list.AddRange(new int[] { 1, 2, 3, 4 });

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            list.Sort();

            Console.WriteLine();

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            
        }
    }
}