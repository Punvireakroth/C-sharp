using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Computer
    {
        private string strBrand;
        private float fltPrice;

        public Computer(string strBrand, float fltPrice)
        {
            this.strBrand = strBrand;
            this.fltPrice = fltPrice;
        }
        public float UpdatePrice()
        {
            return fltPrice;
        }

        public float UpdatePrice(string model)
        {
            if (model == "IdeaPad")
            {
                fltPrice = fltPrice * 0.90f;
            }else if (model == "Aspire")
            {
                fltPrice = fltPrice * 0.19f;
            }else if (model == "zBook")
            {
                fltPrice = fltPrice * 0.29f;
            }
            return fltPrice;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter brand: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            float price = float.Parse(Console.ReadLine());

            Computer cObj = new Computer(brand, price);
            Console.WriteLine("Price = {0}",cObj.UpdatePrice().ToString());

            Console.WriteLine("Enter model");
            string model = Console.ReadLine();
            Console.WriteLine("This model cost = {0}", cObj.UpdatePrice(model).ToString());
        }
    }
}
