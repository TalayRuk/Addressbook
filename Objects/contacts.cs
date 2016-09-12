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
            _instances.Add(this);
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }
        public int GetPhoneNumber()
        {
            return _phoneNumber;
        }
        public void SetPhoneNumber(int newPhoneNumber)
        {
            _phoneNumber = newPhoneNumber;
        }
        public string GetAddress()
        {
            return _address;
        }
        public void SetAddress(string newAddress)
        {
            _address = newAddress;
        }
        public static List<Contact> GetAll()
        {
            return _instances;
        }
        public void Save(Contact newContact)
        {
            _instances.Add(newContact);
        }
        public static void DeleteAll()
        {
            _instances.Clear();
        }
    }
}
