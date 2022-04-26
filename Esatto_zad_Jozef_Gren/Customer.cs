using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esatto_zad_Jozef_Gren
{
    
    public class Customer
    {
        private string name;
        private string address;
        private string vat;
        private string creationDate;

        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Vat { get { return vat; } set { vat = value; } }

        public string CreationDate { get { return creationDate; } set { creationDate = value; } }

        public Customer(string _name, string _addres, string _vat)
        {
            name = _name;
            address = _addres;
            vat = _vat;
            creationDate = DateTime.Now.ToString("dd-MM-yyyy");

        }
        public override string ToString()
        {
            return "Name: " + Name + " " + "Address: " + Address+ " " + "VAT number: " + Vat + " " + "Creation date: " + creationDate;
        }


    

    }

    


    
}
