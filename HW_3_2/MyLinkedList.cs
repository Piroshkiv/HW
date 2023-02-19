 
using System.Collections;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_3_1
{
    public class MyLinkedList<T>: IEnumerable<T>, IEnumerable
    {
        public LinkedNode<T>? First { get; private set; }
        public LinkedNode<T>? Last { get; private set; }

        public int Count
        {
            get
            {
                if (First == null)
                    return 0;

                int index = 0;
                LinkedNode<T> left = First;
                while (left != null)
                {
                    index++;
                    left = left.Next;
                }
                return index;
            }
        }

        public T this[int index]
        {
            get
            {
                return GetNode(index).Value;
            }
            set
            {
                GetNode(index).Value = value;
            }
        }
        public void Add(T item)
        {
            if(First is null)
            {
                First = new (item);
                Last = First;
            }
            else
            {
                LinkedNode<T> node = new (item);
                Last.Next = node;
                Last = node;
            }

        }

        public void AddAfter(int index, T item)
        {
            LinkedNode<T> rightNode = new(item);
            LinkedNode<T> leftNode = GetNode(index);
            rightNode.Next = leftNode.Next;
            leftNode.Next = rightNode;
            if (leftNode == Last)
                Last = rightNode;
        }

        public void AddBefore(int index, T item)
        {
            if (index > 0)
            {
                AddAfter(index - 1, item);
            }
            else
            {
                LinkedNode<T> leftNode = new(item);
                LinkedNode<T> rightNode = First;
                leftNode.Next = rightNode;
                First = rightNode;
            }

        }

        public T Find(T item)
        {
            foreach (var el in this)
            {
                if (el.Equals(item))
                    return el;
            }
            throw new ArgumentOutOfRangeException();
        }

        public int IndexOf(T item)
        {
            int i = 0;
            foreach (var el in this)
            {
                if (el.Equals(item))
                    return i;
                i++;
            }
            return -1;
        }

        public void DeleteAt(int index)
        {
            if(index == 0)
            {
                First = GetNode(1);
            }
            else if (index == Count-1)
            {
                Last = GetNode(Count - 2);
                Last.Next = null;
            }
            else
            {
                LinkedNode<T> node = GetNode(index);
                GetNode(index - 1).Next = node.Next;
            }
        }

        public bool Delete(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
                return false;
            DeleteAt(index);
            return false;
        }

        private IEnumerable<LinkedNode<T>> GetNodes()
        {
            LinkedNode<T> left = First;

            while (!(left is null))
            {
                yield return left;
                left = left.Next;
            }
        }

        private LinkedNode<T> GetNode(int index)
        {
            int i = 0;
            foreach (var item in GetNodes())
            {
                if (i++ == index)
                    return item;
            }
            throw new IndexOutOfRangeException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in GetNodes())
            {
                yield return item.Value;
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
