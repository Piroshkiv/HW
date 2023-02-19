 
 
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2
{
    internal class Store
    {
        public Store()
        {
            Products = new List<(Product, int)>
            {
                (new Product(0,"Product 0",1000),10 ),
                (new Product(1,"Product 1",2000),8 ),
                (new Product(2,"Product 2",3000),7 ),
                (new Product(3,"Product 3",100),6 ),
                (new Product(4,"Product 4",200),5 ),
                (new Product(5,"Product 5",300),11 )
            };
        }
        public List<(Product, int)> Products { get; init; }
        private int _orderNumber = 0;

        public void Add((Product, int) addItem)
        {
            int itemId = Products.FindIndex((item) =>
                addItem.Item1.ID == item.Item1.ID);
            Products[itemId] = (addItem.Item1, Products[itemId].Item2 + addItem.Item2);
        }


        public void Buy(User user, (int, int) boughtItem)
        {
            int itemIndex = Products.FindIndex((el) => el.Item1.ID == boughtItem.Item1);

            if (Products[itemIndex].Item1 is null)
                throw new Exception();
            if(Products[itemIndex].Item2 < boughtItem.Item2)
                throw new Exception();

            user.Cart.Add((Products[itemIndex].Item1, boughtItem.Item2));
            Products[itemIndex] = (Products[itemIndex].Item1, Products[itemIndex].Item2 - boughtItem.Item2);

        }

        public void Return(User user, (int, int) returnItem)
        {
            int itemIndex = Products.FindIndex((el) => el.Item1.ID == returnItem.Item1);

            if (Products[itemIndex].Item1 is null)
                throw new Exception();
            
            user.Cart.Remove((Products[itemIndex].Item1, returnItem.Item2));
            Products[itemIndex] = (Products[itemIndex].Item1, Products[itemIndex].Item2 + returnItem.Item2);

        }

        public void ReturnAll(User user)
        {
            user.Cart.ReturnAll().ToList().ForEach(el => Add(el));
        }

        public void WriteList()
        {
            Products.ForEach(el =>
                Console.WriteLine(Product.ToString(el)));
        }
        
        public void Confirm(User user)
        {
            string message = $"Your order id: {++_orderNumber}\n";
            user.Cart.Products.ForEach(el =>
                message += Product.ToString(el) + '\n'
            );
            message += $"Total: {user.Cart.TotalPrice}\nConfirm(Y/n): ";
            

            if (user.Confirm(message))
                user.Cart.Products.Clear();
            Console.WriteLine();
        }

    }
}
