using System.Collections.Generic;
using GymTic.App.Dominio;

namespace Gymtic.App.Persistencia
{
    public interface IRepositorioCliente
    {
        Dieta crearDieta(Dieta dieta);
        Dieta actualizarDieta(Dieta dieta);
        IEnumerable<Dieta> consulatarTodosDietas();
        Dieta consultarDieta(string nombreDieta);
        void eliminarDieta(string nombreDieta);
    }
}