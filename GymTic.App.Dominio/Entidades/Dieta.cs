using system;

namespace Gimnasio.App.Dominio
{
    public class Dieta{
        public string Nombre{get;set;}
        public Alimentacion Alimentacion{get;set;}
        public int Duracion{get;set;}
        public Categoria categoria{get;set;}
        public string Verificacion{get;set;}

    }
}