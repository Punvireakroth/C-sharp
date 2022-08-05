using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseOne
{
    class Employee
    {
        public string strName;
        private float fltSalary;

        public float FltSalary
        {
            get { return fltSalary; }
            set { 
                if(value > 0)
                {
                    fltSalary = value;
                } 
            }
        }
           
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empObj = new Employee();
            Console.WriteLine("Enter Name: ");
            empObj.strName = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            empObj.FltSalary = float.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0} Salary: {1}", empObj.strName, empObj.FltSalary);
        }
    }
}
