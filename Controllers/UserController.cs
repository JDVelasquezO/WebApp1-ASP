using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        [Route("/user/data")]
        public IActionResult Index(String name, int age)
        {
            //var url = Url.Action("Metodo", "User", new { name="JD", age=20 });
            String data = name + " " + age;
            return View("Index", data);
        }

        public IActionResult CatchStatus(int code)
        {
            String data = $"Codigo de estado {code}";
            return View("Index", data);
        }
    }
}
