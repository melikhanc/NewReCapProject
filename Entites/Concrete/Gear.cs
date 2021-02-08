using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class Gear:IEntity
    {
        public int GearId { get; set; }

        public string GearName { get; set; }


    }
}
