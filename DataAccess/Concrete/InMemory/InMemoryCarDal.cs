using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {

            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=1, DailyPrice=7500, Description="CLA 200" , ModelYear=2015},
                new Car{ Id=2, BrandId=2, ColorId=1, DailyPrice=7000, Description="5.20 i" , ModelYear=2014},
                new Car{ Id=3, BrandId=2, ColorId=2, DailyPrice=7500, Description="5.20 xDrive " , ModelYear=2012},
                new Car{ Id=4, BrandId=1, ColorId=3, DailyPrice=8500, Description="GLA 200" , ModelYear=2013},
                new Car{ Id=5, BrandId=3, ColorId=2, DailyPrice=12500, Description="Reventon Roadster" , ModelYear=2006},
                new Car{ Id=6, BrandId=3, ColorId=3, DailyPrice=14000, Description="Diablo GT 1" , ModelYear=2005},
                new Car{ Id=7, BrandId=4, ColorId=4, DailyPrice=25, Description="Şahin" , ModelYear=1990},

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            //LINQ Yöntemi
            //c=> "=>" işaretine Lambda deniyor
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);


        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
