using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.DTOs;

namespace ApplicationLayer.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO?> GetProductByIdAsync(int id);
        Task<ProductDTO?> AddProductAsync(CreateProductDTO productDto);
        Task UpdateProductAsync(UpdateProductDTO productDto);
        Task DeleteProductAsync(int id);
    }
}
