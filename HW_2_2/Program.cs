namespace HW_2_2
{
    internal class Program
    {
        static void WriteSplit()
        {
            Console.WriteLine("#################################################");
        }
        static void Main(string[] args)
        {
            Store store = new Store();
            User user = new User();

            store.WriteList();

            store.Buy(user, (0, 2));
            store.Buy(user, (1, 3));
            store.Buy(user, (1, 2));
            store.Return(user, (1, 1));

            WriteSplit();
            store.WriteList();
            WriteSplit();
            store.Confirm(user);
            WriteSplit();

        }
    }
}