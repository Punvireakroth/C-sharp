using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Exercise01
{
    class Animal
    {
        private string strCountry;

        public string Country
        {
            get { return strCountry; }
        }

        public Animal(string strCountry)
        {
            this.strCountry = strCountry;
        }


    }

    class Cat : Animal
    {
        public string strSpecies;
        private int intNumber;

        public int Number
        {
            get { return intNumber; }
        }

        public Cat(string strSpecies, int intNumber, string country) : base (country)
        {
            this.strSpecies = strSpecies;
            this.intNumber = intNumber;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat objCat;
            Console.WriteLine("Enter cat country: ");
            string cat_country = Console.ReadLine();
            Console.WriteLine("Enter cat species: ");
            string cat_species = Console.ReadLine();
            Console.WriteLine("Enter cat amount: ");
            int amount_of_cat = int.Parse(Console.ReadLine());

            objCat = new Cat(cat_species, amount_of_cat, cat_country);

            Console.WriteLine("Cat species: {0}", objCat.strSpecies);
            Console.WriteLine("Amount of cat: {0}", objCat.Number);
            Console.WriteLine("Origin Country: {0}", objCat.Country);
            Console.ReadKey();

        }
    }
}
