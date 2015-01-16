namespace PhonebookSystem.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PhonebookSystem.Interfaces;
    using Wintellect.PowerCollections;

    public class PhonebookRepositoryDictionary : IPhonebookRepository
    {
        private OrderedSet<PhonebookEntry> sortedPhonebookEntries = new OrderedSet<PhonebookEntry>();
        private IDictionary<string, PhonebookEntry> phonebookEntriesByContactName = new Dictionary<string, PhonebookEntry>();
        private MultiDictionary<string, PhonebookEntry> multiplePhonebookEntriesByContactName = new MultiDictionary<string, PhonebookEntry>(false);

        public bool AddPhone(string name, IEnumerable<string> phoneNumbers)
        {
            string contactNameLowerInvariant = name.ToLowerInvariant();
            PhonebookEntry phonebookEntry;

            bool entryDoesntExist = !this.phonebookEntriesByContactName.TryGetValue(contactNameLowerInvariant, out phonebookEntry);
            if (entryDoesntExist)
            {
                phonebookEntry = new PhonebookEntry();
                phonebookEntry.ContactName = name;
                phonebookEntry.PhoneNumbers = new SortedSet<string>();

                this.phonebookEntriesByContactName.Add(contactNameLowerInvariant, phonebookEntry);
                this.sortedPhonebookEntries.Add(phonebookEntry);
            }

            foreach (var phoneNumber in phoneNumbers)
            {
                this.multiplePhonebookEntriesByContactName.Add(phoneNumber, phonebookEntry);
            }

            phonebookEntry.PhoneNumbers.UnionWith(phoneNumbers);

            return entryDoesntExist;
        }

        public int ChangePhone(string oldPhoneNumber, string newPhoneNumber)
        {
            var foundPhonebookEntries = this.multiplePhonebookEntriesByContactName[oldPhoneNumber].ToList();
            foreach (var phonebookEntry in foundPhonebookEntries)
            {
                phonebookEntry.PhoneNumbers.Remove(oldPhoneNumber);
                this.multiplePhonebookEntriesByContactName.Remove(oldPhoneNumber, phonebookEntry);

                phonebookEntry.PhoneNumbers.Add(newPhoneNumber);
                this.multiplePhonebookEntriesByContactName.Add(newPhoneNumber, phonebookEntry);
            }

            return foundPhonebookEntries.Count;
        }

        public IEnumerable<PhonebookEntry> ListEntries(int first, int num)
        {
            if (first < 0 || first + num > this.phonebookEntriesByContactName.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid range");
            }

            PhonebookEntry[] list = new PhonebookEntry[num];

            for (int i = first; i <= first + num - 1; i++)
            {
                PhonebookEntry entry = this.sortedPhonebookEntries[i];
                list[i - first] = entry;
            }

            return list;
        }
    }
}
