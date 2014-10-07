namespace StringDisperser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        private StringBuilder totalString;

        public StringDisperser(params string[] strings)
        {
            this.TotalString = new StringBuilder();
            foreach (var str in strings)
            {
                this.TotalString.Append(str);
            }
        }

        public StringBuilder TotalString
        {
            get
            {
                return this.totalString;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("TotalString", "TotalString can not be null!");
                }

                this.totalString = value;
            }
        }

        public override string ToString()
        {
            return this.TotalString.ToString();
        }

        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;
            if (stringDisperser == null)
            {
                return false;
            }

            return this.TotalString.ToString().Equals(stringDisperser.TotalString.ToString());
        }

        public static bool operator ==(StringDisperser first, StringDisperser second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(StringDisperser first, StringDisperser second)
        {
            return !first.Equals(second);
        }

        public override int GetHashCode()
        {
            return this.TotalString.GetHashCode();
        }

        public object Clone()
        {
            StringDisperser newStringDisperser = this.MemberwiseClone() as StringDisperser;
            if (null == newStringDisperser)
            {
                throw new ArgumentNullException("Object can not be casted to type StringDisperser!");
            }

            newStringDisperser.TotalString = new StringBuilder().Append(this.TotalString.ToString());

            return newStringDisperser;
        }

        public int CompareTo(StringDisperser other)
        {
            return this.TotalString.ToString().CompareTo(other.TotalString.ToString());
        }



        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.TotalString.Length; i++)
            {
                yield return this.TotalString[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}