using System;

namespace GymTic.App.Dominio
{
    public class Cliente
    {
       public int id {get;set;}
       public string nombre {get; set;} 
       public string apellido {get;set;}
       public string eMail {get;set;}
       public string contraseña {get;set;}
       public string telefono {get;set;}
       public string direccion {get;set;}
       public float peso {get;set;}
       public float altura {get;set;}
       public Genero genero {get;set;}
    }

}