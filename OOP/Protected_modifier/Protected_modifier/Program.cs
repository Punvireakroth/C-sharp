using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_modifier
{
    class School
    {
        public string strSchoolName;
        private string strAdress;
        protected static int intStudentCount;

        public string Adress
        {
            get { return strAdress; }
        }

        public School(string strSchoolName, string strAdress)
        {
            this.strSchoolName = strSchoolName;
            this.strAdress = strAdress;
        }

        public int GetTotalStudents()
        {
            return intStudentCount;

        }

    }

    class Student : School
    {
        private string strName;
        public Student(string strName, string schoolname, string address) : base (schoolname, address)
        {
            this.strName = strName;
            intStudentCount++; 
        }

        public string GetInfo()
        {
            return "Student name: " + strName + "School name: " + strSchoolName + "Adress: " + Adress;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;
            Student objS2;
            Console.WriteLine("Enter student name: ");
            string student_name = Console.ReadLine();
            Console.WriteLine("Enter school name: ");
            string school_name = Console.ReadLine();
            Console.WriteLine("Enter address name: ");
            string address = Console.ReadLine();
            objS1 = new Student(student_name, school_name, address);

            Console.WriteLine(objS1.GetInfo());


            Console.WriteLine("Enter student name: ");
            student_name = Console.ReadLine();
            Console.WriteLine("Enter school name: ");
            school_name = Console.ReadLine();
            Console.WriteLine("Enter address name: ");
            address = Console.ReadLine();
            objS2 = new Student(student_name, school_name, address);


            Console.WriteLine(objS2.GetInfo());
            Console.WriteLine("Total number of student: {0}", objS1.GetTotalStudents().ToString());
            Console.ReadKey();
        }
    }
}
