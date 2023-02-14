 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2
{
    internal class Product
    {
        public Product(int id, string name, int price)
        {
            (ID, Name, Price) = (id, name, price);
        }
        public int ID { get; init; }
        public string Name { get; set; }
        public int Price { get; set; }

        public static string ToString( (Product,int) products)
        {
            return $"{products.Item1} count: {products.Item2}";
        }
        public override string ToString()
        {
            return $"Id: {ID} Name: {Name} Price: {Price}";
            
        }
    }
}
