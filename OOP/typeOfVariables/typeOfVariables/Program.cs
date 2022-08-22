using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeOfVariables
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
            Console.WriteLine("Enter model")
        }
    }
}
