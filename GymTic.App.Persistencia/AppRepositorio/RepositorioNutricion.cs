using System.Collections.Generic;
using GymTic.App.Dominio;
using System.Linq;


namespace GymTic.App.Persistencia
{
    public class RepositorioNutricion : IRepositorioNutricion
    {
        private readonly AppContext appContextBD;
        
        public RepositorioNutricion(AppContext _appContext)
        {
            this.appContextBD = _appContext;
        }

        public Nutricion crearNutricion(Nutricion nutricion)
        {
            var nutricionCreado = appContextBD.Nutricion.Add(nutricion);
            appContextBD.SaveChanges();
            return nutricionCreado.Entity;
        }

        public Nutricion actualizarNutricion(Nutricion nutricion)
        {
            var nutricionEncontrado = appContextBD.Nutricion.FirstOrDefault(n => n.id == nutricion.id);
            if(nutricionEncontrado != null)
            {
                nutricionEncontrado.dieta = nutricion.dieta;
                nutricionEncontrado.puntosVerificacion = nutricion.puntosVerificacion;

                appContextBD.SaveChanges();

            }
            return nutricionEncontrado;
        }

        public IEnumerable<Nutricion> consultarTodosNutricion()
        {
            return appContextBD.Nutricion;
        }

        public Nutricion consultarNutricion(int id)
        {
            var nutricionEncontrado = appContextBD.Nutricion.FirstOrDefault(n => n.id == id);
            if(nutricionEncontrado != null)
            {
                return nutricionEncontrado;
            }

        }

        public void eliminarNutricion(int idNutricion)
        {
            var nutricionEncontrado = appContextBD.Nutricion.FirstOrDefault(n => n.id == idNutricion);
            if(nutricionEncontrado == null)
            return;
            appContextBD.Nutricion.Remove(nutricionEncontrado);
            appContextBD.SaveChanges();
        }    
    }
    
}        