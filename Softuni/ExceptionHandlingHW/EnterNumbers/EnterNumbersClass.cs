namespace EnterNumbers
{
    using System;

    public class EnterNumbersClass
    {
        public static void Main()
        {
            int counter = 0;
            int start = 1;

            while (counter < 10)
            {
                try
                {
                    int currentNum = ReadNumbers(start, 100);

                    if (currentNum > start)
                    {
                        start = currentNum;
                    }

                    counter++;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("{0} Repeat input!", fex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Repeat input!", ex.Message);
                }
            }
        }

        public static int ReadNumbers(int start, int end)
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= start || num > end)
            {
                throw new ArgumentException("The number is outside of the requested range!");
            }

            return num;
        }
    }
}
