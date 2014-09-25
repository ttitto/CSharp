namespace HTMLDispatch
{
    using System;

    class HTMLDispatchClass
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div);

            Console.WriteLine(div * 2);

            string myImage = HTMLDispatcher.CreateImage("../img/mnoo_qk.jpg", "selfi", "me on the beech");
            Console.WriteLine(myImage);

            string myLink = HTMLDispatcher.CreateURL("http://www.w3schools.com/html/", "this is my title", "Visit our HTML tutorial");
            Console.WriteLine(myLink);

            string myInput = HTMLDispatcher.CreateInput("number", "quantity", "230");
            Console.WriteLine(myInput);
        }
    }
}
