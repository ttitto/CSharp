namespace StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestStringBuilderExtensions
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder("Implement some extension methods for the class StringBuilder:");
            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(sb.Substring(8, 16));
            Console.WriteLine(sb.RemoveText("ion method"));
            Console.WriteLine(sb.AppendAll<int>(numbers));

            // Console.WriteLine(sb.AppendAll<long>(numbers)); //// compile time error
        }
    }
}