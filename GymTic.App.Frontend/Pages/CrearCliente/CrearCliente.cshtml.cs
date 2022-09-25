using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GymTic.App.Dominio;
using GymTic.App.Persistencia;

namespace GymTic.App.Frontend.Page
{
    public class CrearClienteModel : PageModel
    {
        [BindProperty]
        public Cliente cliente{get;set;}
        private readonly IRepositorioCliente repoCliente;

        /*public CrearClienteModel(IRepositorioCliente rCliente)
        {
            repoCliente = rCliente;
        }
        
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            repoCliente.crearCliente(cliente);
            return RedirectToPage("/Index");
        }*/
    }
}
