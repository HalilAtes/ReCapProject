using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);

        User GetByMail(string email);

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);

    }
}
