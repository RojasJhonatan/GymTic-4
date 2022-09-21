using System.Collections.Generic;
using GymTic.App.Dominio;

namespace GymTic.App.Persistencia
{
    public interface IRepositorioCliente
    {
        Cliente crearCliente(Cliente cliente);
        Cliente actualizarCliente(Cliente cliente);
        IEnumerable<Cliente> consultarTodosPacientes();
        Cliente consultarCliente(string eMailCliente);
        void eliminarCliente(string eMailCliente);
    }

}