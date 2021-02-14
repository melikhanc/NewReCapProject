using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.DTOs
{
    public class RentalCustomerDetailDto:IDto
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }

    }
}
