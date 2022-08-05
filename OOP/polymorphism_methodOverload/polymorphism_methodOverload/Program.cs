using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_methodOverload
{
    class MedicalRecords
    {
        private string strPatientName;
        private float fltMedicalFees;

        public MedicalRecords(string a, float b)
        {
            this.strPatientName = a;
            this.fltMedicalFees = b;
        }

        public float CalMedicalFees()
        {
            return fltMedicalFees;
        }

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

            Console.WriteLine("Enter patient's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Medical fees: ");
            float price = float.Parse(Console.ReadLine());
            MedicalRecords mObj = new MedicalRecords(name, price);

            Console.WriteLine("Medical fees = {0}", mObj.CalMedicalFees().ToString());

            Console.WriteLine("Enter the test: ");
            string testType = Console.ReadLine();
            
            Console.WriteLine("Medical record afer test {0}", mObj.CalMedicalFees(testType).ToString());
        }
    }
}
