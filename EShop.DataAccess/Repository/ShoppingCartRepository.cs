using EShop.DataAccess.Repository.IRepository;
using EShop.DataAcess.Data;
using EShop.Models;

namespace EShop.DataAccess.Repository;

public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository {
    private ApplicationDbContext _db;
    public ShoppingCartRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    

    public void Update(ShoppingCart obj)
    {
        _db.ShoppingCarts.Update(obj);
    }
}
