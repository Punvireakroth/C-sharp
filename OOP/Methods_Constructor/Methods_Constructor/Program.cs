using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Constructor
{
    class Cube
    {
        private float fltSide;

        public float Volume
        {
            get { return fltSide * fltSide * fltSide; }
        }

        public Cube(float s)
        {
            this.fltSide = s;
        }

        public string GetSide()
        {
            return "The legth of one side of the cube is " + fltSide.ToString() + " cm"; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cube c10bj;
            Cube c20bj;

            Console.WriteLine("Enter One side of the cube: ");
            float side = float.Parse(Console.ReadLine());
            c10bj = new Cube(side);
            Console.WriteLine(c10bj.GetSide());


            Console.WriteLine("Enter another side of the cube: ");
            float another_side = float.Parse(Console.ReadLine());
            c20bj = new Cube(another_side);
            Console.WriteLine(c20bj.GetSide());


            float total = c10bj.Volume + c20bj.Volume;
            Console.WriteLine("Total Volume = {0} cm^3 ", total.ToString());
        }
    }
}
