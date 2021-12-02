using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ECommerce2.Data;
using ECommerce2.Models;

namespace ECommerce2.Pages.Carts
{
    public class DetailsModel : PageModel
    {
        private readonly ECommerce2.Data.ApplicationDbContext _context;

        public DetailsModel(ECommerce2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Cart Cart { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cart = await _context.Cart.FirstOrDefaultAsync(m => m.Cart_CustomerID == id);

            if (Cart == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
