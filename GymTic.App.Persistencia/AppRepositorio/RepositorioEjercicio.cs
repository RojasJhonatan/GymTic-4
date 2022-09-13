using System.Collections.Generic;
using GymTic.App.Dominio;
using System.Linq;

namespace Gymtic.App.Persistencia
{
    public class RepositorioEjercicio : IRepositorioEjercicio
    {
        private readonly _AppContext _appContextBD;

        public RepositorioEjercicio(_AppContext appContext)
        {
            this._appContextBD = appContext;
        }

        public Ejercicio crearEjercicio(Ejercicio ejercicio)
        {
            var ejercicioCreado = _appContextBD.Ejercicio.Add(ejercicio);
            _appContextBD.SaveChanges();
            return ejercicioCreado.Entity;
        }

        public Ejercicio ActualizarEjercicio(Ejercicio ejercicio)
        {
            var ejercicioEncontrado = _appContextBD.Ejercicio.FirstOrDefault(e => e.nombre == ejercicio.nombre);
            if(ejercicioEncontrado != null)
            {
                ejercicioEncontrado.nombre = ejercicio.nombre;
                ejercicioEncontrado.zonaCuerpo = ejercicio.zonaCuerpo;
                ejercicioEncontrado.repeticiones = ejercicio.repeticiones;
                ejercicioEncontrado.series = ejercicio.series;
                ejercicioEncontrado.categoria = ejercicio.categoria;
                ejercicioEncontrado.puntosSaludables = ejercicio.puntosSaludables;
                ejercicioEncontrado.caloriasConsumidas = ejercicio.caloriasConsumidas;

                _appContextBD.SaveChanges();

            }
            return ejercicioEncontrado;
        }

        public IEnumerable<Ejercicio> ConsultarTodosEjercicios()
        {
            return _appContextBD.Ejercicio;
        }

        public Ejercicio ConsultarEjercicio(string nombre)
        {
            var ejercicioEncontrado = _appContextBD.Ejercicio.FirstOrDefault(e => e.nombre == nombre);
            if(ejercicioEncontrado != null)
            {
                return ejercicioEncontrado;
            }
            return ejercicioEncontrado;
        }

        public void eliminarEjercicio(string nombre)
        {
            var ejercicioEncontrado = _appContextBD.Ejercicio.FirstOrDefault(e => e.nombre == nombre);
            if(ejercicioEncontrado == null)
            return ;
            _appContextBD.Ejercicio.Remove(ejercicioEncontrado);
            _appContextBD.SaveChanges();
        }

    }
}