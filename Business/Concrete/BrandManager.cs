using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult <List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(Messages.Listed);
        }

        public IDataResult <Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId));

            
        }

        /*IDataResult<List<Brand>> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Brand> IBrandService.GetById(int brandId)
        {
            throw new NotImplementedException();
        }*/
    }
}
