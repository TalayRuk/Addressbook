using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    //variable
    private string _name;
    private string _phoneNumber;
    private string _address;
    private static List<Contact> _instances = new List<Contact> {};
    private List<Contact> _contacts;

  //Constructor
    public Contact(string Name, string PhoneNumber, string Address)
    {
      _name = Name;
      _phoneNumber = PhoneNumber;
      _address = Address;
      _instances.Add(this);
      _contacts = new List<Contact>{};
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
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
    public void Add(Contact newContact)
    {
      _instances.Add(newContact);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
