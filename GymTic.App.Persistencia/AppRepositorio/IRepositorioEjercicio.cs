using System.Collections.Generic;
using GymTic.App.Dominio;

namespace GymTic.App.Persistencia
{
    public interface IRepositorioEjercicio
    {
        Ejercicio crearEjercicio(Ejercicio ejercicio);
        Ejercicio actualizarEjercicio(Ejercicio ejercicio);
        IEnumerable<Ejercicio> consultarTodosEjercicios();
        Ejercicio consultarEjercicio(string nombreEjercico);
        void eliminarEjercicio(string nombreEjercico);
    }
}