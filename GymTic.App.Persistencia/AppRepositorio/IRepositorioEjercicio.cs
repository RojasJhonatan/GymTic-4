using System.Collections.Generic;
using GymTic.App.Dominio;

namespace Gymtic.App.Persistencia
{
    public interface IRepositorioEjercicio
    {
        Ejercicios crearEjercicio(Ejercicios ejercicio);
        Ejercicios actualizarEjercicio(Ejercicios ejercicio);
        IEnumerable<Ejercicios> consultarTodosEjercicios();
        Cliente consultarCliente(string nombreEjercico);
        void eliminarCliente(string nombreEjercico);
    }
}