using EShop.DataAccess.Repository.IRepository;
using EShop.DataAcess.Data;
using EShop.Models;

namespace EShop.DataAccess.Repository;

public class CompanyRepository : Repository<Company>, ICompanyRepository 
    {
    private ApplicationDbContext _db;
    public CompanyRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    

    public void Update(Company obj)
    {
        _db.Companies.Update(obj);
    }
}
