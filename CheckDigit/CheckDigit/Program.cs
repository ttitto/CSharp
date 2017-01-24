namespace CheckDigit
{
    class Program
    {
        static int GetControllDigit(long number)
        {
            int sum = 0;
            bool isOddPos = true;
            while (number > 0)                      // infrastructure
            {
                int digit = (int)(number % 10);     // infrastructure
                if (isOddPos)                       // domain
                {
                    sum += 3 * digit;               // 3 = parameter
                }
                else
                {
                    sum += digit;
                    number /= 10;                   // infrastructure
                    isOddPos = !isOddPos;           // domain
                }
            }

            int modulo = sum % 7;                   // 7 = parameter
            return modulo;                          // % = domain
        }

        static void Main(string[] args)
        {
            int digit = GetControllDigit(12345);
        }
    }
}
