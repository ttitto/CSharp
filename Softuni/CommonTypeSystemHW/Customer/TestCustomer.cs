namespace Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestCustomer
    {
        public static void Main()
        {
            Customer pesho = new Customer(
                1234567890,
                "Petar",
                "Ivanov",
                "Petrov",
                "0884565250",
                "pesho@dir.bg",
                CustomerType.Diamond,
                new List<Payment>() { new Payment("Cosmo disk", 124.29m) });

            Customer misho = new Customer(
                1023456789,
                "Mihail",
                "Ivanov",
                "Mihailov",
                "0884565253",
                "misho@dir.bg",
                CustomerType.Golden,
                new List<Payment>() { new Payment("Cosmo disk", 124.29m), new Payment("magnitni nakolenki", 45.68m) });

            Customer gosho = new Customer(
                1203456789,
                "Georgi",
                "Borisov",
                "Georgiev",
                "0884565252",
                "goshko@dir.bg",
                CustomerType.Regular,
                new List<Payment>() { new Payment("magnitni nakolenki", 45.68m) });

            Customer goshoCopy = gosho;
            gosho.FirstName = "Genka";
            Console.WriteLine(gosho);
            Console.WriteLine(goshoCopy);
            Console.WriteLine(goshoCopy == gosho);
            Console.WriteLine(gosho.Equals(goshoCopy));
            Console.WriteLine(Object.ReferenceEquals(gosho, goshoCopy));

            goshoCopy = (Customer)gosho.Clone();
            goshoCopy.FirstName = "Gosho";
            goshoCopy.Payments.Add(new Payment("soleti", 2.03m));
            Console.WriteLine(gosho);
            Console.WriteLine(goshoCopy);
            Console.WriteLine(goshoCopy == gosho);
            Console.WriteLine(gosho.Equals(goshoCopy));
            Console.WriteLine(Object.ReferenceEquals(gosho, goshoCopy));
        }
    }
}