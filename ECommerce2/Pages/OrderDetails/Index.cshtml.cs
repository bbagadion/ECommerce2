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
    public class IndexModel : PageModel
    {
        private readonly ECommerce2.Data.ApplicationDbContext _context;

        public IndexModel(ECommerce2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<OrderDetail> OrderDetail { get;set; }

        public async Task OnGetAsync()
        {
            OrderDetail = await _context.OrderDetail.ToListAsync();
        }
    }
}
