using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        UserDto GetDto(Expression<Func<User, bool>> filter);
    }
}
