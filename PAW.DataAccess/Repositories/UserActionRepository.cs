using PAW.Models;
using PAW.Repositories;

namespace PAW.DataAccess.Repositories;

public interface IUserActionRepository : IRepositoryBase<UserAction>
{
}

public class UserActionRepository : RepositoryBase<UserAction>, IUserActionRepository
{
}