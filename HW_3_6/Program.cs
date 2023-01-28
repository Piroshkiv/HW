namespace HW_3_6
{
    using HW_3_5;
    using HW_3_6.EX2;

    internal class Program
    {
        static void Main(string[] args)
        {
            Part2().Wait();

        }

        static async Task Part1()
        {
            EX1.MultyThreading multyThreading = new();
            multyThreading.Calc(10);
        }

        static async Task Part2()
        {
            var site1 = "https://en.wikipedia.org/wiki/Polymorphism_(computer_science)";
            var site2 = "https://en.wikipedia.org/wiki/Encapsulation_(computer_programming)";

            var sitesReader = new AsyncSitesReader();
            var str = await Task.WhenAll(sitesReader.ReadSite(site1), sitesReader.ReadSite(site2));

            var writer = new AsyncFileWriter();
            Task.WaitAll(writer.WriteAsync("1.txt", str[0]), writer.WriteAsync("2.txt", str[1]));

            var reader = new AsyncFileReader();

            var src = await Task.WhenAll(reader.ReadToEndAsync("1.txt"), reader.ReadToEndAsync("2.txt"));


            var res = src.Distinct1();

            Console.WriteLine(res);

        }




    }
}