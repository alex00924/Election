using Election.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Election
{
    [Authorize]
    public class HomeController : Controller
    {
//        [Authorize(Roles = Global.ROLE_ADMIN)]
        public IActionResult Index()
        {
            var user = HttpContext.User;
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}