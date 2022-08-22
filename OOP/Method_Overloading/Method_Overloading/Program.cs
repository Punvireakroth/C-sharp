using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class MedicalRecords
    {
        private string strPatientName;
        private float fltMedicalFees;

        // constructor 

        public MedicalRecords(string strPatientName, float fltMedicalFees)
        {
            this.strPatientName = strPatientName;
            this.fltMedicalFees = fltMedicalFees;
        }

        public float CalMedicalFees()
        {
            return fltMedicalFees;
        }

        // overload method 
        public float CalMedicalFees(string test)
        {
            if(test == "Hepatities")
            {
                fltMedicalFees += 17.7f;
            }else if(test == "Cholesterol")
            {
                fltMedicalFees += 25.00f;
            }else if(test == "Diabetes")
            {
                fltMedicalFees += 20.00f;
            }
            return fltMedicalFees;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the patient’s name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter the medical fees: ");
            float fees = float.Parse(Console.ReadLine());
            MedicalRecords mObj = new MedicalRecords(name, fees);

            Console.WriteLine("Medical fees: ${0}", mObj.CalMedicalFees().ToString());

            Console.WriteLine("Enter your test type");
            string test = Console.ReadLine();
            Console.WriteLine("Medical fees with test: ${0}", mObj.CalMedicalFees(test).ToString());

        }
    }
}
