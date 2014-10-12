namespace StringDisperser
{
    using System;

    public class TestStringDisperser
    {
        public static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            StringDisperser stringDisperserCopy = (StringDisperser)stringDisperser.Clone();
            stringDisperserCopy.TotalString.Append("petko");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
            foreach (var ch in stringDisperserCopy)
            {
                Console.Write(ch + " ");
            }

        }
    }
}