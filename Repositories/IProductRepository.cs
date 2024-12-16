using CSharpTrainingCamp501.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpTrainingCamp501.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(int id);
        Task GetByProductIdAsync(int id);
    }
}
