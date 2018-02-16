using Microsoft.AspNetCore.Mvc;
using DayOfWeek.Models;

namespace DayOfWeek.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      string emptyString = "";
      return View("Index", emptyString);
    }

    [HttpPost("/result")]
    public ActionResult Result()
    {
      int month = int.Parse(Request.Form["month-input"]);
      int day = int.Parse(Request.Form["day-input"]);
      int year = int.Parse(Request.Form["year-input"]);
      DayOfWeekGenerator newDayOfWeekGenerator = new DayOfWeekGenerator(year, month, day);
      string model = newDayOfWeekGenerator.ReturnDayOfWeek();

      return View("Index", model);
    }
  }
}
