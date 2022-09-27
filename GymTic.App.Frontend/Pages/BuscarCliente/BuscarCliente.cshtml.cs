using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
<<<<<<< HEAD
using GymTic.App.Dominio;
using GymTic.App.Persistencia;

=======
>>>>>>> fc149d42b8ff8786f908e0d8add574cb7b99816d

namespace GymTic.App.Frontend.Pages
{
    public class BuscarClienteModel : PageModel
    {
<<<<<<< HEAD
        public Cliente cliente{get;set;}
        
        
        IRepositorioCliente _repoCliente= new RepositorioCliente(new Persistencia.AppContext());
        public BuscarClienteModel(IRepositorioCliente repoCliente)
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
=======
        public void OnGet()
        {
        }
>>>>>>> fc149d42b8ff8786f908e0d8add574cb7b99816d
    }
}
