namespace Animals
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, Genders gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I say myauuu!");
        }
    }
}