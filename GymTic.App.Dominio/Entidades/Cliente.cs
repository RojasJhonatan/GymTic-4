using System;
using System.ComponentModel.DataAnnotations;

namespace GymTic.App.Dominio
{
    public class Cliente
    {
       public int id {get;set;}
       [Required]
       public string nombre {get; set;}
       [Required] 
       public string apellido {get;set;}
       [Required]
       public string eMail {get;set;}
       [Required]
       public string contraseña {get;set;}
       [Required]
       public string telefono {get;set;}
       public string direccion {get;set;}
       [Required]
       public int peso {get;set;}
       [Required]
       public float altura {get;set;}
       [Required]
       public int edad{get;set;}
       [Required]
       public Genero genero {get;set;}
    }

}