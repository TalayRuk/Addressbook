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
        var newContact = newContact(Request.Form["new-name"], Request.Form["new-phoneNumber"], Request.Form["new-address"]);
        List<Contact> contactList = Contact.GetAll();
        return View["contact_created.cshtml", newContact];
      };
      Get[]

    }
  }
}
