namespace HW_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Part2();
        }

        static void Part1()
        {
            int[] intArray = { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 };
            string str = "Abilities forfeited situation extremely my to he resembled. Old had conviction discretion understood put principles you.";
            string[] strArray = { "Abilities", "forfeited", "situation", "extremely", "my", "to", "he", "resembled", "Old", "had", "conviction", "discretion", "understood", "put", "principles", "you" };
            //1
            intArray.Where(e => e % 6 == 0).CW();

            intArray.Sum().CW();

            intArray.Average().CW();

            intArray.Max().CW();

            intArray.Min().CW();
            //6
            intArray.Where(e => e > 10).Select(e => e * 10).CW();

            str.Distinct().CW();

            intArray.GroupBy(el1 => el1, el2 => intArray.Count(c => c == el2))
                .ToDictionary(g => g.Key, g => g.First()).CW();

            intArray.GroupBy(el1 => (el1 % 2 == 0) ? "even" : "odd", el2 => el2).ToDictionary(g => g.Key, g => g.Max()).CW();

            intArray.Where(e => e > intArray.Average()).CW();

            //11

            strArray.GroupBy(el1 => el1.Length, el2 => el2).ToDictionary(g => g.First(), g => g.Key).CW();

            //12

            _ = strArray.Where(el => el.Contains("o")).GroupBy(i => i.Length, s => s).Select(i => new
            {
                Key = i.Key,
                Values = i.Select(s => s.ToUpper())
            });
        }

        static void Part2()
        {
            List<User> users = new()
            {
                new User
                {
                    ID = 0,
                    Name = "Name0",
                    Surname = "Surname0",
                    Email = "User0@ukr.net",
                    BirhtDate = DateOnly.Parse("01.01.2000")
                },
                new User
                {
                    ID = 1,
                    Name = "Name1",
                    Surname = "Surname0",
                    Email = "User1@gmail.com",
                    BirhtDate = DateOnly.Parse("03.05.2005")
                },
                new User
                {
                    ID = 2,
                    Name = "Name2",
                    Surname = "Surname1",
                    Email = "User2@ukr.net",
                    BirhtDate = DateOnly.Parse("02.01.2007")
                },
                new User
                {
                    ID = 3,
                    Name = "Name3",
                    Surname = "Surname1",
                    Email = "User3@gmail.com",
                    BirhtDate = DateOnly.Parse("03.10.1999")
                },
                new User
                {
                    ID = 4,
                    Name = "Name4",
                    Surname = "Surname0",
                    Email = "User4@gmail.com",
                    BirhtDate = DateOnly.Parse("07.10.1989")
                },
            };

            
            var users1 = users.Where(u => (DateTime.Today.AddYears(-18) >= u.BirhtDate.ToDateTime(TimeOnly.MinValue)) )
                .Select( u => new
                {
                    FullName = u.Name + "" + u.Surname,
                    BirhtDate = u.BirhtDate,
                    Age = GetAge(u.BirhtDate.ToDateTime(TimeOnly.MinValue))
                }).ToList();

            var users2 = users.GroupBy(u => u.Email.Split("@")[1].Trim()).MaxBy(u => u.Key.Length);


            var users3 = users.ToHashSet(new UserComparer());

            users3.TryGetValue(new User() { ID = 3 }, out _);

            var namesakes = users.GroupBy(u => u.Surname).ToList();

            var users4 = namesakes.ToDictionary(e => e.Key, e => e.Select(e => new
            {
                Name = e.Name,
                BirhtDate = e.BirhtDate,
                Namesakes = namesakes.First(u => u.Key == e.Surname)
                .Where(u => u.ID != e.ID)
                .OrderBy(u => u.BirhtDate)
                .ToList()
            }).ToList() );

        }

        static int GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

    }
}