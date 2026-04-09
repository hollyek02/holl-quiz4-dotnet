using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace holl_quiz4_agile.Pages;

public class IndexModel : PageModel
{
    public required string DbMessage { get; set; }
    public void OnGet()
    {
        DbMessage = "Database access has already been done on April 6, 2026 by Holly Edwards-Kiss";
    }
}
