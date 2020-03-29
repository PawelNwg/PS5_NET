using System.Collections.Generic;
using PS5_NET.Models;


namespace PS5_NET
{
    public class ListModel : MyPageModel
    {
        public List<Product> productList;
        public void OnGet()
        {
            LoadDB();
            productList = productDB.List();
            SaveDB();
        }
    }
}