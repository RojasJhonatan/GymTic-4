using System.Collections.Generic;
using GymTic.App.Dominio;

namespace Gymtic.App.Persistencia
{
    public interface IRepositorioNutricion
    {
        Nutricion crearNutricion(Nutricion nutricion);
        Nutricion actualizarNutricion(Nutricion nutricion);
        IEnumerable<Nutricion> consultarTodosNutricion();
        Nutricion consultarNutricion(string idNutricion);
        void eliminarNutricion(string idNutricion);

    }
}