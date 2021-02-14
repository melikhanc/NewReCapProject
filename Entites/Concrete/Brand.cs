
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }


        /*
         - Bir core katmanı oluşturduk tüm operatörler fonksiyonlar orda toplanacak.
         - core katmanında iki klasör açtık.(DataAccess, Entites)
         - IEntityRepository(DataAccess),IEntity(Entities) i core katmanına taşıdık.

        bu olaya code refactoring denir -> kodun iyileştirilmesi. 

         */
    }
}
