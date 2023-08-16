using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptrinhApc2.session5
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();


            while (true)
            {
                Console.WriteLine("Phone Book Menu:");
                Console.WriteLine("1. Add new phone");
                Console.WriteLine("2. Remove a phone");
                Console.WriteLine("3. Update phone number");
                Console.WriteLine("4. Search for a phone");
                Console.WriteLine("5. Sort phone by name");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        string phone = Console.ReadLine();
                        phoneBook.InsertPhone(name, phone);
                        break;
                    case 2:
                        Console.Write("Enter name: ");
                        string removeName = Console.ReadLine();
                        phoneBook.RemovePhone(removeName);
                        break;
                    case 3:
                        Console.Write("Enter name: ");
                        string updateName = Console.ReadLine();
                        Console.Write("Enter new phone number: ");
                        string newPhone = Console.ReadLine();
                        phoneBook.UpdatePhone(updateName, newPhone);
                        break;
                    case 4:
                        Console.Write("Enter name: ");
                        string searchName = Console.ReadLine();
                        phoneBook.SearchPhone(searchName);
                        break;
                    case 5:
                        phoneBook.Sort();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        } 
    }
}
