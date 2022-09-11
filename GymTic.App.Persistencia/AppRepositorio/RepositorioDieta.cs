using System.Collections.Generic;
using GymTic.App.Dominio;
using System.Linq;

namespace Gymtic.App.Persistencia
{
    public class repositorioDieta : IRepositorioDieta
    {
        private readonly _AppContext _appContextBD;
        public repositorioDieta(_AppContext appContext)
        {
            this._appContextBD = appContext;
        }
        
        public Dieta CrearDieta(Dieta dieta)
        {
            var dietaCreado = _appContextBD.Dieta.Add(dieta);
            _appContextBD.SaveChanges();
            return dietaCreado.Entity;
        }

        public Dieta ConsultarDieta(string nombreDieta)
        {
            var dietaEncontrado = _appContextBD.Cliente.FirstOrDefault(d => d.nombre == nombreDieta);
            if(dietaEncontrado !=null)
            {
                return dietaEncontrado;
            }
            return dietaEncontrado;
        }

        public IEnumerable<Dieta> ConsultarTodosDietas()
        {
            return _appContextBD.Dietas;
        }

        public Dieta actualizarDieta(Dieta dieta)
        {
            var dietaEncontrado = _appContextBD.Dieta.FirstOrDefault(d => d.nombre == dieta.Nombre);
            if(dietaEncontrado != null)
            {
                dietaEncontrado.nombre = dieta.Nombre;
                dietaEncontrado.alimentacion = dieta.alimentacion;
                dietaEncontrado.duracion = dieta.duracion;
                dietaEncontrado.categoria = dieta.categoria;
                dietaEncontrado.verificacion = dieta.verificacion;

                _appContextBD.SaveChanges();
            }
            return dietaEncontrado;

            public void eliminarDieta(string nombre)
            {
                var dietaEncontrado = _appContextBD.Dieta.FirstOrDefault(d => d.nombre == dieta.Nombre);
                if(dietaEncontrado == null)
                return;
                _appContextBD.Dieta.Remove(dietaEncontrado);
                _appContextBD.SaveChanges();

            }
        }

    }
}