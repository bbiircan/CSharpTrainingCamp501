﻿using CSharpTrainingCamp501.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpTrainingCamp501.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreateProductAsync(CreateProductDto createProductDto)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllProductsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task GetByProductIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
