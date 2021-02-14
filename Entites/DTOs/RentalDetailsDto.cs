using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.DTOs
{
    public class RentalDetailsDto:IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int RentalCustomerId { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
