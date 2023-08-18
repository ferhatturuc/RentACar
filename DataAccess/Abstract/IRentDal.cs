using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IRentDal : IEntityRepository<Rent>
    {
        List<RentalDetailDto> GetRentDetails();
        List<RentalDetailDto> GetRentDetailsByCarId(int carId);

    }
}
