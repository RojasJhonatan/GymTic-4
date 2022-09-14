using System;

namespace GymTic.App.Dominio
{
    public class Ejercicio
    {
        public int id {get;set;}
        public string nombre {get; set;}
        public string zonaCuerpo {get; set;}
        public int repeticiones {get; set;}
        public int series {get; set;}
        public CategoriaEjercicios categoria {get; set;}
        public int puntosSaludables {get; set;}
        public int caloriasConsumidas {get; set;}
        
    }

}