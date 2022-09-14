using System.Collections.Generic;
using GymTic.App.Dominio;
using System.Linq;

namespace Gymtic.App.Persistencia
{
    
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly _AppContext _appContextBD;

        public RepositorioCliente(_AppContext appContext)
        {
            this._appContextBD = appContext;
        }
         
        public Cliente CrearCliente(Cliente Cliente)
        {
            var ClienteCreado = _appContextBD.Cliente.Add(Cliente);
            _appContextBD.SaveChanges();
            return ClienteCreado.Entity;
        }

        public Cliente ConsultarCliente(string EMailCliente)
        {
            var clienteEncontrado = _appContextBD.Cliente.FirstOrDefault(c => c.EMail == EMailCliente);
            if(clienteEncontrado !=null)
            {
                return clienteEncontrado;
            }
            return clienteEncontrado;
        }

        public IEnumerable<Cliente> ConsultarTodosPacientes()
        {
            return _appContextBD.Cliente;
        }

        public Cliente ActualizarCliente(Cliente Cliente)
        {
            var clienteEncontrado = _appContextBD.Cliente.FirstOrDefault(c => c.eMail == cliente.eMail);
            if(clienteEncontrado != null)
            {
                clienteEncontrado.Nombre = cliente.Nombre;
                clienteEncontrado.Apellido = cliente.Apellido;
                clienteEncontrado.Contraseña = cliente.Contraseña;
                clienteEncontrado.Telefono = cliente.Telefono;
                clienteEncontrado.Direccion = cliente.Direccion;
                clienteEncontrado.Peso = cliente.Peso;
                clienteEncontrado.Altura = cliente.Altura;
                clienteEncontrado.Genero = cliente.Genero;

                _appContextBD.SaveChanges();
            }
            return clienteEncontrado;
        }

        public void EliminarCliente(string EMailCliente)
        {
            var clienteEncontrado = _appContextBD.Cliente.FirstOrDefault(c => c.EMail == EMailCliente);
            if(clienteEncontrado == null)
            return;
            _appContextBD.Cliente.Remove(clienteEncontrado);
            _appContextBD.SaveChanges();
            
        }

    }
}