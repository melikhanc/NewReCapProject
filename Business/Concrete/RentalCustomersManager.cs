using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalCustomersManager : IRentalCustomersService

       
    {
        IRentalCustomersDal _rentalCustomersDal;

        public RentalCustomersManager(IRentalCustomersDal rentalCustomersDal)
        {

            _rentalCustomersDal = rentalCustomersDal;

        }

        public IResult Add(RentalCustomers rentalCustomers)
        {
            _rentalCustomersDal.Add(rentalCustomers);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<RentalCustomers>> GetAll()
        {
            return new SuccessDataResult<List<RentalCustomers>>(_rentalCustomersDal.GetAll(), Messages.Listed);
        }
    }
}
