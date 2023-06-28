using Homework8;
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();
        ContactSearcher contactSearcher = new ContactSearcher(phoneBook.GetContacts());


        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Add a contact");
            Console.WriteLine("2. Search for a contact by name");
            Console.WriteLine("3. Search for a contact by phone number");
            Console.WriteLine("4. Exit");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    phoneBook.AddContact();
                    break;
                case "2":
                    Console.Write("Enter the name to search: ");
                    string name = Console.ReadLine();
                    List<Person> searchResultsByName = contactSearcher.SearchByName(name);

                    Console.WriteLine("Search Results by Name:");
                    foreach (Person contact in searchResultsByName)
                    {
                        Console.WriteLine("Name: " + contact.Name);
                        Console.WriteLine("Number: " + contact.PhoneNumber);
                        Console.WriteLine("Adress: " + contact.Address);
                        Console.WriteLine();
                    }
                    break;
                case "3":
                    Console.Write("Enter the phone number to search: ");
                    string phoneNumber = Console.ReadLine();
                    List<Person> searchResultsByPhoneNumber = contactSearcher.SearchByPhoneNumber(phoneNumber);

                    Console.WriteLine("Search Results by Phone Number:");
                    foreach (Person contact in searchResultsByPhoneNumber)
                    {
                        Console.WriteLine("Name: " + contact.Name);
                        Console.WriteLine("Number: " + contact.PhoneNumber);
                        Console.WriteLine("Adress: " + contact.Address);
                        Console.WriteLine();
                    }
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}