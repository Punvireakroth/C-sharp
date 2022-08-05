using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Car
    {
        public string strModel;
        public string strband;
        public float fltPrice;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car objCar1;
            objCar1 = new Car();

            Console.WriteLine("Enter Model car 1 ");
            objCar1.strModel = Console.ReadLine();
            Console.WriteLine("Enter brand car 1 ");
            objCar1.strband = Console.ReadLine();
            Console.WriteLine("Enter Price car 1 ");
            objCar1.fltPrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Model {0} Price {1} brand {2}", objCar1.strModel,objCar1.fltPrice, objCar1.strband);

            Car objCar2 = new Car();
            Console.WriteLine("Enter Model car 2 ");
            objCar2.strModel = Console.ReadLine();
            Console.WriteLine("Enter brand car 2 ");
            objCar2.strband = Console.ReadLine();
            Console.WriteLine("Enter price car 2 ");
            objCar2.fltPrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Model {0} Price {1} brand {2}", objCar2.strModel, objCar2.fltPrice, objCar2.strband);


        }
    }
}
