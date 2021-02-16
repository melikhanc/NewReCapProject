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
    public class RentalDetailsManager : IRentalDetailsService
    {

        IRentalDetailsDal _rentalDetailsDal;

        public RentalDetailsManager(IRentalDetailsDal rentalDetailsDal)
        {
            _rentalDetailsDal = rentalDetailsDal;
        }
        public IResult Add(RentalDetails rentalDetails)
        {
            _rentalDetailsDal.Add(rentalDetails);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(RentalDetails rentalDetails)
        {
            _rentalDetailsDal.Delete(rentalDetails);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<RentalDetails>> GetAll()
        {
            return new SuccessDataResult<List<RentalDetails>>(_rentalDetailsDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<RentalDetails>> GetRentalDetailsByCarsId(int id)
        {
            return new SuccessDataResult<List<RentalDetails>>(_rentalDetailsDal.GetAll(rd => rd.CarId == id));
        }
    }
}
