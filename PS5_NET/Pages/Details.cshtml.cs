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
        public Product p { get; set; }

        public void OnGet(int id)
        {
            int a = id;

        }


    }
}