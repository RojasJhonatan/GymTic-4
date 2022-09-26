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
        
        
        IRepositorioCliente _repoCliente= new RepositorioCliente(new Persistencia.AppContext());
        
        

        public CrearClienteModel(IRepositorioCliente repoCliente)
        {
            
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
            _repoCliente.crearCliente(cliente);
            return RedirectToPage("/Index");
        }
    }
}
