using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGearService
    {
        IDataResult <List<Gear>>GetAll();
        IDataResult<Gear> GetById(int gearId);
    }
}
