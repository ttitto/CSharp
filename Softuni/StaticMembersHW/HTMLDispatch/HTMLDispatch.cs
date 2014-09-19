using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatch
{
    class HTMLDispatchClass
    {
        static void Main(string[] args)
        {

            ElementBuilder div = new ElementBuilder("div");
            //div.AddAttribute("id", "page");
            //div.AddAttribute("class", "big");
            //div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 3);
            Console.WriteLine(div);



        }
    }
}
