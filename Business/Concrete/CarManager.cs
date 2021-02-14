using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            /* if (car.Description.Length > 2 && car.DailyPrice >0)
             {
                 _carDal.Add(car);

                 Console.WriteLine("Araba Eklendi");
             }
             else
             {
                 Console.WriteLine("Belirttiğiniz araba ekleme standartlarına uymamaktadır.");
             }*/
            if (car.Description.Length<2)
            {

                return new ErrorResult(Messages.Invalid);

            }
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
            


           
        }

        public IDataResult< List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MainteinceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        public IDataResult <List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MainteinceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult <List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult <List<Car>> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

       

       /* public IDataResult<List<Car>> ICarService.GetAll()
        {
            throw new NotImplementedException();
        }*/

       /* public IDataResult<List<CarDetailDto>> ICarService.GetCarDetails()
        {
            throw new NotImplementedException();
        }*/

        /*public IDataResult<List<Car>> ICarService.GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> ICarService.GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }*/
    }
}
