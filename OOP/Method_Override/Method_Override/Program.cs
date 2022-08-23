using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Override
{
    class PetShop
    {
        private string strPetShopName;
        private string strAddress;

        public PetShop(string strPetShopName, string strAddress)
        {
            this.strPetShopName = strPetShopName;
            this.strAddress = strAddress;
        }
        public string PetShopInfo()
        {
            return "Pet Shop Name: " + strPetShopName + "Address: " + strAddress;
        }
        public virtual string Sound()
        {
            return "Animal make sound";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
