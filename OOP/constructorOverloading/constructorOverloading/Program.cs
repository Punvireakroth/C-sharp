using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorOverloading
{
    class Book
    {
        private string strTitle;
        private float fltPrice;

        public string Title
        {
            get { return strTitle; }
            set { strTitle = value; }
        }
        public float Price
        {
            get { return fltPrice; }
            set { fltPrice = value; }
        }

        public Book()
        {

        }

        public Book(string strTitle, float fltPrice)
        {
            this.strTitle = strTitle;
            this.fltPrice = fltPrice;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book objBook1;
            objBook1 = new Book();
            Console.WriteLine("Enter title of the book: ");
            objBook1.Title = Console.ReadLine();
            Console.WriteLine("Enter price of the book: ");
            objBook1.Price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter title of the book 2: ");
            string t = Console.ReadLine();
            Console.WriteLine("Enter price of the book 2: ");
            float p = float.Parse(Console.ReadLine());
            Book objBook2 = new Book(t, p);

            Console.WriteLine("Book title 1: {0} Price{1}",objBook1.Title,objBook2.Price);
            Console.WriteLine("Book title 2: {0} Price{1},", objBook2.Title, objBook2.Price);

        }
    }
}
