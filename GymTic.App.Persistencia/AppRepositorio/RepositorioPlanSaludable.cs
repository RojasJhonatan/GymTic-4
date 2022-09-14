using System.Collections.Generic;
using System.Linq;

namespace GymTic.App.Dominio
{
    public class RepositorioPlanSaludable : IRepositorioPlanSaludable
    {
        private readonly _AppContext appContextBD;
        
        public RepositorioPlanSaludable(_AppContext appContext)
        {
            this._appContextBD = appContext;
        }

        public PlanSaludable crearPlanSaludable(PlanSaludable planSaludable)
        {
            var planSaludableCreado = _appContextBD.PlanSaludable.Add(planSaludable);
            _appContextBD.SaveChanges();
            return planSaludableCreado.Entity;
        }

        public PlanSaludable actualizarPlanSaludable(PlanSaludable planSaludable)
        {
            var planSaludableEncontrado = _appContextBD.PlanSaludable.FirstOrDefault(p => p.cliente.eMail == planSaludable.cliente.eMail);
            if(planSaludableEncontrado != null)
            {
                planSaludableEncontrado.rutina = planSaludable.rutina;
                planSaludableEncontrado.nutricion = planSaludable.nutricion;
                planSaludableEncontrado.cliente = planSaludable.cliente;

                _appContextBD.SaveChanges();
            }
            return planSaludableEncontrado;
        }

        public IEnumerable<PlanSaludable> consultarTodosPlanSaludable()
        {
            return _appContextBD.PlanSaludable;
        }
        
        public PlanSaludable consultarPlanSaludable(Cliente cliente)
        {
            var planSaludableEncontrado = _appContextBD.PlanSaludable.FirstOrDefault(p => p.cliente.eMail == planSaludable.cliente.eMail);
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
            _appContextBD.PlanSaludable.Remove(planSaludableEncontrado);
            _appContextBD.SaveChanges();
        }
    }
}