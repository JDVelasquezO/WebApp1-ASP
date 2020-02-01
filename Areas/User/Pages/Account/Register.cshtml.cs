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
        [BindProperty] // Se vincula la propiedad con la vista
        public InputModel Input { get; set; } // Con esta propiedad tenemos acceso al input del form
        public class InputModel
        {
            [Required] // La propiedad require datos
            [EmailAddress] // Debe ser un correo valido
            [Display(Name = "Email")] // Se le cambia el nombre a la propiedad
            public String email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            // Con 0, 1 y 2 hacemos referencia a la posición de los parametros
            [StringLength(100, ErrorMessage ="El numero de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
            public String password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare("password", ErrorMessage ="Las contraseñas no coinciden")] // Compara con otro atributo
            public String confirmPassword { get; set; }
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost() // Capturamos los datos que se ejecutan por POST en la vista
        {
            var data = Input; // Con Input podemos llamar a los valores de las propiedades de InputModel

            return Page(); // Cuando se ejecute el método, retornará mantenerse en la misma página de registrar
        }
    }
}