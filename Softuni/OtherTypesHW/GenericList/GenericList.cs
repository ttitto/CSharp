namespace GenericList
{
    using System;
    using System.Linq;
    using System.Text;

    [Version(0, 1)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int CAPACITY = 16;

        private T[] inner;
        private int size;
        private int capacity;

        public GenericList(int capacity = CAPACITY)
        {
            this.Size = 0;
            this.Capacity = capacity;
            this.Inner = new T[this.Capacity];
        }

        public T[] Inner
        {
            get
            {
                return this.inner;
            }

            protected set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Inner", "Inner array can not be null!");
                }

                this.inner = value;
            }
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("GenericList size can not be negative!");
                }

                this.size = value;

                if (value >= this.Capacity)
                {
                    this.DoubleSize();
                }
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("GenericList size can not be negative!");
                }

                this.capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.Size || index < 0)
                {
                    throw new IndexOutOfRangeException("The required index is invalid!");
                }

                return this.Inner[index];
            }

            set
            {
                if (index >= this.Size || index < 0)
                {
                    throw new IndexOutOfRangeException("The required index is invalid!");
                }

                this.Inner[index] = value;
            }
        }

        public void Add(T element)
        {
            this.Inner[this.Size] = element;
            this.Size++;
        }

        public void Insert(T element, int position)
        {
            T[] newArr = new T[this.Capacity];

            Array.Copy(this.Inner, newArr, position);
            Array.Copy(new T[1] { element }, 0, newArr, position, 1);
            Array.Copy(this.Inner, position, newArr, position + 1, this.Inner.Length - position - 2);

            this.Inner = newArr;
            this.Size++;
        }

        public void Remove(int position)
        {
            T[] newArr = new T[this.Capacity];

            Array.Copy(this.Inner, newArr, position);
            Array.Copy(this.Inner, position + 1, newArr, position, this.Inner.Length - position - 1);

            this.Inner = newArr;
            this.Size--;
        }

        public void Clear()
        {
            this.Inner = new T[CAPACITY];
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Inner[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            return this.Inner.Contains(element);
        }

        public T Min<T>()
        {
            return (dynamic)this.Inner.Min();
        }

        public T Max<T>()
        {
            return (dynamic)this.Inner.Max();
        }

        public override string ToString()
        {
            StringBuilder elementsSB = new StringBuilder();

            for (int i = 0; i < this.Size; i++)
            {
                elementsSB.Append(this.Inner[i]);

                if (i != this.Size - 1)
                {
                    elementsSB.Append(", ");
                }
            }

            return elementsSB.ToString();
        }

        private void DoubleSize()
        {
            this.Capacity *= 2;
            T[] newArr = new T[this.Capacity];

            for (int i = 0; i < this.Size; i++)
            {
                newArr[i] = this.Inner[i];
            }

            this.Inner = newArr;
        }
    }
}
