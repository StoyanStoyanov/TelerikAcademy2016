namespace GenericListImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class GenericList<T> : IList<T>
    {
        private T[] items;
        private int index;

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            items = new T[this.Capacity];
            this.index = 0;
        }

        public int Capacity { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index > 0 || index >= this.items.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.items[index];
            }

            set
            {
                if (index > 0 || index >= this.items.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                this.items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return this.index;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            this.items[this.index++] = item;

            if (this.index == this.items.Length)
            {
                this.DoubleSize();
            }
        }

        public void Clear()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.items[i] = default(T);
            }

            this.index = 0;
        }

        public bool Contains(T item)
        {
            var containsItem = false;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(item))
                {
                    containsItem = true;
                    break;
                }
            }

            return containsItem;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i < this.Count + arrayIndex; i++)
            {
                array[i] = this.items[i - arrayIndex];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return (T)this.items.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            var index = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void Insert(int index, T item)
        {
            if (index > 0 || index >= this.items.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.index + 1 == this.items.Length)
            {
                this.DoubleSize();
            }

            for (int i = this.Count - 1; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }

            this.items[index] = item;
            this.index++;
        }

        public bool Remove(T item)
        {
            var i = this.IndexOf(item);

            if (i == - 1)
            {
                return false;
            }

            this.RemoveAt(i);

            return true;
        }

        public void RemoveAt(int index)
        {
            if (index > 0 || index >= this.items.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.index--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void DoubleSize()
        {
            var resized = new T[this.items.Length * 2];
            this.items.CopyTo(resized, 0);

            this.items = resized;
        }
    }
}