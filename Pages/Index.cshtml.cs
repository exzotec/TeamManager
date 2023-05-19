using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamManager.Data.DataContext;
using TeamManager.Data.Models;

namespace TeamManager.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        ApplicationContext context;

        public IndexModel(ApplicationContext db)
        {
            context = db;
        }

        [BindProperty]
        public AssignmentCard assignment { get; set; }
        [BindProperty]
        public client Client { get; set; }

        public SelectList ClientList { get; set; }
        private void FillCLientList(ApplicationContext context, object selectedClient = null)
        {
            var client = from c in context.Client
                         orderby c.client_name
                         select c;
            ClientList = new SelectList(client.AsNoTracking(), "client_id", "client_name");
        }

        public IActionResult OnGet()
        {
            FillCLientList(context);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyAssignment = new AssignmentCard();

            if (await TryUpdateModelAsync<AssignmentCard>(
                 emptyAssignment,
                 "Assgnment",   // Prefix for form value.
                 s => s.task_id, s => s.client_id))
            {
                context.assignmentCard.Add(emptyAssignment);
                await context.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            // Select DepartmentID if TryUpdateModelAsync fails.
            FillCLientList(context, emptyAssignment.client_id);
            return Page();
        }



    }
}