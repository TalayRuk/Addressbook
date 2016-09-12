using System.Collections.Generic;

namespace Addressbook.Objects
{
    public class Contact
    {
        //variable
        private string _name;
        private int _phoneNumber;
        private string _address;
        private static List<Contact> _instances = new List<Contact> {};
        private List<Contact> _contacts;

      //Constructor
        public Contact(string Name, int PhoneNumber, string Address)
        {
            _name = Name;
            _phoneNumber = PhoneNumber;
            _address = Address;
            _contacts = new List<Contact>{};


        }
    }
}
