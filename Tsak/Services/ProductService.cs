using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Tsak.Data;
using Tsak.Dtos;
using Tsak.Models;

namespace Tsak.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext db;
        public ProductService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public int Create(CreateProductDto createProductDto)
        {
            var dbProduct = new Product
            {
                Name = createProductDto.Name,
                Cost = createProductDto.Cost,
                Price = createProductDto.Price
            };
            db.Products.Add(dbProduct);
            db.SaveChanges();
            return dbProduct.Id;
        }

        public int Edit(EditProductDto editProductDto)
        {
            var dbProduct = db.Products.Find(editProductDto.Id); 
            dbProduct.Name = editProductDto.Name;
            dbProduct.Cost = editProductDto.Cost;
            dbProduct.Price = editProductDto.Price;
            db.Products.Update(dbProduct);
            db.SaveChanges();
            return dbProduct.Id;
        }

        public bool Delete(int id)
        {
            try
            {
                var product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            catch (Exception exc) { }
            return false;
        }
    }
}