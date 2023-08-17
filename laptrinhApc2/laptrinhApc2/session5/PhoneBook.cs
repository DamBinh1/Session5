using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptrinhApc2.session5
{
    public class PhoneBook : Phone
    {
        private List<Person> PhoneList = new List<Person>();

        public override void InsertPhone(string name, string phone)
        {
            Person Pers = PhoneList.Find(person => person.Name == name);

            if (Pers != null)
            {
                if (Pers.Phone != phone)
                {
                    Console.WriteLine($"Updated phone number for {name}");
                }
                else
                {
                    Console.WriteLine($"{name} already exists with the same phone number.");
                }
            }
            else
            {
                PhoneList.Add(new Person(name, phone));
                Console.WriteLine($"Added {name} with phone number {phone}");
            }
        }

        public override void RemovePhone(string name)
        {
            PhoneList.RemoveAll(person => person.Name == name);
            Console.WriteLine("Completed!");
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            Person personToUpdate = PhoneList.Find(person => person.Name == name);

            if (personToUpdate != null)
            {
                personToUpdate.Phone = newPhone;
                Console.WriteLine("Completed!");
            }
        }

        public override void SearchPhone(string name)
        {
            Person person = PhoneList.Find(p => p.Name == name);

            if (person != null)
            {
                Console.WriteLine($"Phone number for {name}: {person.Phone}");
            }
            else
            {
                Console.WriteLine($"{name} not found in the phonebook.");
            }
        }

        public override void Sort()
        {
            PhoneList.Sort((person1, person2) => person1.Name.CompareTo(person2.Name));
            Console.WriteLine("Phonebook sorted by name.");
            foreach (var person in PhoneList)
            {
                Console.WriteLine($"Name: {person.Name}, Phone: {person.Phone}");
            }
        }
    }
}
