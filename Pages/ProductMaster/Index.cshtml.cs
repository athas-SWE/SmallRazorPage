using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_pages1.DB;
using Razor_pages1.Models;

namespace Razor_pages1.Pages.ProductMaster
{
    public class IndexModel : PageModel
    {
        private readonly Razor_pages1.DB.AppDbContext _context;

        public IndexModel(Razor_pages1.DB.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
