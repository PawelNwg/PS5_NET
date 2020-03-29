using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PS5_NET.Models;

namespace PS5_NET
{
    public class DeleteModel : MyPageModel
    {
        [BindProperty]
        public Product newProduct { get; set; }
        public IActionResult OnGet(int id)
        {          
                LoadDB();
                productDB.Delete(id);
                SaveDB();
                return RedirectToPage("List");
         
        }

    }
       

    }
