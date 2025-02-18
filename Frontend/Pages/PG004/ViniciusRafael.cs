using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GettingStarted.Frontend.Pages.PG004;

public class ViniciusRafaelModel : PageModel
{
    private readonly ILogger<ViniciusRafaelModel> _logger;

    public ViniciusRafaelModel(ILogger<ViniciusRafaelModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
