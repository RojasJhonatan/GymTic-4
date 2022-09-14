using System.Collections.Generic;
using GymTic.Add.Dominio;

namespace GymTic.App.Dominio
{
    public interface IRepositorioPlanSaludable
    {
        PlanSaludable crearPlanSaludable(PlanSaludable planSaludable);
        PlanSaludable actualizarPlanSaludable(PlanSaludable planSaludable);
        IEnumerable<PlanSaludable> consultarTodosPlanSaludable();
        PlanSaludable consultarPlanSaludable(Cliente cliente);
        void eliminarPlanSaludable(Cliente cliente);
    }
}