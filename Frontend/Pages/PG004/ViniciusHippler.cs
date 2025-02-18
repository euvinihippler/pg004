using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GettingStarted.Frontend.Pages.PG004;

public class ViniciusHipplerModel : PageModel
{
    private readonly ILogger<ViniciusHipplerModel> _logger;

    public ViniciusHipplerModel(ILogger<ViniciusHipplerModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
