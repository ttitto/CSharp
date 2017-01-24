namespace CheckDigit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int digit = ControlDigitsAlgorithms.ForSalesDepartment.GetControllDigit(12345);
            Console.WriteLine(digit);
        }
    }
}
