using Microsoft.EntityFrameworkCore;
using GymTic.App.Dominio;


namespace GymTic.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Alimentacion> Alimentacion{get;set;}
        public DbSet<CategoriaEjercicios> categoriaEjercicios{get;set;}
        public DbSet<CategoriaNutricion> categoriaNutricion{get;set;}
        public DbSet<Cliente> Cliente{get;set;}        
        public DbSet<Dieta> Dieta{get;set;}
        public DbSet<Ejercicio> Ejercicio{get;set;}
        public DbSet<Nutricion> Nutricion{get;set;}
        public DbSet<PlanSaludable> PlanSaludable{get;set;}
        public DbSet<Rutina> Rutina{get;set;}
    
    
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GymTic_4");
            }
        }
    }
}
