using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using testWebClient.Contracts;

namespace testWebClient.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ILucasService _ilucasService;
        public int Status { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ILucasService ilucasService)
        {
            _logger = logger;
            _ilucasService = ilucasService;
        }

        public void OnGet()
        {
            _ilucasService.GetDataAsync();
            Status = _ilucasService.GetDataAsync().Result.Status;
        }
        
    }
}
