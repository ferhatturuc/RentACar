using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        public IResult Add(User user)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserDto> GetDtoById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateEmail(UpdateEmailDto updateEmailDto)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateFirstAndLastName(UpdateFirstAndLastNameDto updateFirstAndLastNameDto)
        {
            throw new NotImplementedException();
        }
    }
}
