using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeamManager.Data.DataContext;
using TeamManager.Data.Models;

namespace TeamManager.Pages.Manager
{
    public class CreateAssignmentModel : PageModel
    {

        ApplicationContext context;
        [BindProperty]
        public AssignmentCard assignment { get; set; } = new();
        public CreateAssignmentModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.assignmentCard.Add(assignment);
            await context.SaveChangesAsync();
            return RedirectToPage("Assignment");
        }
        public void OnGet()
        {
        }
    }
}
