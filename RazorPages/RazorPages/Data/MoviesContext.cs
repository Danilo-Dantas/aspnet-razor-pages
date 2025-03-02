using Microsoft.EntityFrameworkCore;
using Slugify;

namespace RazorPages.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext()
        {
            this.Database.EnsureCreated();
        }

        public MoviesContext(DbContextOptions<MoviesContext> options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var slugfy = new SlugHelper();

            string[] names = [
                "O Poderoso Chefão",
                "O Senhor dos Aneis: O Retorno Do Rei",
                "Interestelar",
                "Cidadão Kane",
                "O Silêncio dos Inocentes",
                "Matrix",
                "A Lista de Schindler",
                "Forrest Gump",
                "Star Wars: Episódio V - O Império Contra-Ataca",
                "Pump Fiction: Tempo de Violência"
            ];

            int counter = 1;
            var movies = new List<Movie>();
            foreach (string name in names)
            {
                movies.Add(new Movie
                {
                    Id = counter,
                    Name = name,
                    permalink = slugfy.GenerateSlug(name)
                });
                counter++;
            }

            modelBuilder
                .Entity<Movie>()
                .HasData(movies);


        }
    }
}
