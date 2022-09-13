using System.Collections.Generic;
using System.Linq;
using Gymtic.App.Dominio;

namespace Gymtic.App.Persistencia
{
    public class RepositorioRutina : IRepositorioRutina
    {
        private readonly _AppContext appContextBD;

        public RepositorioRutina(_AppContext appContext)
        {
            this.appContextBD = appContext;
        }

        public Rutina crearRutina(Rutina rutina)
        {
            var rutinaCreada = _appContextBD.Rutina.Add(rutina);
            _appContextBD.SaveChanges();
            return rutinaCreada.Entity;
        }

        public Rutina consultarRutina(int idRutina)
        {
            var rutinaEncontrada = _appContextBD.Rutina.FirstOrDefault(r => r.id == idRutina);
            if(rutinaEncontrada != null)
            {
                return rutinaEncontrada;
            }
            return rutinaEncontrada;
        }

        public IEnumerable<Rutina> consultarTodosRutinas()
        {
            return _appContextBD.Rutina;
        }

        public Rutina actualizarRutina(Rutina rutina)
        {
            var rutinaEncontrada = _appContextBD.Rutina.FirstOrDefault(r => r.id == rutina.id);
            if(rutinaEncontrada != null)
            {
                rutinaEncontrada.ejercicios = rutina.ejercicios;
                rutinaEncontrada.horario = rutina.horario;

                _appContextBD.SaveChanges();
            }
            return rutinaEncontrada;
        }

        public void eliminarRutina(int id)
        {
            var rutinaEncontrada = _appContextBD.Rutina.FirstOrDefault(r => r.id == rutina.id);
            if(rutinaEncontrada == null)
            return;
            _appContextBD.Rutina.Remove(rutinaEncontrada);
            _appContextBD.SaveChanges();
        }
    }

}