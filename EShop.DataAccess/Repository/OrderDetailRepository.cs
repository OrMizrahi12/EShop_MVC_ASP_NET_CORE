using EShop.DataAccess.Repository.IRepository;
using EShop.DataAcess.Data;
using EShop.Models;

namespace EShop.DataAccess.Repository;

public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
{
    private ApplicationDbContext _db;
    public OrderDetailRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    

    public void Update(OrderDetail obj)
    {
        _db.OrderDetails.Update(obj);
    }
}
