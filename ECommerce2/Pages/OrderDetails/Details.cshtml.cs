using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ECommerce2.Data;
using ECommerce2.Models;

namespace ECommerce2.Pages.OrderDetails
{
    public class DetailsModel : PageModel
    {
        private readonly ECommerce2.Data.ApplicationDbContext _context;

        public DetailsModel(ECommerce2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public OrderDetail OrderDetail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderDetail = await _context.OrderDetail.FirstOrDefaultAsync(m => m.OrderDetail_OrderID == id);

            if (OrderDetail == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
