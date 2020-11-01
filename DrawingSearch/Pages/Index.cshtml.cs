using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DrawingSearch.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        //public void OnGet()
        //{

        //}
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            return Redirect("/ButtonComplete");
        }
    }
}