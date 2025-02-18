using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GettingStarted.Frontend.Pages.PG004;

public class BrunaModel : PageModel
{
    private readonly ILogger<BrunaModel> _logger;

    public BrunaModel(ILogger<BrunaModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
