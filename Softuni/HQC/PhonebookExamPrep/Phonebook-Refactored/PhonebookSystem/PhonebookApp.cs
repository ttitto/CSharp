namespace PhonebookSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using PhonebookSystem.Interfaces;
    using PhonebookSystem.Repositories;
    using Wintellect.PowerCollections;

    public class PhonebookApp
    {
        private const string DefaultCountryCode = "+359";
        private static IPhonebookRepository phonebookRepository = new PhonebookRepositoryDictionary();
        private static StringBuilder output = new StringBuilder();

        public static void Main()
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End" || command == null)
                {
                    break;
                }

                if (!command.EndsWith(")"))
                {
                    throw new InvalidOperationException("Invalid command!");
                }

                int indexOfFirstParenthesis = command.IndexOf('(');
                if (indexOfFirstParenthesis == -1)
                {
                    throw new InvalidOperationException("Invalid command!");
                }

                string commandName = command.Substring(0, indexOfFirstParenthesis);

                string commandPhoneNumbers = command.Substring(indexOfFirstParenthesis + 1, command.Length - indexOfFirstParenthesis - 2);
                string[] phoneNumbers = commandPhoneNumbers.Split(',');

                for (int j = 0; j < phoneNumbers.Length; j++)
                {
                    phoneNumbers[j] = phoneNumbers[j].Trim();
                }

                if (commandName.StartsWith("AddPhone") && phoneNumbers.Length >= 2)
                {
                    ExecuteCommand("AddPhone", phoneNumbers);
                }
                else if ((commandName == "ChangePhone") && (phoneNumbers.Length == 2))
                {
                    ExecuteCommand("ChangePhone", phoneNumbers);
                }
                else if ((commandName == "List") && (phoneNumbers.Length == 2))
                {
                    ExecuteCommand("List", phoneNumbers);
                }
                else
                {
                    throw new InvalidOperationException("Invalid command name.");
                }
            }

            Console.Write(output);
        }

        private static void ExecuteCommand(string commandName, string[] comandArguments)
        {
            if (commandName == "AddPhone")
            {
                string contactName = comandArguments[0];
                var phoneNumbers = new List<string>();
                for (int i = 1; i < comandArguments.Count(); i++)
                {
                    phoneNumbers.Add(ConverToCanonicalPhoneNumber(comandArguments[i]));
                }

                bool isNewPhoneNumber = phonebookRepository.AddPhone(contactName, phoneNumbers);

                if (isNewPhoneNumber)
                {
                    Print("Phone entry created");
                }
                else
                {
                    Print("Phone entry merged");
                }
            }
            else if (commandName == "ChangePhone")
            {
                Print(phonebookRepository.ChangePhone(ConverToCanonicalPhoneNumber(comandArguments[0]), ConverToCanonicalPhoneNumber(comandArguments[1])) + " numbers changed");
            }
            else
            {
                try
                {
                    IEnumerable<PhonebookEntry> entries = phonebookRepository.ListEntries(int.Parse(comandArguments[0]), int.Parse(comandArguments[1]));
                    foreach (var entry in entries)
                    {
                        Print(entry.ToString());
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Print("Invalid range");
                }
            }
        }

        public static string ConverToCanonicalPhoneNumber(string phoneNumberInput)
        {
            StringBuilder canonicalPhoneNumber = new StringBuilder();

            foreach (char symbol in phoneNumberInput)
            {
                if (char.IsDigit(symbol) || (symbol == '+'))
                {
                    canonicalPhoneNumber.Append(symbol);
                }
            }

            if (canonicalPhoneNumber.Length >= 2 && canonicalPhoneNumber[0] == '0' && canonicalPhoneNumber[1] == '0')
            {
                canonicalPhoneNumber.Remove(0, 1);
                canonicalPhoneNumber[0] = '+';
            }

            while (canonicalPhoneNumber.Length > 0 && canonicalPhoneNumber[0] == '0')
            {
                canonicalPhoneNumber.Remove(0, 1);
            }

            if (canonicalPhoneNumber.Length > 0 && canonicalPhoneNumber[0] != '+')
            {
                canonicalPhoneNumber.Insert(0, DefaultCountryCode);
            }

            return canonicalPhoneNumber.ToString();
        }

        private static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}