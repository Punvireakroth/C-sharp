using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04Exercise01
{
    class Computer
    {
        private string strBrand;
        private float fltPrice;


        // Constructor
        public Computer(string strBrand, float fltPrice)
        {
            this.strBrand = strBrand;
            this.fltPrice = fltPrice;
        }
        // first method 
        public float UpdatePrice()
        {
            return fltPrice;
        }

        // second method 

        public float UpdatePrice(string model)
        {
            if(model == "IdeaPad")
            {
                fltPrice = fltPrice * 0.10f;
            }else if(model == "Aspire")
            {
                fltPrice = fltPrice * 0.20f;
            }else if(model == "ZBook")
            {
                fltPrice = fltPrice * 0.30f;
            }
            return fltPrice;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Brand: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            float price = float.Parse(Console.ReadLine());
            Computer cObj = new Computer(brand, price);

            Console.WriteLine("Price: ${0}", cObj.UpdatePrice());

            Console.WriteLine("Enter model: ");
            string model = Console.ReadLine();
            Console.WriteLine("This model cost: ${0}", cObj.UpdatePrice(model));

        }
    }
}
