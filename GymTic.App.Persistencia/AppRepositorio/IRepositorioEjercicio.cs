using System.Collections.Generic;
using GymTic.App.Dominio;

namespace Gymtic.App.Persistencia
{
    public interface IRepositorioEjercicio
    {
        Ejercicios crearEjercicio(Ejercicio ejercicio);
        Ejercicios actualizarEjercicio(Ejercicio ejercicio);
        IEnumerable<Ejercicio> consultarTodosEjercicios();
        Cliente consultarCliente(string nombreEjercico);
        void eliminarCliente(string nombreEjercico);
    }
}