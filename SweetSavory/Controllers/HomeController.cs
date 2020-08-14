using Microsoft.AspNetCore.Mvc;

namespace SweetSavory.Models
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}