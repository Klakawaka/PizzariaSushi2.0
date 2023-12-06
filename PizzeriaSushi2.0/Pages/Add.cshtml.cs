using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace PizzeriaSushi2._0.Pages
{
    public class AddModel : PageModel
    {
        private readonly ILogger<AddModel> _logger;

        public AddModel(ILogger<AddModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string InputText { get; set; }

        public List<string> SubmittedValues { get; set; } = new List<string>();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // Code to run when the form is submitted
            // Access the value of the text box using the property
            string inputValue = InputText;

            // Store the submitted value
            SubmittedValues.Add(inputValue);
        }
    }
}
