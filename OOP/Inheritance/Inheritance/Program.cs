using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class School
    {
        public string strSchoolName;
        private string strAddress;

        public string Adresss
        {
            get { return strAddress; }
            set { strAddress = value; }
        }


        public School(string strSchoolName, string strAddress)
        {
            this.strSchoolName = strSchoolName;
            this.strAddress = strAddress;
        }
    }
    class Student : School
    {
        public string strStudentName;
        private float fltSchoolFees;
        public float SchoolFees
        {
            get { return fltSchoolFees; }
            set { fltSchoolFees = value; }
        }

        public Student(string strStudentName, float fltSchoolFees, string schoolname, string address) : base(schoolname, address)
        {
            this.strStudentName = strStudentName;
            this.fltSchoolFees = fltSchoolFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;
            Console.WriteLine("Enter school name: ");
            string school_name = Console.ReadLine();
            Console.WriteLine("Enter adress: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter student name: ");
            string student_name = Console.ReadLine();
            Console.WriteLine("Enter school fees: ");
            float school_fees = float.Parse(Console.ReadLine());

            objS1 = new Student(student_name, school_fees, school_name, address);

            Console.WriteLine("Student name: {0} School Fees: {1} School Name {2} School Adress{3}", objS1.strStudentName, objS1.SchoolFees, objS1.strSchoolName, objS1.Adresss);

        }
    }
}
