using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04Exercise02
{
    class Vehicle
    {
        private string strModel;
        private float fltPrice;

        public Vehicle(string strModel, float fltPrice)
        {
            this.strModel = strModel;
            this.fltPrice = fltPrice;
        }

        public float GetPrice(float coe)
        {
            fltPrice += coe;
            return fltPrice;
        }

        public float GetPrice(string cat)
        {
            if(cat == "A")
            {
                fltPrice += 30000.00f;
            }else if (cat == "B")
            {
                fltPrice += 39000.00f;
            }else if (cat == "C")
            {
                fltPrice += 31000.0f;
            }
            return fltPrice;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            float price = float.Parse(Console.ReadLine());

            Vehicle v1Obj = new Vehicle(model, price);

            Console.WriteLine("Please enter the coe");
            float coe = float.Parse(Console.ReadLine());
            Console.WriteLine("Price coe: ${0}", v1Obj.GetPrice(coe));


            Console.WriteLine("Enter model: ");
            string model2 = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            float price2 = float.Parse(Console.ReadLine());
            Vehicle v2Obj = new Vehicle(model2, price2);


            Console.WriteLine("Please enter the cat");
            string cat = Console.ReadLine();
            Console.WriteLine("Price coe: ${0}", v2Obj.GetPrice(cat));

        }
    }
}
