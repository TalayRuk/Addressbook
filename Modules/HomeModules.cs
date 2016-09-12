using Nancy;
using Addressbook.Objects;
using System.Collections.Generic;

namespace Addressbook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ = View["index.cshtml"];
        var allContacts = Contact.GetAll();
        return View["view_all_contacts.cshtml", allContacts]
      }
    }
  }
}
