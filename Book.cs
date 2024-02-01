using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.cl
{
    public class Book
    {
        public string Title { get; set; }
        public Author _author { get; set; }
        public string BookCategory { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }


        public Book() { }

        public Book(string title, Author author, string category, int year, decimal price) 
        {
            Title = title;
            _author = author;
            BookCategory = category;
            Year = year;
            Price = price;
        }
    }

    public class Author
    {
        private string _name { get; set; }
        private string _biography { get; set; }

        public Author() { }

        public Author(string name, string biography)
        {
            _name = name;
            _biography = biography;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Biography
        {
            get { return _biography; }
            set { _biography = value; }
        }
    }

    public sealed class Category
    {
        private string _categoryName { get; set; }
        private string _description { get; set; }

        public Category(string categoryName, string description)
        {
            _categoryName = categoryName;
            _description = description;
        }

        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }

    public static class LibraryManager
    {
        private static List<Book> books = new List<Book>();
        public static void AddBook(Book book)
        {
           books.Add(book);
            
        }

        public static void RemoveBook(string title)
        {
            Book bookremove = books.Find(b => b.Title == title);

            if (bookremove != null)
            {
                books.Remove(bookremove);
                Console.WriteLine("Book removed.");
            }
            else
            {
                Console.WriteLine("Not found.");
            }
        }

        public static void ListAllBooks()
        {
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book._author}, Category: {book.BookCategory}, Year: {book.Year}, Price: {book.Price}");
                }
         }
            
    }
}

