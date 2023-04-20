using EShop.DataAccess.Repository.IRepository;
using EShop.DataAcess.Data;
using EShop.Models;

namespace EShop.DataAccess.Repository;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private ApplicationDbContext _db;
    public CategoryRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    

    public void Update(Category obj)
    {
        _db.Categories.Update(obj);
    }
}
