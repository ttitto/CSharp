namespace SquareRoot
{
    using System;

    public class SquareRootClass
    {
        public static void Main()
        {
            try
            {
                int num = int.Parse(Console.ReadLine());

                double result = Math.Sqrt(num);

                Console.WriteLine(result);
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number!");
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Square root calculation error!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
