using ECommerce2.Data;
using ECommerce2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        private ApplicationDbContext db;
        public List<Product> featuredProducts { get; set; }
        private readonly ECommerce2.Data.ApplicationDbContext _context;


        public IndexModel(ECommerce2.Data.ApplicationDbContext _db)
        {
            db = _db;

        }

        public IActionResult OnGet()
        {
            featuredProducts = db.Product.ToList();
            return Page();
        }

        
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           

            return RedirectToPage("./Index");
        }
    }
}
