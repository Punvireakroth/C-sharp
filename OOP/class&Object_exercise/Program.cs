// See https://aka.ms/new-console-template for more information
using System;

namespace classObject_exercise
{
    class Student
    {
        public string strName;
        public string strGroup;
        public string strCourse;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;
            objS1 = new Student();

            Console.WriteLine("Enter the Name: ");
            objS1.strName = Console.ReadLine();
            Console.WriteLine("Enter the course: ");
            objS1.strCourse = Console.ReadLine();
            Console.WriteLine("Enter the Group: ");
            objS1.strGroup = Console.ReadLine();

            Console.WriteLine("Name {0} Group{1} Course{2}", objS1.strName, objS1.strGroup, objS1.strCourse);
        }
    }
}
