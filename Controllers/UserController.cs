using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(String name, int age)
        {
            var url = Url.Action("Metodo", "User", new { name="JD", age=20 });

            return Redirect(url);
        }

        public IActionResult CatchStatus(int code)
        {
            String data = $"Codigo de estado {code}";
            return View("Index", data);
        }
    }
}
