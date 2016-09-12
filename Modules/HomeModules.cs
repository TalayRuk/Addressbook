using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["homepage.cshtml"];
      };
      Get["/add_new_contact"] = _ => {
        return View["add_new_contact.cshtml"];
      };
      Post["/contact_created"] = _ => {
        string Name = (Request.Form["new-name"]);
        string phoneNumber = (Request.Form["new-phoneNumber"]);
        string Address = (Request.Form["new-address"]);
        Contact newContact = new Contact(Name, PhoneNumber, Address);
        newContact.Add(Contact newContact);
        return View["contact_created.cshtml", newContact];
      };
      Get["/view_all_contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View ["view_all_contacts.cshtml", allContacts];
      };
      Post["/all_contacts_deleted"] = _ => {
        Contact.ClearAll();
        return View["all_contacts_deleted.cshtml"];
      };

    }
  }
}
