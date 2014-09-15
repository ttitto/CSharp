using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalogue
{
    class Computer
    {
        private string name;
        private IList<Component> components;
        //private decimal price;

        public Computer(string name)
        {
            this.Name = name;
            this.Components = new List<Component>();
        }

        public Computer(string name, IList<Component> components)
            : this(name)
        {
            this.Components = components;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public IList<Component> Components
        {
            get { return this.components; }
            set
            {
                if (null == value) throw new ArgumentNullException("Computer components can not be null!");
                this.components = value;
            }

        }

        public decimal Price
        {
            get { return this.Components.Sum(a => a.Price); }
        }
      
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Name: {0}\nPrice: {1:C}\nComponents:\n",this.Name, this.Price);

            foreach (Component component in this.Components)
            {
                sb.AppendLine(component.ToString());
            }
           
            return sb.ToString();
        }

    }
}
