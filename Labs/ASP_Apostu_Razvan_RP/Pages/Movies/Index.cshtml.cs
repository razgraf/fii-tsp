using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Apostu_Razvan_RP.Data;
using ASP_Apostu_Razvan_RP.Models;

namespace ASP_Apostu_Razvan_RP.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ASP_Apostu_Razvan_RP.Data.RazorPagesMovieContext _context;

        public IndexModel(ASP_Apostu_Razvan_RP.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
