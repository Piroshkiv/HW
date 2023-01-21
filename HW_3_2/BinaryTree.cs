using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_3_2
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T> 
    {
        public IEnumerable<T> GetPreOrder { get => First?.Order(BinaryOrderType.PreOrder); }
        public IEnumerable<T> GetPostOrder { get => First?.Order(BinaryOrderType.PreOrder); }
        private BinaryNode<T>? First { get; set; }

        public void Add(T item)
        {
            if (First is null)
                First = new(item);
            else
                First.Add(item);
        }
        public bool Remove(T item)
        {
            if (First.Value.CompareTo(item) == 0)
            {
                BinaryNode<T> left = First.Left;
                BinaryNode<T> right = First.Right;
                if(left != null)
                {
                    First = left;
                    First.AddNode(right);
                }
                else
                {
                    First = right;
                }
                return true;
            }
            else
            {
                BinaryNode<T> node = First.Remove(item);
                if (node == null)
                    return false;
                if (node.Left != null)
                    First.AddNode(node.Left);
                if (node.Right != null)
                    First.AddNode(node.Right);

                return true;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in First.Order(BinaryOrderType.InOrder))
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
