using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2
{
    internal class User
    {
        public User()
        {
            Cart = new Cart();
        }
        public Cart Cart { get; init; }

        public bool Confirm(string message)
        {
            Console.Write(message);
            char input = Console.ReadKey().KeyChar;
            do
            {
                if ("Yy".Contains(input))
                    return true;
                if ("Nn".Contains(input))
                    return false;
            }
            while (true);
        }
    }
}
