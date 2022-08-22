using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Of_Variables
{
    class Phone
    {
        public string strModel;
        public float fltPrice;
        public static int intCount;
        public static float fltTotalPrice;


        public Phone(string strModel, float fltPrice)
        {
            this.strModel = strModel;
            this.fltPrice = fltPrice;
            intCount++;
            fltTotalPrice += fltPrice;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone objP1;
            Phone objP2;
            Console.WriteLine("Enter Model: ");
            string model1 = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            float price1 = float.Parse(Console.ReadLine());
            objP1 = new Phone(model1, price1);
            Console.WriteLine("Enter Model 2: ");
            string model2 = Console.ReadLine();
            Console.WriteLine("Enter Price 2: ");
            float price2 = float.Parse(Console.ReadLine());
            objP2 = new Phone(model2, price2);

            Console.WriteLine("Model 1 {0} Price 1 {1}", objP1.strModel, objP2.fltPrice);
            Console.WriteLine("Model 2 {0} Price 2 {1}", objP2.strModel, objP2.fltPrice);
            Console.WriteLine("Total Phone {0}", Phone.intCount);
            Console.WriteLine("Total Peice {0}", Phone.fltTotalPrice);

        }
    }
}
