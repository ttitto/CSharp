namespace Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, Genders gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I say bauuu!");
        }
    }
}