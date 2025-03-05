using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data;

namespace RazorPages.Pages.Movies
{
    public class IndexModel(MoviesContext moviesContext) : PageModel
    {
        public ICollection<Movie> Movies { get; private set; }

        public void OnGet()
        {
            Movies = moviesContext.Movies.ToList();
        }

        //public async Task OnGetAsync()
        //{
        //    Movies = await moviesContext.Movies.ToListAsync();
        //}
    }
}
