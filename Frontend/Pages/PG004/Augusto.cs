using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GettingStarted.Frontend.Pages.PG004;

public class AugustoModel : PageModel
{
    private readonly ILogger<AugustoModel> _logger;

    public AugustoModel(ILogger<AugustoModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
