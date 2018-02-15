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
  }
}

//     [HttpPost("/result")]
//     public ActionResult Result()
//     {
//       string word = Request.Form["word-input"];
//
//       ScrabbleGenerator newScrabbleGenerator = new ScrabbleGenerator(word);
//       newScrabbleGenerator.BreakWord();
//       int wordVal = newScrabbleGenerator.WordCharVal();
//       return View("Index", wordVal);
//     }
//   }
// }
