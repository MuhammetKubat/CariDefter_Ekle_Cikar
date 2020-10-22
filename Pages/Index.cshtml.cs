using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using NewCariDefteri.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace NewCariDefteri.Pages
{
    public class IndexModel : PageModel
    {
        private readonly NewCariDefteri.Models.caridefteriContext _context;

        public IndexModel(NewCariDefteri.Models.caridefteriContext context)
        {

            try
            {
                _context = context;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
          public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]  
        public Users Users { get; set; }  
 



    }
}
