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
    public class GearManager : IGearService
    {
        IGearDal _gearDal;

        public GearManager(IGearDal gearDal)
        {
            _gearDal = gearDal;
        }

        public IDataResult< List<Gear>> GetAll()
        {

            return new SuccessDataResult<List<Gear>>(Messages.Listed);
        }

        public IDataResult < Gear> GetById(int gearId)
        {
            return new SuccessDataResult<Gear> (_gearDal.Get(g => g.GearId == gearId));
        }
    }
}
