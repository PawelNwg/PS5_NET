﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PS5_NET.DAL;
using PS5_NET.Models;

namespace PS5_NET
{
    public class CartModel : MyPageModel
    {
        [BindProperty]
        public Product product { get; set; }

        public List<Product> _products;
        public void OnGet()
        {

            LoadDB();
            var cookie = Request.Cookies["Cart"];
            if (cookie != null)
            {
                string[] cookie_string = cookie.Split(" ");
                _products = new List<Product>();
                Product temp = null;
                foreach (string id in cookie_string)
                {
                    if (id != "")
                    {
                        temp = Find(Convert.ToInt32(id));
                    }
                    if (temp != null)
                    {
                        if(_products.Contains(temp) != true)
                        _products.Add(temp);
                    }
                }
            }
        }
       
        private Product Find(int id)
        {
            
            foreach (Product p in productDB.products)
            {
                if (p.id == id) 
                    return p;
            }
            return null;
        }
        public IActionResult OnPost()
        {
            Response.Cookies.Append("Cart", "");
            return RedirectToPage("Cart");
        }
    }
}