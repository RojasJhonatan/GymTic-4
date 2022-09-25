using System.Collections.Generic;
using GymTic.App.Dominio;
using System.Linq;


namespace GymTic.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AppContext appContextBD;
        
        public RepositorioCliente(AppContext appContext)
        {
            this.appContextBD = appContext;
        }
        public Cliente crearCliente(Cliente cliente)
        {
            var ClienteCreado = appContextBD.Cliente.Add(cliente);
            appContextBD.SaveChanges();
            return ClienteCreado.Entity;
        }

        public Cliente consultarCliente(string eMailCliente)
        {
            var clienteEncontrado = appContextBD.Cliente.FirstOrDefault(c => c.eMail == eMailCliente);
            if(clienteEncontrado !=null)
            {
                return clienteEncontrado;
            }
            return clienteEncontrado;
        }

        public IEnumerable<Cliente> consultarTodosPacientes()
        {
            return appContextBD.Cliente;
        }

        public Cliente actualizarCliente(Cliente cliente)
        {
            var clienteEncontrado = appContextBD.Cliente.FirstOrDefault(c => c.eMail == cliente.eMail);
            if(clienteEncontrado != null)
            {
                clienteEncontrado.nombre = cliente.nombre;
                clienteEncontrado.apellido = cliente.apellido;
                clienteEncontrado.contraseña = cliente.contraseña;
                clienteEncontrado.telefono = cliente.telefono;
                clienteEncontrado.direccion = cliente.direccion;
                clienteEncontrado.peso = cliente.peso;
                clienteEncontrado.altura = cliente.altura;
                clienteEncontrado.genero = cliente.genero;
                clienteEncontrado.edad = cliente.edad;
                

                appContextBD.SaveChanges();
            }
            return clienteEncontrado;
        }

        public void eliminarCliente(string eMailCliente)
        {
            var clienteEncontrado = appContextBD.Cliente.FirstOrDefault(c => c.eMail == eMailCliente);
            if(clienteEncontrado == null)
            return;
            appContextBD.Cliente.Remove(clienteEncontrado);
            appContextBD.SaveChanges();
            
        }

    }
}