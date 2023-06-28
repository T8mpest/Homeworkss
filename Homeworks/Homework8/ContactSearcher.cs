using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class ContactSearcher
    {
        private List<Person> contacts;

        public ContactSearcher(List<Person> contacts)
        {
            this.contacts = contacts;
        }

        public List<Person> SearchByName(string name)
        {
            List<Person> searchResults = new List<Person>();

            foreach (Person contact in contacts)
            {
                if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    searchResults.Add(contact);
                }
            }

            return searchResults;
        }

        public List<Person> SearchByPhoneNumber(string phoneNumber)
        {
            List<Person> searchResults = new List<Person>();

            foreach (Person contact in contacts)
            {
                if (contact.PhoneNumber.Equals(phoneNumber))
                {
                    searchResults.Add(contact);
                }
            }

            return searchResults;
        }
    }
}
