using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class MedicalRecord
    {
        public string strpatienName;
        public string strDoctorName;
        public float fltFees;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MedicalRecord objM1;
            objM1 = new MedicalRecord();

            Console.WriteLine("Enter patienName 1: ");
            objM1.strpatienName = Console.ReadLine();
            Console.WriteLine("Enter DocterName 1: ");
            objM1.strDoctorName = Console.ReadLine();
            Console.WriteLine("Enter Fee 1: ");
            objM1.fltFees = float.Parse(Console.ReadLine());

            Console.WriteLine("petienName: {0} Doctor Name: {1} Fee: {2}", objM1.strpatienName,objM1.strDoctorName,objM1.fltFees);

            MedicalRecord objM2;
            objM2 = new MedicalRecord();

            Console.WriteLine("Enter patienName 2: ");
            objM2.strpatienName = Console.ReadLine();
            Console.WriteLine("Enter DocterName 2: ");
            objM2.strDoctorName = Console.ReadLine();
            Console.WriteLine("Enter Fee 2: ");
            objM2.fltFees = float.Parse(Console.ReadLine());

            Console.WriteLine("petienName: {0} Doctor Name: {1} Fee: {2}", objM2.strpatienName, objM2.strDoctorName, objM2.fltFees);


        }
    }
}
