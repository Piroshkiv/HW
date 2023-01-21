namespace HW_3_3
{
    using HW_3_3.Mail;
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new("1");
            Client client2 = new("2");
            MailDepartment mailDepartment = new();

            client1.Subscribe(mailDepartment);
            client2.Subscribe(mailDepartment);

            mailDepartment.AddNewspaper(Newspaper.GetRandom());
            mailDepartment.AddNewspaper(Newspaper.GetRandom());

            client2.Unsubscribe(mailDepartment);
            mailDepartment.AddNewspaper(Newspaper.GetRandom());

        }
    }
}