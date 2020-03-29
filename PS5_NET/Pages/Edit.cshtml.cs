using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PS5_NET.Models;

namespace PS5_NET
{
    public class EditModel : MyPageModel
    {
        [BindProperty]
        public Product nProduct { get; set; }
        public int test;




        public void OnGet()
        {
           
        }

        public IActionResult OnPost(int id)
        {
            test = id;
            LoadDB();
            productDB.Edit(nProduct,test);
            SaveDB();
            return RedirectToPage("List");
        }
    }
}