using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_1
{
    internal class List<T> : IList<T>, IEnumerable<T>, IEnumerable
    {
        public List()
        {
            _list = new T[2];
            Count = 0;
        }

        private T[] _list;

        public int Capacity { get => _list.Length; } 
        public int Count { get; private set; }

        public T this[int index] 
        { 
            get => _list[index]; 
            set
            {
                while(index >= Capacity)
                {
                    T[] list = new T[Capacity * 2];
                    CopyTo(list, 0);
                    _list = list;
                }
                if (index >= Count)
                    Count = index + 1;
                _list[index] = value;
            }
        }

        public bool IsReadOnly => false;

        public void Add(T item) => this[Count] = item;

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public void Clear()
        {
            _list = new T[2];
            Count = 0;
        }

        public bool Contains(T item)
        {
            foreach (var el in this)
            {
                if (el.Equals(item))
                    return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int i = 0;
            foreach (var el in this)
            {
                array[arrayIndex + i] = this[i];
                i++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }

        public int IndexOf(T item)
        {
            int i = 0;
            foreach (var el in this)
            {
                if (item.Equals(el))
                    return i;
                i++;
            }
            return -1;
        }

        public void Insert(int index, T item) => this[index] = item;

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
                return false;

            RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            for(int i = index; i < Count - 1; i++)
            {
                this[i] = this[i + 1];
            }
            this[Count - 1] = default;
            Count--;
        }

        public void Sort() =>
             _list.Take(Count).OrderBy(el => el).ToArray().CopyTo(_list, 0);
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        

    }
}
