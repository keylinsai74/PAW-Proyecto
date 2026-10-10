using PAW.Models;
using PAW.Repositories;

namespace PAW.DataAccess.Repositories;

public interface IUserRoleRepository : IRepositoryBase<UserRole>
{
}

public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
{
}