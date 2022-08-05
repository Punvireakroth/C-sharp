using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndProperties
{
    class House
    {
        public string strType;
        private string strAddress;
        private float fltPrice;
        public string StrAddress
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        
        public float FltPrice
        {
            get { return fltPrice; }
            set { 
                if (value > 0){
                    fltPrice = value;
                } 
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            House hObj = new House();
            Console.WriteLine("Enter Adress ");
            hObj.StrAddress = Console.ReadLine();
            Console.WriteLine("Enter Type ");
            hObj.strType = Console.ReadLine();
            Console.WriteLine("Enter Price ");
            hObj.FltPrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Adress: {0} Type: {1} Price: {2}",hObj.StrAddress,hObj.strType,hObj.FltPrice);


        }
    }
}
