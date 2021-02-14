using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalCustomerDal : EfEntityRepositoryBase<RentalCustomers, NorthwindContext>, IRentalCustomersDal
    {
        public List<RentalCustomerDetailDto> GetRentalCustomerDetails()
        {
           
            throw new NotImplementedException();

        }
    }
}
