using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Exercise02
{
    class Hospital
    {
        private string strHospitalName;

        public string HospitalName
        {
            get { return strHospitalName; }
        }
        public Hospital(string strHospitalName)
        {
            this.strHospitalName = strHospitalName;
        }

    }
    class Doctor : Hospital
    {
        public string strDoctorName;
        private float fltFees;

        public float Fees
        {
            get { return fltFees; }
        }

        public Doctor(string strDoctorName, float fltFees, string hospitalName) : base(hospitalName)
        {
            this.strDoctorName = strDoctorName;
            this.fltFees = fltFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor objDoc;
            Console.WriteLine("Enter hospital name: ");
            string hospital_name = Console.ReadLine();
            Console.WriteLine("Enter doctor name: ");
            string doctor_name = Console.ReadLine();
            Console.WriteLine("Please enter the fees: ");
            float fees = float.Parse(Console.ReadLine());
            objDoc = new Doctor(doctor_name, fees, hospital_name);
            Console.WriteLine("Doctor name: {0}", objDoc.strDoctorName);
            Console.WriteLine("Hospital name: {0}", objDoc.HospitalName);
            Console.WriteLine("Fees: {0}", objDoc.Fees);
            Console.ReadKey();
        }
    }
}
