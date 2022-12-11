using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HW_2_2
{
    internal class Cart
    {
        public Cart() => Products = new List<(Product, int)>();
        public Cart(IEnumerable<(Product, int)> products)
        {
            Products = products.ToList();
        }
        public List<(Product, int)> Products { get; init; }

        public int TotalPrice
        {
            get => Products.Sum(el => el.Item1.Price * el.Item2);
        }

        public void Add((Product,int) boughtItem)
        {
            int itemId = Products.FindIndex((item) =>
                boughtItem.Item1.ID == item.Item1.ID);

            if (itemId == -1)
                Products.Add(boughtItem);
            else
                Products[itemId] = (boughtItem.Item1, Products[itemId].Item2 + boughtItem.Item2 );
        }
        public void Add(IEnumerable<(Product, int)> boughtItems)
        {
            boughtItems.ToList().ForEach((boughtItem) =>
            {
                Add(boughtItem);
            });
        }

        public void Remove((Product, int) removeItem)
        {
            int itemId = Products.FindIndex((item) =>
                removeItem.Item1.ID == item.Item1.ID);

            if (removeItem.Item2 > Products[itemId].Item2)
                throw new Exception();
            else
                Products[itemId] = (removeItem.Item1, Products[itemId].Item2 - removeItem.Item2);
        }
        public void Remove(IEnumerable<(Product, int)> removeItems)
        {
            removeItems.ToList().ForEach((removeItem) =>
            {
                Remove(removeItem);
            });
        }

        public IEnumerable<(Product, int)> ReturnAll()
        {
            IEnumerable<(Product, int)> returnItems = Products.Select( (el) => el ).ToList();

            Products.Clear();
            return returnItems;

        }

        

    }
}
