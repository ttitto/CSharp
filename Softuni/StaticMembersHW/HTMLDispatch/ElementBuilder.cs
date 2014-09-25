namespace HTMLDispatch
{
    using System;
    using System.Text;

    class ElementBuilder
    {
        private string tag;
        private string opening;
        private string content;
        private string closing;
        private bool isVoid;

        public ElementBuilder(string tag, bool isVoid = false)
        {
            this.Tag = tag;
            this.IsVoid = isVoid;
            //this.Attributes = string.Empty;
            this.Content = string.Empty;
            this.Opening = "<" + this.Tag + ">";
            if (this.IsVoid)
            {
                //this.Opening = "<" + this.Tag + " />";
                this.Closing = string.Empty;
            }
            else
            {
                this.Closing = "</" + this.Tag + ">";
            }


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

        /// <summary>
        /// Holds the type of the HTML element
        /// It is true if the HTML element is void and can not have any content
        /// </summary>
        public bool IsVoid
        {
            get { return this.isVoid; }
            set { this.isVoid = value; }
        }

        /// <summary>
        /// Overloads the * operator to work with ElementBuilder objects
        /// </summary>
        /// <param name="elBld"></param>Instance of ElementBuilder class
        /// <param name="counter"></param>Repetition count
        /// <returns></returns>
        public static string operator *(ElementBuilder elBld, int counter)
        {
            StringBuilder elementSB = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                elementSB.Append(elBld.ToString());
            }
            return elementSB.ToString();
        }

        /// <summary>
        /// Inserts a new attribute-value pair in the opening tag of a HTML element
        /// </summary>
        /// <param name="attr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string AddAttribute(string attr, string value)
        {
            this.Opening = this.Opening.TrimEnd(new[] { '/', '>', ' ' }) + string.Format(" {0}=\"{1}\"", attr, value);
            this.Opening += ">";

            return this.Opening;
        }

        /// <summary>
        /// Adds content to a HTML element, if it is not void
        /// </summary>
        /// <param name="content"></param>
        public void AddContent(string content)
        {
            if (!this.IsVoid)
            {
                this.Content = content;
            }
            else throw new ArgumentException("Void HTML Elements can not have content");
        }

        public override string ToString()
        {
            return this.Opening + this.Content + this.Closing;
        }

    }
}
