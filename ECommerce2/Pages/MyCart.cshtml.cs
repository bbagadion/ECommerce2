using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce2.Helpers;
using ECommerce2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce2.Pages
{
    public class Item
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
    public class MyCartModel : PageModel
    {
        public List<Item> cart { get; set; }
        public double Total { get; set; }

        public void OnGet()
        {
            try { 
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Total = cart.Sum(i => i.Product.Product_Price * i.Quantity);
            }
            catch (ArgumentNullException)
            {
                RedirectToPage("EmptyCart");
            }
        }

        public IActionResult OnGetBuyNow(int id)
        {
            var productModel = new ProductModel();
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = productModel.find(id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                int index = Exists(cart, id.ToString());
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Product = productModel.find(id),
                        Quantity = 1
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToPage("MyCart");
        }

        public IActionResult OnGetDelete(string id)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("MyCart");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (var i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("MyCart");
        }

        private int Exists(List<Item> cart, string id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Product_ID.ToString() == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
