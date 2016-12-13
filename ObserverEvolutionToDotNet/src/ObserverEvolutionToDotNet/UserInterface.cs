namespace ObserverEvolutionToDotNet
{
    using System;

    public class UserInterface
    {
        public void AfterDoSomethingWith(object sender, string data)
        {
            Console.WriteLine($"Hey user, look at {data.ToUpper()}");
        }
    }
}
