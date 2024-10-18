using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace RIZE.AdminWeb.Models
{
    public class ErrorVM : PageModel
    {
        public string RequestId { get; set; }
        public bool ShowDetails { get; set; }
        public Exception Exception { get; set; }

        private readonly IWebHostEnvironment _env;

        public ErrorVM()
        {
            
        }
        public ErrorVM(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            ShowDetails = _env.IsDevelopment();
        }
    }

}
