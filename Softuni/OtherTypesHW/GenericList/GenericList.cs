namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenericList<T>
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
            T[] newArr = new T[this.Capacity * 2];

            for (int i = 0; i < this.Size; i++)
            {
                newArr[i] = this.Inner[i];
            }
        }
    }
}
