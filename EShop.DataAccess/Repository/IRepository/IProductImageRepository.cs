using EShop.Models;

namespace EShop.DataAccess.Repository.IRepository;

public interface IProductImageRepository : IRepository<ProductImage>
{
    void Update(ProductImage obj);
}
