using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GymTic.App.Dominio;

namespace GymTic.App.Frontend.Page
{
    public class CrearClienteModel : PageModel
    {
        public Cliente cliente{get;set;}
        //[BindProperty]
        public void OnGet()
        {
        }
    }
}
