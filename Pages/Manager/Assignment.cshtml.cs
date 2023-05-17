using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeamManager.Data.DataContext;
using TeamManager.Data.Models;

namespace TeamManager.Pages.Manager
{
    public class TaskModel : PageModel
    {
        ApplicationContext context;
        public List<AssignmentCard> assignments { get; private set; } = new();


        public TaskModel(ApplicationContext db)
        {
            context = db;
        }

        public void OnGet()
        {
            assignments = context.assignmentCard.AsNoTracking().ToList();
        }
    }
}
