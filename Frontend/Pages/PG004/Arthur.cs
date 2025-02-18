using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GettingStarted.Frontend.Pages.PG004;

public class ArthurModel : PageModel
{
    private readonly ILogger<ArthurModel> _logger;

    public ArthurModel(ILogger<ArthurModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
