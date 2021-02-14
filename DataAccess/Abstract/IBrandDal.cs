using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>


    {

        List<BrandDetailDto> GetBrandDetails();

        /*List<Brand> GetAll();

        void Add(Brand brand );
        void Update(Brand brand);
        void Delete(Brand brand);*/

        /*
         - Bir core katmanı oluşturduk tüm operatörler fonksiyonlar orda toplanacak.
         - core katmanında iki klasör açtık.(DataAccess, Entites)
         - IEntityRepository(DataAccess),IEntity(Entities) i core katmanına taşıdık.

        bu olaya code refactoring denir -> kodun iyileştirilmesi. 

         */
    }
}
