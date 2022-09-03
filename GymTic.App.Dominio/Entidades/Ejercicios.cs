using System;

namespace GymTic.App.Dominio
{
    public class Ejercicios
    {
        public Nombre Nombre {get; set;}
        public ZonaCuerpo ZonaCuerpo {get; set;}
        public int Repeticiones {get; set;}
        public int Series {get; set;}
        public CategoriaEjercicios Categoria {get; set;}
        public int PuntosSaludables {get; set;}
        public int CaloriasConsumidas {get; set;}
        
    }

}