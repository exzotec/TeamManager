using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeamManager.Data.DataContext;
using TeamManager.Data.Models;

namespace TeamManager.Pages.Manager
{
    public class EmployeesModel : PageModel
    {
        ApplicationContext context;
        public List<Employee> Employees { get; private set; } = new();

        public EmployeesModel(ApplicationContext db)
        {
            context = db;
        }

        public void OnGet()
        {
            Employees = context.employee.AsNoTracking().ToList();
        }
    }
}
