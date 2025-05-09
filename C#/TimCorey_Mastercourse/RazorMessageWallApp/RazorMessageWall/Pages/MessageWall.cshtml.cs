using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMessageWall.Pages
{
    public class MessageWallModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();

        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }

        [BindProperty]
        public string WelcomeMessage => $"Hi {FirstName} {LastName}";

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            Messages.Add(Message);
            return Page();
        }
    }
}
