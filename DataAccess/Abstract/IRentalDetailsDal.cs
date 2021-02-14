using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDetailsDal:IEntityRepository<RentalDetails>
    {

        List<RentalDetailsDto> GetRentalDetails();
        /* List<Gear> GetAll();

         void Add(Gear gear);
         void Update(Gear gear);
         void Delete(Gear gear);*/


        /*
         - Bir core katmanı oluşturduk tüm operatörler fonksiyonlar orda toplanacak.
         - core katmanında iki klasör açtık.(DataAccess, Entites)
         - IEntityRepository(DataAccess),IEntity(Entities) i core katmanına taşıdık.

        bu olaya code refactoring denir -> kodun iyileştirilmesi. 

         */
    }
}
