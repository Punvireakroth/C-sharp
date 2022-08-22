using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_overloading
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
            Book objBook2;

            objBook1 = new Book();

            Console.WriteLine("Enter title1: ");
            objBook1.Title = Console.ReadLine();
            Console.WriteLine("Enter price1: ");
            objBook1.Price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter title2: ");
            string title2 = Console.ReadLine();
            Console.WriteLine("Enter price2: ");
            float price2 = float.Parse(Console.ReadLine());
            objBook2 = new Book(title2, price2);
            Console.WriteLine("Title Book 1: {0} Price Book 1: {1}", objBook1.Title, objBook1.Price);
            Console.WriteLine("Title Book 2: {0} Price Book 2: {1}", objBook2.Title, objBook2.Price);
            Console.ReadKey();
        }
    }
}
