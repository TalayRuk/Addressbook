using Nancy;
using Addressbok.Objects;

namespace Addressbook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ ={
        var allContacts = Contact.GetAll();
        return View["view_all_contacts.cshtml", allContacts]
      }
    }
  }
}
