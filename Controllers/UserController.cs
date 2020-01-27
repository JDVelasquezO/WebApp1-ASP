using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    //[Route("/users/data")]
    public class UserController : Controller
    {
        [Route("/users/data")]
        [Route("[controller]/[action]/{name}/{age}")]
        public IActionResult Index(String name, int age) // Recibimos un parámetro
        {
            String data = name + " tiene " + age + " años"; // Usamos el parámetro
            return View("Index", data);
        }

        public IActionResult Index()
        {
            return View("Index");
        }
    }
}