using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzeriaSushi2._0.Pages;

public class AboutusModel : PageModel
{
    private readonly ILogger<AboutusModel> _logger;

    public AboutusModel(ILogger<AboutusModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


