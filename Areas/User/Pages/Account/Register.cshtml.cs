using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Areas.User.Pages
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty] // Se vincula la propiedad con la vista
        public InputModel Input { get; set; } // Con esta propiedad tenemos acceso al input del form
        public class InputModel
        {
            [Required] // La propiedad require datos
            [EmailAddress] // Debe ser un correo valido
            [Display(Name = "Email")] // Se le cambia el nombre a la propiedad
            public String email { get; set; }
        }
    }
}