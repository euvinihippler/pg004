using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GettingStarted.Frontend.Pages.PG004;

public class EliedsModel : PageModel
{
    private readonly ILogger<EliedsModel> _logger;

    public EliedsModel(ILogger<EliedsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
