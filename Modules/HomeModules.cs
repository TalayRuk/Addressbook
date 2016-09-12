using Nancy;
using Addressbook.Objects;
using System.Collections.Generic;

namespace Addressbook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_= View["homepage.cshtml"];
      Get["/add_new_contact"] =_=> {
          return View ["add_new_contact.cshtml"];
      };


    }
  }
}
