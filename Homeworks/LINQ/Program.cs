namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Age} years old)";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 35 },
            new Person { Name = "Mary", Age = 28 },
        };

            
            persons.Add(new Person { Name = "Alice", Age = 22 });

            
            PerformLinqOperations(persons);
        }

        static void PerformLinqOperations(List<Person> persons)
        {
            Console.WriteLine("Original list of persons:");
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            
            var adults = persons.Where(p => p.Age >= 30);
            var sortedByName = persons.OrderBy(p => p.Name);
            var groupedByAge = persons.GroupBy(p => p.Age);

            
            Console.WriteLine("\nAdults (30 years or older):");
            foreach (var person in adults)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nSorted by name:");
            foreach (var person in sortedByName)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nGrouped by age:");
            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($" - {person}");
                }
            }
        }
    }
}