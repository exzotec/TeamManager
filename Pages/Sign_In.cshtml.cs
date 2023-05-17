using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeamManager.Data.DataContext;
using TeamManager.Data.Models;

namespace TeamManager.Pages
{
    
    public class Sign_InModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public userAuth auth { get;} = new();
        public Sign_InModel(ApplicationContext db)
        {
            context = db;
        }
        //[Authorize]
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("Index.chtml");
        }
        public void OnGet()
        {
        }
    }
}
