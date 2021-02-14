using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>

        
    {
        /*List<Car> GetAll();

         void Add(Car car );
         void Update(Car car);
         void Delete(Car car);*/

        /*
         - Bir core katmanı oluşturduk tüm operatörler fonksiyonlar orda toplanacak.
         - core katmanında iki klasör açtık.(DataAccess, Entites)
         - IEntityRepository(DataAccess),IEntity(Entities) i core katmanına taşıdık.

         bu olaya code refactoring denir -> kodun iyileştirilmesi. 

         */
        List<CarDetailDto> GetCarDetails();
    }
}
