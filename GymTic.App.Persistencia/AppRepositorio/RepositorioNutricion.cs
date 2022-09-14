using System.Collections.Generic;
using Gymtic.App.Dominio;
using System.Linq;

namespace GymTic.App.Persistencia
{
    public class RepositorioNutricion : IRepositorioNutricion
    {
        private readonly _AppContext appContextBD;
        public RepositorioNutricion(_AppContext appContext)
        {
            this.appContextBD = appContext;
        }

        public Nutricion crearNutricion(Nutricion nutricion)
        {
            var nutricionCreado = _appContextBD.Nutricion.Add(nutricion);
            _appContextBD.SaveChanges();
            return nutricionCreado.Entity;
        }

        public Nutricion actualizarNutricion(Nutricion nutricion)
        {
            var nutricionEncontrado = _appContextBD.Nutricion.FirstOrDefault(n => n.id == nutricion.id);
            if(nutricionEncontrado != null)
            {
                nutricionEncontrado.dieta = nutricion.dieta;
                nutricionEncontrado.puntosVerificacion = nutricion.puntosVerificacion;

                _appContextBD.SaveChanges();

            }
            return nutricionEncontrado;
        }

        public IEnumerable<Nutricion> consultarTodosNutricion()
        {
            return _appContextBD.Nutricion;
        }

        public Nutricion consultarNutricion(int id)
        {
            var nutricionEncontrado = _appContextBD.Nutricion.FirstOrDefault(n => n.id == id);
            if(nutricionEncontrado != null)
            {
                return nutricionEncontrado;
            }

        }

        public void eliminarNutricion(string idNutricion)
        {
            var nutricionEncontrado = _appContextBD.Nutricion.FirstOrDefault(n => n.id == id);
            if(nutricionEncontrado == null)
            return;
            _appContextBD.Nutricion.Remove(nutricionEncontrado);
            _appContextBD.SaveChanges();
        }

        
        ;
    }
    
}        