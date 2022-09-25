using System.Collections.Generic;
using GymTic.App.Dominio;

namespace GymTic.App.Persistencia
{
    public interface IRepositorioPlanSaludable
    {
        PlanSaludable crearPlanSaludable(PlanSaludable planSaludable);
        PlanSaludable actualizarPlanSaludable(PlanSaludable planSaludable);
        IEnumerable<PlanSaludable> consultarTodosPlanSaludable();
        PlanSaludable consultarPlanSaludable(int idPlanSaludable);
        void eliminarPlanSaludable(int id);
    }
}