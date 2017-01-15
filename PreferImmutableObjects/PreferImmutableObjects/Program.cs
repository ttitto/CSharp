using System;

namespace PreferImmutableObjects
{
    class Program
    {
        static bool IsHappyHour { get; set; }

        static MoneyAmount Reserve(MoneyAmount cost)
        {
            MoneyAmount newCost;
            if (IsHappyHour)
            {
                newCost = new MoneyAmount()
                {
                    Amount = cost.Amount * 0.5M,
                    CurrencySymbol = cost.CurrencySymbol
                };
            }
            else
            {
                newCost = cost;
            }

            Console.WriteLine("\nReserving an item that costs {0}", cost);
            return newCost;
        }

        static void Buy(MoneyAmount wallet, MoneyAmount cost)
        {
            bool enounghMoney = wallet.Amount >= cost.Amount;
            MoneyAmount finalCost = Reserve(cost);
            bool finalEnough = wallet.Amount >= finalCost.Amount;

            if (enounghMoney  && finalEnough)
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
