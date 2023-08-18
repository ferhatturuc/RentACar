using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentManager : IRentService
    {
        public IResult Add(Rent rent)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Rent rent)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rent> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDetailDto>> GetRentDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDetailDto>> GetRentDetailsByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IResult RulesForAdding(Rent rent)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rent rent)
        {
            throw new NotImplementedException();
        }
    }
}
