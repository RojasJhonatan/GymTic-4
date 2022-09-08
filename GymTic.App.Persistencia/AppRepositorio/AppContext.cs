using Microsoft.EntityFrameworkCore;
using GymTic.App.Dominio;


namespace Gymtic.App.Persistencia
{
    public class _AppContext : DbContext
    {
        public DbSet<Alimentacion> Alimentacion{get;set;}
        public DbSet<CategoriaEjercicios> CategoriaEjercicios{get;set;}
        public DbSet<CategoriaNutricion> CategoriaNutricion{get;set;}
        public DbSet<Cliente> Cliente{get;set;}        
        public DbSet<Dieta> Dieta{get;set;}
        public DbSet<Ejercicios> Ejercicios{get;set;}
        public DbSet<Nutricion> Nutricion{get;set;}
        public DbSet<PlanSaludable> PlanSaludable{get; set;}
        public DbSet<Rutina> Rutina{get; set;}
        
        protected  override void  OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GymTic-4");
            }
        }
    }
}