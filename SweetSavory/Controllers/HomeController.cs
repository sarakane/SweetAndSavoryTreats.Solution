using Microsoft.AspNetCore.Mvc;

namespace SweetSavory.Models
{
  public class HomeController : HomeController
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}