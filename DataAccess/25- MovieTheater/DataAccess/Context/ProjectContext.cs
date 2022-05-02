using DataAccess.Entity;
using System.Data.Entity;

namespace DataAccess.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-JOE5KI8\\SQLEXPRESS02;Database=HDFilmCehennemiDB;Trusted_Connection=True;";
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Theater> Theaters { get; set; }

        public DbSet<MoviesCategory> MoviesCategories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //many to many(çoka çok ilişki) todo: burada ara tabloyu oluşturunca ara tabloya ekleme yapılamıyor ???? 
            //modelBuilder.Entity<Movie>()
            //    .HasMany(x => x.Categories)
            //    .WithMany(x => x.Movies)
            //    .Map(map =>
            //    {
            //        map.ToTable("MoviesCategories");
            //        map.MapLeftKey("MovieId");
            //        map.MapRightKey("CategoryId");
            //    });
            base.OnModelCreating(modelBuilder);
        }        
    }
}
