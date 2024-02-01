using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework3.cl
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. List Books");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        RemoveBook();
                        break;
                    case 3:
                        LibraryManager.ListAllBooks();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddBook()
        {
            Console.Write("Enter Title");
            string title = Console.ReadLine();
            Console.Write("Enter Author");
            string author = Console.ReadLine();
            Console.Write("Enter Category");
            string category = Console.ReadLine();
            Console.Write("Enter Year");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter Price");
            decimal price = decimal.Parse(Console.ReadLine());

            Book newBook = new Book(title, new Author { }, category, year, price);
            LibraryManager.AddBook(newBook);
            Console.WriteLine("Book added successfully.");
        }

        static void RemoveBook()
        {
            Console.Write("Book title to remove: ");
            string title = Console.ReadLine();
            LibraryManager.RemoveBook(title);
        }
    }
}
       
