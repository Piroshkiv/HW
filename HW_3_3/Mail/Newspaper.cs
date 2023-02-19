 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3.Mail
{
    internal class Newspaper
    {
        public string Name { get; init; }
        public Topic Topic { get; init; }
        public string Description { get; init; }

        public static Newspaper GetRandom()
        {
            Random random = new();
            return new()
            {
                Name = "Name " + random.Next(),
                Topic = (Topic)random.Next(3),
                Description = "loremloremloremloremloremloremlorem"
            };
        }


    }
}
