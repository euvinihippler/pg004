using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GettingStarted.Frontend.Pages.PG004;

public class FelipeModel : PageModel
{
    private readonly ILogger<FelipeModel> _logger;

    public FelipeModel(ILogger<FelipeModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
