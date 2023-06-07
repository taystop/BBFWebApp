using BBFWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BBFWebApp.Pages
{
    public class NewsModel : PageModel
    {
        //Allows DB context to be used in the whole file
        private readonly MyDbContext _context;

        //Public list that will hold all news items
        public List<News> News { get; set; } = new List<News>();

        [BindProperty] 
        //Used to create new news items to save to DB
        public News NewNews { get; set; }

        //Constructor that assigns the DB context to the private variable
        public NewsModel(MyDbContext context)
        {
            _context = context;
        }

        //Handles all OnGet requests
        public void OnGet()
        {
            News = _context.News.ToList();
        }

        //Handles all OnPost requests
        public IActionResult OnPost()
        {
            _context.News.Add(NewNews);

            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
