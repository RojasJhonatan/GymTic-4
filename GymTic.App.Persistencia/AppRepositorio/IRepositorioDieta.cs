using System.Collections.Generic;
using GymTic.App.Dominio;

namespace GymTic.App.Persistencia
{
    public interface IRepositorioDieta
    {
        Dieta crearDieta(Dieta dieta);
        Dieta actualizarDieta(Dieta dieta);
        IEnumerable<Dieta> consultarTodosDietas();
        Dieta consultarDieta(string nombreDieta);
        void eliminarDieta(string nombreDieta);
    }
}