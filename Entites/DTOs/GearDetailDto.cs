using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.DTOs
{
    public class GearDetailDto:IDto
    {

        public int GearId { get; set; }

        public string GearName { get; set; }
    }
}
