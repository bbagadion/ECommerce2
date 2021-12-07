using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce2.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly ECommerce2.Data.ApplicationDbContext _context;

        public CheckoutModel(ECommerce2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("/ThankYou");
        }
    }
    }

