using System;

namespace GymTic.App.Dominio{
    public class PlanSaludable
    {
        public int id {get;set;}
        public Rutina rutina {get; set;}
        public Nutricion nutricion {get; set;}
        public Cliente cliente {get; set;}
    }

}
