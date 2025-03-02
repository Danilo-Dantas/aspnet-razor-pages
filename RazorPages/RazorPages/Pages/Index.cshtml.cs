using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public string Title { get; set; }

        public void OnGet()
        {
            Title = "My First APP From IndexModel";
        }
    }
}
