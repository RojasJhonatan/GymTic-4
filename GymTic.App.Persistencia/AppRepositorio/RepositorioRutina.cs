using System.Collections.Generic;
using System.Linq;
using GymTic.App.Dominio;

namespace GymTic.App.Persistencia
{
    public class RepositorioRutina : IRepositorioRutina
    {
        private readonly AppContext appContextBD;

        public RepositorioRutina()
        {
            
        }

    
        public Rutina crearRutina(Rutina rutina)
        {
            var rutinaCreada = appContextBD.Rutina.Add(rutina);
            appContextBD.SaveChanges();
            return rutinaCreada.Entity;
        }

        public Rutina consultarRutina(int idRutina)
        {
            var rutinaEncontrada = appContextBD.Rutina.FirstOrDefault(r => r.id == idRutina);
            if(rutinaEncontrada != null)
            {
                return rutinaEncontrada;
            }
            return rutinaEncontrada;
        }

        public IEnumerable<Rutina> consultarTodosRutinas()
        {
            return appContextBD.Rutina;
        }

        public Rutina actualizarRutina(Rutina rutina)
        {
            var rutinaEncontrada = appContextBD.Rutina.FirstOrDefault(r => r.id == rutina.id);
            if(rutinaEncontrada != null)
            {
                rutinaEncontrada.ejercicios = rutina.ejercicios;
                rutinaEncontrada.horario = rutina.horario;

                appContextBD.SaveChanges();
            }
            return rutinaEncontrada;
        }

        public void eliminarRutina(int idRutina)
        {
            var rutinaEncontrada = appContextBD.Rutina.FirstOrDefault(r => r.id == idRutina);
            if(rutinaEncontrada == null)
            return;
            appContextBD.Rutina.Remove(rutinaEncontrada);
            appContextBD.SaveChanges();
        }
    }

}