using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class PhoneBook
    {
        private List<Person> contacts;

        public PhoneBook()
        {
            contacts = new List<Person>();
        }

        public void AddContact()
        {
            Console.WriteLine("Enter the contact's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the contact's phone number:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the contact's address:");
            string address = Console.ReadLine();

            Person newContact = new Person
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Address = address
            };

            contacts.Add(newContact);
            Console.WriteLine("Contact added successfully.");
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
        public List<Person> GetContacts()
        {
            return contacts;
        }
    }

}

