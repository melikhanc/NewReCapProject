using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>

        
    {

        List<ColorDetailDto> GetColorDetails();
        /* List<Color> GetAll();

         void Add(Color color);
         void Update(Color color);
         void Delete(Color color);*/

        /*
         - Bir core katmanı oluşturduk tüm operatörler fonksiyonlar orda toplanacak.
         - core katmanında iki klasör açtık.(DataAccess, Entites)
         - IEntityRepository(DataAccess),IEntity(Entities) i core katmanına taşıdık.

        bu olaya code refactoring denir -> kodun iyileştirilmesi. 

         */

    }
}
