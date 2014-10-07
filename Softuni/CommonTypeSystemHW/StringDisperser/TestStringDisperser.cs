namespace StringDisperser
{
    using System;

    public class TestStringDisperser
    {
        public static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
        }
    }
}