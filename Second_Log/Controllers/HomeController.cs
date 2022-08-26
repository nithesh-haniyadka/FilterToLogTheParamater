using Fliter_Logs.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Second_Log.Models;
using System.Diagnostics;

namespace Second_Log.Controllers
{
    [LogActionFilter]
    public class HomeController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine(
                $"- {nameof(HomeController)}.{nameof(OnActionExecuting)}");

            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(
                $"- {nameof(HomeController)}.{nameof(OnActionExecuted)}");

            base.OnActionExecuted(context);
        }

        public IActionResult Index()
        {
            Console.WriteLine(
                $"- {nameof(HomeController)}.{nameof(Index)}");

            return Content("Check the Console.");
        }

        public ActionResult Privacy()
        {
            Console.WriteLine(
                $"- {nameof(HomeController)}.{nameof(Privacy)}");

            return View();
        }
    }
}