using System.Collections.Generic;
using System.Linq;
using GymTic.App.Dominio;

namespace GymTic.App.Persistencia
{
    public class RepositorioPlanSaludable : IRepositorioPlanSaludable
    {
        private readonly AppContext appContextBD;
        
        public RepositorioPlanSaludable(AppContext appContext)
        {
            this.appContextBD = appContext;
        }

        public PlanSaludable crearPlanSaludable(PlanSaludable planSaludable)
        {
            var planSaludableCreado = appContextBD.PlanSaludable.Add(planSaludable);
            appContextBD.SaveChanges();
            return planSaludableCreado.Entity;
        }

        public PlanSaludable actualizarPlanSaludable(PlanSaludable planSaludable)
        {
            var planSaludableEncontrado = appContextBD.PlanSaludable.FirstOrDefault(p => p.cliente.eMail == planSaludable.cliente.eMail);
            if(planSaludableEncontrado != null)
            {
                planSaludableEncontrado.rutina = planSaludable.rutina;
                planSaludableEncontrado.nutricion = planSaludable.nutricion;
                planSaludableEncontrado.cliente = planSaludable.cliente;

                appContextBD.SaveChanges();
            }
            return planSaludableEncontrado;
        }

        public IEnumerable<PlanSaludable> consultarTodosPlanSaludable()
        {
            return appContextBD.PlanSaludable;
        }
        
        public PlanSaludable consultarPlanSaludable(Cliente cliente)
        {
            var planSaludableEncontrado = appContextBD.PlanSaludable.FirstOrDefault(p => p.cliente.eMail == planSaludable.cliente.eMail);
            if(planSaludableEncontrado != null)
            {
                return planSaludableEncontrado;
            }
            return planSaludableEncontrado;
        }

        public void eliminarPlanSaludable(Cliente cliente)
        {
            var planSaludableEncontrado = _appContextBD.PlanSaludable.FirstOrDefault(p => p.cliente.eMail == planSaludable.cliente.eMail);
            if(planSaludableEncontrado == null)
            return;
            appContextBD.PlanSaludable.Remove(planSaludableEncontrado);
            appContextBD.SaveChanges();
        }
    }
}