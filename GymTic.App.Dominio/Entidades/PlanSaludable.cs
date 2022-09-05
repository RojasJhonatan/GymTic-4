using System;

namespace GymTic.App.Dominio{
    public class PlanSaludable
    {
        public int Id {get;set;}
        public Rutina Rutina {get; set;}
        public Nutricion Nutricion {get; set;}
        public Cliente Cliente {get; set;}
    }

}
