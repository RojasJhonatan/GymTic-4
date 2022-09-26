using System.Collections.Generic;
using GymTic.App.Dominio;
using System.Linq;


namespace GymTic.App.Persistencia
{
    public class RepositorioEjercicio : IRepositorioEjercicio
    {
        private readonly AppContext appContextBD;
        
        public RepositorioEjercicio()
        {
            ;
        }
        
        public Ejercicio crearEjercicio(Ejercicio ejercicio)
        {
            var ejercicioCreado = appContextBD.Ejercicio.Add(ejercicio);
            appContextBD.SaveChanges();
            return ejercicioCreado.Entity;
        }

        public Ejercicio actualizarEjercicio(Ejercicio ejercicio)
        {
            var ejercicioEncontrado = appContextBD.Ejercicio.FirstOrDefault(e => e.nombre == ejercicio.nombre);
            if(ejercicioEncontrado != null)
            {
                ejercicioEncontrado.nombre = ejercicio.nombre;
                ejercicioEncontrado.zonaCuerpo = ejercicio.zonaCuerpo;
                ejercicioEncontrado.repeticiones = ejercicio.repeticiones;
                ejercicioEncontrado.series = ejercicio.series;
                ejercicioEncontrado.categoria = ejercicio.categoria;
                ejercicioEncontrado.puntosSaludables = ejercicio.puntosSaludables;
                ejercicioEncontrado.caloriasConsumidas = ejercicio.caloriasConsumidas;

                appContextBD.SaveChanges();

            }
            return ejercicioEncontrado;
        }

        public IEnumerable<Ejercicio> consultarTodosEjercicios()
        {
            return appContextBD.Ejercicio;
        }

        public Ejercicio consultarEjercicio(string nombre)
        {
            var ejercicioEncontrado = appContextBD.Ejercicio.FirstOrDefault(e => e.nombre == nombre);
            if(ejercicioEncontrado != null)
            {
                return ejercicioEncontrado;
            }
            return ejercicioEncontrado;
        }

        public void eliminarEjercicio(string nombre)
        {
            var ejercicioEncontrado = appContextBD.Ejercicio.FirstOrDefault(e => e.nombre == nombre);
            if(ejercicioEncontrado == null)
            return ;
            appContextBD.Ejercicio.Remove(ejercicioEncontrado);
            appContextBD.SaveChanges();
        }

    }
}