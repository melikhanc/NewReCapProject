﻿using Core.DataAccess.EntityFramework;
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
    public class EfBrandDal : EfEntityRepositoryBase<Brand, NorthwindContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            throw new NotImplementedException();
        }
    }
}
