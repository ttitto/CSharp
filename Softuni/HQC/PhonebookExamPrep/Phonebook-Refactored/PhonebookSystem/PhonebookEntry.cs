namespace PhonebookSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PhonebookEntry : IComparable<PhonebookEntry>
    {
        private string contactName;
        private string contactNameLowerInvariant;

        public string ContactName
        {
            get
            {
                return this.contactName;
            }

            set
            {
                this.contactName = value;
                this.contactNameLowerInvariant = value.ToLowerInvariant();
            }
        }

        public SortedSet<string> PhoneNumbers { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            sb.Append(this.ContactName);
            bool isFirstPhoneNumber = true;

            // TODO: Use string.join after testing
            foreach (var phoneNumber in this.PhoneNumbers)
            {
                if (isFirstPhoneNumber)
                {
                    sb.Append(": ");
                    isFirstPhoneNumber = false;
                }
                else
                {
                    sb.Append(", ");
                }

                sb.Append(phoneNumber);
            }

            sb.Append(']');

            return sb.ToString();
        }

        public int CompareTo(PhonebookEntry other)
        {
            return this.contactNameLowerInvariant.CompareTo(other.contactNameLowerInvariant);
        }
    }
}
