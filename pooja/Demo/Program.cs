using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Product
    {
        protected internal int productId = 1000;
        private string productName;
        public Product(string productName)
        {
            this.productName = productName;
        }
        public string DisplayProduct()
        {
            return productName;
        }
    }
    class Book : Product
    {
        private string bookId;

        public Book(string productName) : base(productName)
        {
            bookId = 'B' + (++productId).ToString();
        }
        public void Display()
        {
            Console.WriteLine("Book ID is: " + bookId);
        }
    }
    class Program
    {
        static void Main()
        {
            Book book = new Book("Alchemist");
            Console.WriteLine("{0} is the Product Id for the Product Name {1}", book.productId, book.DisplayProduct());
            book.Display();
        }
    }

}

