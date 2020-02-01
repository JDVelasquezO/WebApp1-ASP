using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Areas.User.Pages
{
    public class RegisterModel : PageModel
    {
        public string message { get; set; }
        public void OnGet(string data) // Capturamos la información de la url
        {
            this.message = data; // Inicializamos la variable con la información
        }
    }
}