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
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brand;
        public InMemoryBrandDal()
        {
            _brand = new List<Brand>
            {
                new Brand{ BrandId=1, BrandName="Mercedes"},
                new Brand{ BrandId=2, BrandName="BMW"},
                new Brand{ BrandId=3, BrandName="Lamborghini"},
                new Brand{ BrandId=4, BrandName="Tofaş"}


            };
        }
       

        public void Add(Brand brand)
        {
            _brand.Add(brand); 
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brand.SingleOrDefault(b => b.BrandId == brand.BrandId);


            _brand.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brand;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<BrandDetailDto> GetBrandDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brand.SingleOrDefault(b=> b.BrandId==brand.BrandId);

            brandToUpdate.BrandId = brand.BrandId;
            brandToUpdate.BrandName = brand.BrandName;

        }
    }
}
