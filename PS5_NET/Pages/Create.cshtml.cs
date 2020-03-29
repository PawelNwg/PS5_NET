using Microsoft.AspNetCore.Mvc;
using PS5_NET.Models;
namespace PS5_NET
{
    public class CreateModel : MyPageModel
    {
        [BindProperty]
        public Product newProduct { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            LoadDB();
            productDB.Create(newProduct);
            SaveDB();
            return RedirectToPage("List");
        }
    }
}
