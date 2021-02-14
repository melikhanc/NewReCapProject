using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    //NuGet 
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto 
                             {Id=c.Id,
                             BrandName=b.BrandName,
                             ModelYear=c.ModelYear,
                             Description=c.Description

                             };
                return result.ToList();
            } 
        }
    }
}
