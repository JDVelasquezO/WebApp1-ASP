using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        public IActionResult IndexMethod()
        {
            return View();
        }
    }
}