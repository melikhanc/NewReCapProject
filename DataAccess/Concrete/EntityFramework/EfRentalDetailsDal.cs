using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDetailsDal : EfEntityRepositoryBase<RentalDetails, NorthwindContext>, IRentalDetailsDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
             using (NorthwindContext context = new NorthwindContext())
              {
                  var result = from rd in context.RentalDetails
                               join c in context.Cars
                               on rd.CarId equals c.Id
                               select new  RentalDetailsDto
                               {
                                   Id = rd.Id,
                                   CarId=rd.CarId,
                                   ModelYear=c.ModelYear,
                                   DailyPrice=c.DailyPrice,
                                   Description=c.Description



                               };
                  return result.ToList();
              }

            //throw new NotImplementedException();
        }
    }
}
