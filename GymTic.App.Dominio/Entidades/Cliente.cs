using System;

namespace GymTic.App.Dominio
{
    public class Cliente
    {
       public int Id {get;set;}
       public string Nombre {get; set;} 
       public string Apellido {get;set;}
       public string Email {get;set;}
       public string Contraseña {get;set;}
       public string Teléfono {get;set;}
       public string Dirección {get;set;}
       public float Peso {get;set;}
       public float Altura {get;set;}
       public Genero Genero {get;set;}
    }

}