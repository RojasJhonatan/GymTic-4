using System.Collections.Generic;
using GymTic.App.Dominio;

namespace GymTic.App.Persistencia
{
    public interface IRepositorioNutricion
    {
        Nutricion crearNutricion(Nutricion nutricion);
        Nutricion actualizarNutricion(Nutricion nutricion);
        IEnumerable<Nutricion> consultarTodosNutricion();
        Nutricion consultarNutricion(int idNutricion);
        void eliminarNutricion(int idNutricion);

    }
}