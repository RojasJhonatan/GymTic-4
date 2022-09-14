using System;

namespace GymTic.App.Dominio
{
    public class Dieta
    {
        public int id {get;set;}
        public string nombre{get;set;}
        public Alimentacion alimentacion{get;set;}
        public int duracion{get;set;}
        public CategoriaNutricion categoria{get;set;}
        public int verificacion{get;set;}

    }
}