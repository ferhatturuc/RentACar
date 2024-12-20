﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IDataResult<List<Payment>> GetAll();
        IDataResult<Payment> GetById(int id);
        IDataResult<List<Payment>> GetAllByCustomerId(int customerId);

        IResult Add (Payment payment);
        IResult Update (Payment payment);
        IResult Delete (Payment payment);
        IResult Pay (Payment payment);

        IResult CheckIfReserved(Payment payment);
    }
}
