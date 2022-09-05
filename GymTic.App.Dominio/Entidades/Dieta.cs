using System;

namespace GymTic.App.Dominio
{
    public class Dieta
    {
        public int Id {get;set;}
        public string Nombre{get;set;}
        public Alimentacion Alimentacion{get;set;}
        public int Duracion{get;set;}
        public CategoriaNutricion Categoria{get;set;}
        public int Verificacion{get;set;}

    }
}