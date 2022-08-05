using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseOne
{
    class Rectangle
    {
        private float fltLength;
        private float fltBreadth;

        public float Area
        {
            get { return fltLength * fltBreadth; }
        }


        public Rectangle(float a, float b)
        {
            this.fltLength = a;
            this.fltBreadth = b;
        }

        public string GetSize()
        {
            return "The length and breadth of the rectangle is" + fltLength.ToString() + "cm " + fltBreadth.ToString();
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            Rectangle r2;


            Console.WriteLine("Length 1 : ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Bredth 1 : ");
            float breadth = float.Parse(Console.ReadLine());

            r1 = new Rectangle(length, breadth);
            Console.WriteLine(r1.GetSize());

            Console.WriteLine("Length 2 : ");
            float length2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Bredth 2 : ");
            float breadth2 = float.Parse(Console.ReadLine());

            r2 = new Rectangle(length2, breadth2);
            Console.WriteLine(r2.GetSize());

        }
    }
}
