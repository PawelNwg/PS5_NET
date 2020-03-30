  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PS5_NET.Models;

namespace PS5_NET
{
    public class DetailsModel : MyPageModel
    {
        [BindProperty]
        public Product product { get; set; }
        public void OnGet()
        {
            LoadDB();
            product = productDB.GetProductByID(Convert.ToInt32(Request.Query["id"]));
            SaveDB();
        }
        public IActionResult OnPost()
        {
            var cookie = Request.Cookies["Cart"];
            if (cookie == null)
            {
                Response.Cookies.Append("Cart", $"{product.id} ");
            }
            else
            {
                Response.Cookies.Append("Cart", $"{cookie} {product.id} ");
            }
            return RedirectToPage("Cart", new { id = product.id });
        }
    }
}

