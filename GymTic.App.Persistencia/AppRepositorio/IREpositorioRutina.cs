using System.Collections.Generic;
using GymTic.App.Dominio;

namespace GymTic.App.Persistencia
{
    public interface IRepositorioRutina
    {
        Rutina crearRutina(Rutina rutina);
        Rutina actualizarRutina(Rutina rutina);
        IEnumerable<Rutina> consultarTodosRutinas();
        Rutina consultarRutina(int id);
        void eliminarRutina(int id);

        
    }
}