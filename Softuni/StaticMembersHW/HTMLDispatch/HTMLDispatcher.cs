namespace HTMLDispatch
{
   static class HTMLDispatcher
    {
       public static string CreateImage(string imgSrc, string alt, string title){

           ElementBuilder img = new ElementBuilder("img", true);
           img.AddAttribute("src", imgSrc);
           img.AddAttribute("alt", alt);
           img.AddAttribute("title", title);

           return img.ToString();
       }

       public static string CreateURL(string url, string title, string text)
       {
           ElementBuilder anchor=new ElementBuilder("a");
           anchor.AddAttribute("url", url);
           anchor.AddAttribute("title", title);
           anchor.AddContent(text);

           return anchor.ToString();
       }

       public static string CreateInput(string type, string name, string value)
       {
           ElementBuilder inp = new ElementBuilder("input",true);
           inp.AddAttribute("type", type);
           inp.AddAttribute("name", name);
           inp.AddAttribute("value", value);

           return inp.ToString();
       }
    }
}
