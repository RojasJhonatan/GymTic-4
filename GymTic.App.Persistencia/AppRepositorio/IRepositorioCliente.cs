using System.Collections.Generic;
using GymTic.App.Dominio;

namespace Gymtic.App.Persistencia
{
    public interface IRepositorioCliente
    {
        Cliente CrearCliente(Cliente Cliente);
        Cliente ActualizarCliente(Cliente Cliente);
        IEnumerable<Cliente> ConsultarTodosPacientes();
        Cliente ConsultarCliente(string EMailCliente);
        void EliminarCliente(string EMailCliente);
    }

}