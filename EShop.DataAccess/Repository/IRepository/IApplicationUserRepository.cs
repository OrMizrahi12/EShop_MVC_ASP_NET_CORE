using EShop.Models;

namespace EShop.DataAccess.Repository.IRepository;

public interface IApplicationUserRepository : IRepository<ApplicationUser>
{
    public void Update(ApplicationUser applicationUser);
}
