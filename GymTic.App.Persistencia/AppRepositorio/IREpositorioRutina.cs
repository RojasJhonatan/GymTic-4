using System.Collections.Generic;
using GymTic.App.Dominio;

namespace GymTic.App.Persistencia
{
    public class IRepositorioRutina
    {
        Rutina crearRutina(Rutina rutina);
        Rutina actualizarRutina(Rutina rutina);
        IEnumerable<Rutina> consultarTodosRutinas();
        Rutina consultarRutina(string id);
        void eliminarRutina(string id);

        
    }
}