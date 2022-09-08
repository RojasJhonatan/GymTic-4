using System;

namespace GymTic.App.Dominio
{
    public class Cliente
    {
       public int Id {get;set;}
       public string Nombre {get; set;} 
       public string Apellido {get;set;}
       public string EMail {get;set;}
       public string Contraseña {get;set;}
       public string Telefono {get;set;}
       public string Direccion {get;set;}
       public float Peso {get;set;}
       public float Altura {get;set;}
       public Genero Genero {get;set;}
    }

}