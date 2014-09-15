using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop
{
   public class Battery
    {
       private string type;
       public Battery(string type)
       {
           this.Type = type;
       }
       public string Type {
           get { return this.type;}
           set { this.type = value; }
       }
    }
}
