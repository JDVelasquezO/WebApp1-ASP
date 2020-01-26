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
        public IActionResult Index(String name, int age) // Recibimos un parámetro
        {
            String data = name + " " + age; // Usamos el parámetro
            return View("Index", data);
        }

        public IActionResult Index()
        {
            return View("Index");
        }
    }
}