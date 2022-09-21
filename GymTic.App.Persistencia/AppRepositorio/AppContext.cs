using Microsoft.EntityFrameworkCore;
using GymTic.App.Dominio;


namespace GymTic.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Alimentacion> alimentacion{get;set;}
        public DbSet<CategoriaEjercicios> categoriaEjercicios{get;set;}
        public DbSet<CategoriaNutricion> categoriaNutricion{get;set;}
        public DbSet<Cliente> cliente{get;set;}        
        public DbSet<Dieta> dieta{get;set;}
        public DbSet<Ejercicio> ejercicio{get;set;}
        public DbSet<Nutricion> nutricion{get;set;}
        public DbSet<PlanSaludable> planSaludable{get;set;}
        public DbSet<Rutina> rutina{get;set;}
    
    
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GymTic4");
            }
        }
    }
}
