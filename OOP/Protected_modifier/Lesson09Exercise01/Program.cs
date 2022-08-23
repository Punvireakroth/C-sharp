using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09Exercise01
{
    class Cinema
    {
        private string strCinemaName;
        protected static int intTicketSold;
        protected static float fltTicketSales;

        public string CinemaName
        {
            get { return strCinemaName; }
        }

        public Cinema(string strCinemaName)
        {
            this.strCinemaName = strCinemaName;
        }

        public static int TicketSold()
        {
            return intTicketSold;
        }
        public static float GetTicketPrice()
        {
            return fltTicketSales;
        }
    }
    class Ticket : Cinema
    {
        private string strMovie;
        private float fltTicketPrice;

        public Ticket(string strMovie, float fltTicketPrice, string cinemaname): base(cinemaname)
        {
            this.strMovie = strMovie;
            this.fltTicketPrice = fltTicketPrice;
            fltTicketPrice += fltTicketSales;
            intTicketSold++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket objT1;
            Ticket objT2;
            Console.WriteLine("Enter cinema: ");
            string cinema = Console.ReadLine();
            Console.WriteLine("Enter cinema: ");
            string movie = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            float price = float.Parse(Console.ReadLine());

            objT1 = new Ticket(movie, price, cinema);
            Console.WriteLine("Enter cinema: ");
            cinema = Console.ReadLine();
            Console.WriteLine("Enter cinema: ");
            movie = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            price = float.Parse(Console.ReadLine());
            objT2 = new Ticket(movie, price, cinema);
            Console.WriteLine("Cinema name: {0}", objT1.CinemaName);
            Console.WriteLine("Cinema name: {0}", objT2.CinemaName);

            Console.WriteLine("Total number of ticket sold: " + Cinema.TicketSold());
            Console.WriteLine("Total number of ticket sold: " + Cinema.TicketSold());


        }
    }
}
