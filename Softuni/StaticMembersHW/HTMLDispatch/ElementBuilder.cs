using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatch
{
    class ElementBuilder
    {
        private string tag;
        private string opening;
        //private string attributes;
        private string content;
        private string closing;
        private bool isVoid;

        private string element;
        private bool isWholeElement;
        public ElementBuilder(string tag, bool isVoid = false)
        {
            this.Tag = tag;
            this.IsVoid = isVoid;
            //this.Attributes = string.Empty;
            this.Content = string.Empty;
            if (this.IsVoid)
            {
                this.Opening = "<" + this.Tag + " />";
                this.Closing = string.Empty;
            }
            else
            {
                this.Opening = "<" + this.Tag + ">";
                this.Closing = "</" + this.Tag + ">";
            }

        }
        private ElementBuilder(bool isWholeElement, string element)
        {
            this.element = element;
            this.isWholeElement = isWholeElement;
        }

        private string Tag
        {
            get { return this.tag; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.tag = value;
            }
        }

        public string Opening
        {
            get { return this.opening; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.opening = value;
            }
        }
        //public string Attributes
        //{
        //    get { return this.attributes; }
        //    set
        //    {
        //        if (null == value) throw new ArgumentNullException();
        //        this.attributes = value;
        //    }
        //}
        public string Content
        {
            get { return this.content; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.content = value;
            }
        }
        public string Closing
        {
            get { return this.closing; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.closing = value;
            }
        }

        public bool IsVoid
        {
            get { return this.isVoid; }
            set { this.isVoid = value; }
        }
        public static implicit operator ElementBuilder(String elStr)
        {
            return new ElementBuilder(true, elStr);
        }
        public static ElementBuilder operator *(ElementBuilder el1, int counter)
        {
            StringBuilder elementSB = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                elementSB.Append(el1.ToString());
            }
            return elementSB.ToString();
        }

        public string AddAttribute(string attr, string value)
        {
            //TODO:
            return string.Empty;
        }

        public override string ToString()
        {
            if (this.isWholeElement) return this.element;
            return this.Opening + this.Content + this.Closing;
        }

    }
}
