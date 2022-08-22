using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Pun VireakRoth
namespace E2STEM_PT1
{
    class ComputerBrand
    {
        public string strBrandName;
        private float fltPrice;
        public float fltTotalPrice = 0.00f;

        public ComputerBrand(string b, float p)
        {
            this.strBrandName = b;
            this.fltPrice = p;
            fltTotalPrice += fltPrice;
        }

        public float Price
        {
            get { return fltTotalPrice; }
        }

        public string GetInfo()
        {
            return "computer brand: " + strBrandName + ", Price: $" + Price.ToString();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter computer brand #1: ");
            string brand1 = Console.ReadLine();
            Console.WriteLine("Enter price of computer #1: ");
            float price1 = float.Parse(Console.ReadLine());
            ComputerBrand ComObj1 = new ComputerBrand(brand1, price1);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter computer brand #2: ");
            string brand2 = Console.ReadLine();
            Console.WriteLine("Enter price of computer #2: ");
            float price2 = float.Parse(Console.ReadLine());
            ComputerBrand ComObj2 = new ComputerBrand(brand2, price2);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("SHOPPING CART: {0}", ComObj1.GetInfo().ToString());
            Console.WriteLine("SHOPPING CART: {0}", ComObj2.GetInfo().ToString());
            float fltTotalPrice = ComObj1.Price + ComObj2.Price;
            Console.WriteLine("The total price is ${0}", fltTotalPrice.ToString());

        }
    }
}
