using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GettingStarted.Frontend.Pages.PG004;

public class NicolasModel : PageModel
{
    private readonly ILogger<NicolasModel> _logger;

    public NicolasModel(ILogger<NicolasModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
