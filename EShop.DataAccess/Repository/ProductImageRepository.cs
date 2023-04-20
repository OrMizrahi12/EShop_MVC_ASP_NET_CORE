using EShop.DataAccess.Repository.IRepository;
using EShop.DataAcess.Data;
using EShop.Models;

namespace EShop.DataAccess.Repository;

public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository 
    {
    private ApplicationDbContext _db;
    public ProductImageRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    

    public void Update(ProductImage obj)
    {
        _db.ProductImages.Update(obj);
    }
}
