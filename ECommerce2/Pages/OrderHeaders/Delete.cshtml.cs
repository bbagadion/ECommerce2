using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ECommerce2.Data;
using ECommerce2.Models;

namespace ECommerce2.Pages.OrderHeaders
{
    public class DeleteModel : PageModel
    {
        private readonly ECommerce2.Data.ApplicationDbContext _context;

        public DeleteModel(ECommerce2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderHeader OrderHeader { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderHeader = await _context.OrderHeader.FirstOrDefaultAsync(m => m.OrderHeader_OrderID == id);

            if (OrderHeader == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderHeader = await _context.OrderHeader.FindAsync(id);

            if (OrderHeader != null)
            {
                _context.OrderHeader.Remove(OrderHeader);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
