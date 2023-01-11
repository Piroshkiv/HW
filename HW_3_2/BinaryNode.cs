using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2
{
    public class BinaryNode<T> where T : IComparable<T> 
    {
        public BinaryNode(T item)
        {
            Value = item;
        }

        public T Value { get; set; }

        public BinaryNode<T>? Left { get; private set; }
        public BinaryNode<T>? Right { get; private set; }

        public void Add(T item)
        {
            AddNode(new(item));
        }

        public void AddNode(BinaryNode<T> item)
        {
            if (Value.CompareTo(item.Value) == 0)
            {
                Value = item.Value;
                if (item.Right != null)
                    AddNode(item.Right);
                if(item.Left != null)
                    AddNode(item.Left);
            }
            else if (Value.CompareTo(item.Value) > 0)
            {
                if (Left is null)
                    Left = item;
                else
                    Left.AddNode(item);
            }
            else if (Value.CompareTo(item.Value) < 0)
            {
                if (Right is null)
                    Right = item;
                else
                    Right.AddNode(item);
            }
        }

        public IEnumerable<T> GetPreOrder()
        {
            if (Left != null)
            {
                foreach (var item in Left.GetPreOrder())
                {
                    yield return item;
                }
            }
            yield return Value;
            if (Right != null)
            {
                foreach (var item in Right.GetPreOrder())
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<T> GetPostOrder()
        {
            if (Right != null)
            {
                foreach (var item in Right.GetPreOrder())
                {
                    yield return item;
                }
            }
            yield return Value;
            if (Left != null)
            {
                foreach (var item in Left.GetPreOrder())
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<T> GetInOrder()
        {
            yield return Value;
            if (Left != null)
            {
                foreach (var item in Left.GetPreOrder())
                {
                    yield return item;
                }
            }
            if (Right != null)
            {
                foreach (var item in Right.GetPreOrder())
                {
                    yield return item;
                }
            }
        }

        public BinaryNode<T>? Remove(T item)
        {
            if (Value.CompareTo(item) == 0)
            {
                return this;
            }
            else if (Value.CompareTo(item) > 0)
            {
                if (Left?.Value.CompareTo(item) == 0)
                {
                    BinaryNode<T> node = Left;
                    Left = null;
                    return node;
                }
                else
                {
                    return Left?.Remove(item);
                }
            }
            else if (Value.CompareTo(item) < 0)
            {
                if (Right?.Value.CompareTo(item) == 0)
                {
                    BinaryNode<T> node = Right;
                    Right = null;
                    return node;
                }
                else
                {
                    return Right?.Remove(item);
                }
            }

            return null;
        }
    }
}
