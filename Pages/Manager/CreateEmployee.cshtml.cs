using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeamManager.Data.DataContext;
using TeamManager.Data.Models;

namespace TeamManager.Pages.Manager
{
    [IgnoreAntiforgeryToken]
    public class CreateEmployeeModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Employee employee { get; set; } = new();
        public CreateEmployeeModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.employee.Add(employee);
            await context.SaveChangesAsync();
            return RedirectToPage("Employees");
        }
    }
}
