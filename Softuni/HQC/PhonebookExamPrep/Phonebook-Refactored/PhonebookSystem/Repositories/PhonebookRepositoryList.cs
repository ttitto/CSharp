namespace PhonebookSystem.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PhonebookSystem.Interfaces;

    public class PhonebookRepositoryList : IPhonebookRepository
    {
        private List<PhonebookEntry> entries = new List<PhonebookEntry>();

        public bool AddPhone(string name, IEnumerable<string> nums)
        {
            var old = from e in this.entries
                      where e.ContactName.ToLowerInvariant() == name.ToLowerInvariant()
                      select e;

            bool flag;
            if (old.Count() == 0)
            {
                PhonebookEntry obj = new PhonebookEntry();
                obj.ContactName = name;
                obj.PhoneNumbers = new SortedSet<string>();

                foreach (var num in nums)
                {
                    obj.PhoneNumbers.Add(num);
                }

                this.entries.Add(obj);
                flag = true;
            }
            else if (old.Count() == 1)
            {
                PhonebookEntry obj2 = old.First();
                foreach (var num in nums)
                {
                    obj2.PhoneNumbers.Add(num);
                }

                flag = false;
            }
            else
            {
                Console.WriteLine("Duplicated name in the phonebook found: " + name);
                return false;
            }

            return flag;
        }

        public int ChangePhone(string oldent, string newent)
        {
            var list = from e in this.entries
                       where e.PhoneNumbers.Contains(oldent)
                       select e;

            int nums = 0;
            foreach (var entry in list)
            {
                entry.PhoneNumbers.Remove(oldent);
                entry.PhoneNumbers.Add(newent);
                nums++;
            }

            return nums;
        }

        public IEnumerable<PhonebookEntry> ListEntries(int startEntryPosition, int entriesCount)
        {
            if (startEntryPosition < 0 || startEntryPosition + entriesCount > this.entries.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid start index or count.");
            }

            this.entries.Sort();

            var phonebookEntry = new PhonebookEntry[entriesCount];

            for (int i = startEntryPosition; i <= startEntryPosition + entriesCount - 1; i++)
            {
                PhonebookEntry entry = this.entries[i];
                phonebookEntry[i - startEntryPosition] = entry;
            }

            return phonebookEntry;
        }
    }
}
