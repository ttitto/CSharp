namespace CustomLINQExtMethods
{
    using System;
    using System.Collections.Generic;

    public class TestCustomLINQExtMethods
    {
        public static void Main()
        {
            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(string.Join(", ", numbers.WhereNot<int>(a => a == 4)));

            Console.WriteLine(string.Join(", ", numbers.Repeat<int>(4)));

            IEnumerable<string> stringItems = new List<string>() { "ala", "bala", "nica", "turska", "panica" };
            IEnumerable<string> suffixes = new List<string>() { "ala", "ka" };
            Console.WriteLine(string.Join(", ", stringItems.WhereEndsWith(suffixes)));
        }
    }
}