ines (11 sloc)  310 Bytes

using system;

namespace Gimnasio.App.Dominio
{
    public class Dieta
    {
        public string Nombre{get;set;}
        public Alimentacion Alimentacion{get;set;}
        public int Duracion{get;set;}
        public CategoriaNutricion categoria{get;set;}
        public int Verificacion{get;set;}

    }
}