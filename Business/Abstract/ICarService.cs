﻿using Core.Utilities.Results;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult  <List<Car>> GetCarsByColorId(int id);
        IResult Add(Car car);
        IDataResult< List<CarDetailDto>> GetCarDetails();

        IResult Deleted(Car car);

       






    }
}
