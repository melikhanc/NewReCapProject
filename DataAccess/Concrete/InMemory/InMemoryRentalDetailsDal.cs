using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryRentalDetailsDal : IRentalDetailsDal
    {
        List<RentalDetails> _rentalDetails;

        public InMemoryRentalDetailsDal()
        {
            _rentalDetails = new List<RentalDetails>
            {

                new RentalDetails{ Id=1, CarId=1, RentalCustomerId=1, RentDate="01/01/2021", ReturnDate= "07/01/2021"}

            };
        }
        public void Add(RentalDetails rentalDetails)
        {
            _rentalDetails.Add(rentalDetails);
        }

        public void Delete(RentalDetails rentalDetails)
        {
            RentalDetails rentalDetailsToDelete = _rentalDetails.SingleOrDefault(rd=> rd.Id == rentalDetails.Id);

            _rentalDetails.Remove(rentalDetailsToDelete);
        }

        public RentalDetails Get(Expression<Func<RentalDetails, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<RentalDetails> GetAll(Expression<Func<RentalDetails, bool>> filter = null)
        {
            return _rentalDetails;
        }

        public List<RentalDetailsDto> GetRentalDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(RentalDetails rentalDetails)
        {
            throw new NotImplementedException();
        }
    }
}
