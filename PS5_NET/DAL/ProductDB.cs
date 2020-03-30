using Newtonsoft.Json;
using PS5_NET.Models;
using System;
using System.Collections.Generic;

namespace PS5_NET.DAL
{
    public class ProductDB 
    {
        public List<Product> products;
        public void Load(string jsonProducts)
        {
            if (jsonProducts == null)
            {
                products = Product.GetProducts();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<Product>>(jsonProducts);
            }
        }

        private int GetNextId()
        {
            
            if (products.Count >= 1)
            {
                int lastID = products[products.Count-1].id;
                int newID = ++lastID;
                return newID;
            }
            else
            {
                int lastID = 0;
                int newID = ++lastID;               
                return newID;
            }

        }
        public void Create(Product p)
        {
            p.id = GetNextId();
            products.Add(p);
        }
        public string Save()
        {

            return JsonConvert.SerializeObject(products);
        }
        public List<Product> List()
        {
            return products;
        }
        public void Delete(int id)
        {
            products.RemoveAt(id-1);
            Sort();
        }

        public void Edit(Product p, int  id)
        {
           for(int i = 0; i < products.Count; i++)
            {
                if (products[i].id == id)
                    products[i].price = p.price;
            }

        }

        public void Sort()
        {
            products.Sort((x, y) => x.id.CompareTo(y.id));
            for (int i = 0; i < products.Count; i++)
                products[i].id = i + 1;
        }

                 
        public Product GetProductByID(int id)
        {
            return products.Find(p => p.id == id);
        }



    }
}