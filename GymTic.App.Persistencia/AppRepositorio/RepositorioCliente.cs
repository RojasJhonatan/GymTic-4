using System.Collections.Generic;
using GymTic.App.Dominio;
using System.Linq;

namespace Gymtic.App.Persistencia
{
    
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly _AppContext _appContext;

        public RepositorioCliente(_AppContext appContext)
        {
            this._appContext = appContext;
        }
         
        public Cliente CrearCliente(Cliente Cliente)
        {
            var ClienteCreado = _appContext.Cliente.Add(Cliente);
            _appContext.SaveChanges();
            return ClienteCreado.Entity;
        }

        public Cliente ConsultarCliente(string EMailCliente)
        {
            var clienteEncontrado = _appContext.Cliente.FirstOrDefault(c => c.EMail == EMailCliente);
            if(clienteEncontrado !=null)
            {
                return clienteEncontrado;
            }
            return clienteEncontrado;
        }

        public IEnumerable<Cliente> ConsultarTodosPacientes()
        {
            return _appContext.Cliente;
        }

        public Cliente ActualizarCliente(Cliente Cliente)
        {
            var clienteEncontrado = _appContext.Cliente.FirstOrDefault(c => c.EMail == Cliente.EMail);
            if(clienteEncontrado != null)
            {
                clienteEncontrado.Nombre = Cliente.Nombre;
                clienteEncontrado.Apellido = Cliente.Apellido;
                clienteEncontrado.Contraseña = Cliente.Contraseña;
                clienteEncontrado.Telefono = Cliente.Telefono;
                clienteEncontrado.Direccion = Cliente.Direccion;
                clienteEncontrado.Peso = Cliente.Peso;
                clienteEncontrado.Altura = Cliente.Altura;
                clienteEncontrado.Genero = Cliente.Genero;

                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }

        public void EliminarCliente(string EMailCliente)
        {
            var clienteEncontrado = _appContext.Cliente.FirstOrDefault(c => c.EMail == EMailCliente);
            if(clienteEncontrado == null)
            return;
            _appContext.Cliente.Remove(clienteEncontrado);
            _appContext.SaveChanges();
            
        }

    }
}