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
    public class IndexModel : PageModel
    {
        private readonly ECommerce2.Data.ApplicationDbContext _context;

        public IndexModel(ECommerce2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<OrderHeader> OrderHeader { get;set; }

        public async Task OnGetAsync()
        {
            OrderHeader = await _context.OrderHeader.ToListAsync();
        }
    }
}
