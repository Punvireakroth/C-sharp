using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThree
{
    class Circle
    {
        private float fltRadius;
        private string strColor;

        public float Radius
        {
            get { return fltRadius; }
            set 
            { 
                if(value > 0)
                {
                    fltRadius = value;
                } 
            }
        }

        public string Color
        {
            get { return strColor; }
            set { strColor = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cObj = new Circle();
            Console.WriteLine("Enter radius: ");
            cObj.Radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Color: ");
            cObj.Color = Console.ReadLine();

            Console.WriteLine("Radius: {0} Color {1}", cObj.Radius, cObj.Color);

        }
    }
}
