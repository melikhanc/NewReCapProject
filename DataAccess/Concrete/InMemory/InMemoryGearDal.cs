
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryGearDal : IGearDal
    {

        List<Gear> _gears;
        public InMemoryGearDal()
        {
            _gears = new List<Gear>
            {
                new Gear{ GearId=1 , GearName="Otomatik" },
                new Gear{ GearId=2 , GearName="Yarı-Otomatik" },
                new Gear{ GearId=3 , GearName="Manuel " },


            };
        }
        public void Add(Gear gear)
        {
            _gears.Add(gear);
        }

        public void Delete(Gear gear)
        {
            Gear gearToDelete = _gears.SingleOrDefault(g=> g.GearId == gear.GearId);

            _gears.Remove(gearToDelete);
        }

        public Gear Get(Expression<Func<Gear, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Gear> GetAll()
        {
            return _gears;
        }

        public List<Gear> GetAll(Expression<Func<Gear, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<GearDetailDto> GetGearDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Gear gear)
        {
            Gear gearToUpdate = _gears.SingleOrDefault(g => g.GearId == gear.GearId);

            gearToUpdate.GearId = gear.GearId;
            gearToUpdate.GearName = gear.GearName;
        }
    }
}
