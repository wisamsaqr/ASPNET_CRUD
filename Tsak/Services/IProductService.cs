using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tsak.Data;
using Tsak.Dtos;
using Tsak.Models;

namespace Tsak.Services
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public Product Get(int id);
        public int Create(CreateProductDto createProductDto);
        public int Edit(EditProductDto editProductDto);
        public bool Delete(int id);
    }
}