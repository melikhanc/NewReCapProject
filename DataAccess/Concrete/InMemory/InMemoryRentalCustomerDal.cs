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
    public class InMemoryRentalCustomerDal : IRentalCustomersDal
    {

        List<RentalCustomers> _rentalCustomers;


        public InMemoryRentalCustomerDal()
        {
            _rentalCustomers = new List<RentalCustomers>
            {
                new RentalCustomers{ UserId=1 , CompanyName = "Rent Office"}


            };
            




        }
        public void Add(RentalCustomers rentalCustomers)
        {
            _rentalCustomers.Add(rentalCustomers);
        }

        public void Delete(RentalCustomers rentalCustomers)
        {
            RentalCustomers rentalCustomersToDelete = _rentalCustomers.SingleOrDefault(rc=> rc.UserId==rentalCustomers.UserId);

            _rentalCustomers.Remove(rentalCustomersToDelete);
        }

        public RentalCustomers Get(Expression<Func<RentalCustomers, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<RentalCustomers> GetAll(Expression<Func<RentalCustomers, bool>> filter = null)
        {
            return _rentalCustomers;
        }

        public List<RentalCustomerDetailDto> GetRentalCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(RentalCustomers rentalCustomers)
        {
            RentalCustomers rentalCustomersToUpdate = _rentalCustomers.SingleOrDefault(rc => rc.UserId == rentalCustomers.UserId);

            rentalCustomersToUpdate.UserId = rentalCustomers.UserId;
            rentalCustomersToUpdate.CompanyName = rentalCustomers.CompanyName;

           
        }
    }
}
