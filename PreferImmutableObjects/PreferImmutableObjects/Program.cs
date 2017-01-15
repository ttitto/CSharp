using System;

namespace PreferImmutableObjects
{
    class Program
    {
        static bool IsHappyHour { get; set; }

        static MoneyAmount Reserve(MoneyAmount cost)
        {
            decimal factor = 1;
            if (IsHappyHour)
            {
                factor = 0.5M;
            }

            Console.WriteLine("\nReserving an item that costs {0}", cost);
            return cost.Scale(factor);
        }

        static void Buy(MoneyAmount wallet, MoneyAmount cost)
        {
            bool enounghMoney = wallet.Amount >= cost.Amount;
            MoneyAmount finalCost = Reserve(cost);
            bool finalEnough = wallet.Amount >= finalCost.Amount;

            if (enounghMoney && finalEnough)
            {
                Console.WriteLine("You will pay {0} with your {1}", cost, wallet);
            }
            else if (finalEnough)
            {
                Console.WriteLine("This time, {0} will be enough to pay{1}", wallet, finalCost);
            }
            else
            {
                Console.WriteLine("You cannot pay {0} with your {1}", cost, wallet);
            }
        }

        static void Main(string[] args)
        {
            Buy(new MoneyAmount(12, "USD"),
                new MoneyAmount(10, "USD"));
            Buy(new MoneyAmount(7, "USD"),
                new MoneyAmount(10, "USD"));

            IsHappyHour = true;

            Buy(new MoneyAmount(7, "USD"),
                new MoneyAmount(10, "USD"));

            Console.ReadLine();
        }
    }
}
