/*using System.Collections.Generic;
using GymTic.App.Dominio;
using System.Linq;

namespace GymTic.App.Persistencia
{
    public class RepositorioDieta : IRepositorioDieta
    {
        private readonly AppContext appContextBD;
        
        public RepositorioDieta(AppContext appContext)
        {
            this.appContextBD = appContext;
        }
        
        public Dieta crearDieta(Dieta dieta)
        {
            var dietaCreado = appContextBD.Dieta.Add(dieta);
            appContextBD.SaveChanges();
            return dietaCreado.Entity;
        }

        public Dieta consultarDieta(string nombreDieta)
        {
            var dietaEncontrado = appContextBD.Dieta.FirstOrDefault(d => d.nombre == nombreDieta);
            if(dietaEncontrado !=null)
            {
                return dietaEncontrado;
            }
            return dietaEncontrado;
        }

        public IEnumerable<Dieta> consultarTodosDietas()
        {
            return appContextBD.Dietas;
        }

        public Dieta actualizarDieta(Dieta dieta)
        {
            var dietaEncontrado = appContextBD.Dieta.FirstOrDefault(d => d.nombre == dieta.Nombre);
            if(dietaEncontrado != null)
            {
                dietaEncontrado.nombre = dieta.Nombre;
                dietaEncontrado.alimentacion = dieta.alimentacion;
                dietaEncontrado.duracion = dieta.duracion;
                dietaEncontrado.categoria = dieta.categoria;
                dietaEncontrado.verificacion = dieta.verificacion;

                appContextBD.SaveChanges();
            }
            return dietaEncontrado;
        }

        public void eliminarDieta(string nombre)
        {
            var dietaEncontrado = _appContextBD.Dieta.FirstOrDefault(d => d.nombre == dieta.Nombre);
            if(dietaEncontrado == null)
            return;
            appContextBD.Dieta.Remove(dietaEncontrado);
            appContextBD.SaveChanges();
        }
    }

}*/