﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Brand> GetById(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
