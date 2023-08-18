using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DbForRecapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (DbForRecapContext context = new DbForRecapContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 BrandName = br.BrandName,
                                 ModelName = ca.ModelName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 BrandId = br.Id,
                                 ColorId = co.Id,
                                 Id = ca.Id,
                                 ModelYear = ca.ModelYear,
                                 Description = ca.Description,
                                 MinFindeksScore = ca.MinFindeksScore,
                                 CarImages = context.CarImages.Where(ci => ci.CarId == ca.Id).ToList()

                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
