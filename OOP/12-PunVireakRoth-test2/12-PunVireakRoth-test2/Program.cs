using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_PunVireakRoth_test2
{
    // Part 1: Base Class
    class TVBrand
    {
        protected static string strBrandName;
        private float fltPrice;

        // constructor

        public TVBrand(string BrandName, float fltPrice)
        {
            strBrandName = BrandName;
            this.fltPrice = fltPrice;
        }

        // property

        public float Price
        {
            get { return fltPrice; }
        }

        // overriten method

        public virtual string GetInfo()
        {
            return "TV brand: " + 
                strBrandName + 
                ", Price: $" + 
                fltPrice;
        }
    }
    // Part 2 Derived Class
    class TVType : TVBrand
    {
        private string strType;
        public TVType(string strType, string brandname, float price): base(brandname, price)
        {
            this.strType = strType;
        }
        // constructor

        public override string GetInfo()
        {
            return "TV brand: " +
                strBrandName + 
                ", Type: " + 
                strType +
                ", Price: $" +
                Price;
        }

        public float GetFinalPrice(string isMember)
        {
            if (isMember == "Y")
            {
                return (Price - Price * (5/100f));
            }
            else
            {
                return Price;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TVType TVobj1;
            TVType TVobj2;

            Console.WriteLine("Enter TV brand #1: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter type of TV #1: ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter price of TV #1: ");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            TVobj1 = new TVType(type, brand, price);

            Console.WriteLine("Enter TV brand #2: ");
            brand = Console.ReadLine();
            Console.WriteLine("Enter type of TV #2: ");
            type = Console.ReadLine();
            Console.WriteLine("Enter price of TV #2: ");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            TVobj2 = new TVType(type, brand, price);

            // j 
            Console.WriteLine("SHOPPING CART: {0}", TVobj1.GetInfo());
            Console.WriteLine("SHOPPING CART: {0}", TVobj2.GetInfo());

            // k 

            Console.WriteLine("Are you a member (Y/N)? ");
            string response = Console.ReadLine();

            Console.WriteLine("The total price is ${0}", TVobj1.GetFinalPrice(response) + TVobj2.GetFinalPrice(response));

            Console.ReadKey();
        }
    }
}
