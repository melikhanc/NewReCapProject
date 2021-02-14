﻿using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult <List<Brand>> GetAll();

        IDataResult <Brand> GetById(int brandId);
    }
}
