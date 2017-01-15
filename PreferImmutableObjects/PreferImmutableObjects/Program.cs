using System;

namespace PreferImmutableObjects
{
    class Program
    {
        static bool IsHappyHour { get; set; }

        static void Reserve(MoneyAmount cost)
        {
            if (IsHappyHour)
            {
                cost.Amount *= .5M;
            }

            Console.WriteLine("\nReserving an item that costs {0}", cost);
        }

        static void Buy(MoneyAmount wallet, MoneyAmount cost)
        {
            bool enounghMoney = wallet.Amount >= cost.Amount;
            Reserve(cost);
            if (enounghMoney)
            {
                Console.WriteLine("You will pay {0} with your {1}", cost, wallet);
            }
            else
            {
                Console.WriteLine("You cannot pay {0} with your {1}", cost, wallet);
            }
        }

        static void Main(string[] args)
        {
            Buy(new MoneyAmount() { Amount = 12, CurrencySymbol = "USD" },
                new MoneyAmount() { Amount = 10, CurrencySymbol = "USD" });
            Buy(new MoneyAmount() { Amount = 7, CurrencySymbol = "USD" },
                new MoneyAmount() { Amount = 10, CurrencySymbol = "USD" });

            IsHappyHour = true;

            Buy(new MoneyAmount() { Amount = 7, CurrencySymbol = "USD" },
                new MoneyAmount() { Amount = 10, CurrencySymbol = "USD" });

            Console.ReadLine();
        }
    }
}
