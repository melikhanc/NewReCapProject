using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class RentalDetails:IEntity
    {

        //Id, CarId,RentalCustomerId,RentDate,ReturnDate

        public int Id { get; set; }
        public int CarId { get; set; }
        public int RentalCustomerId { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }

    }
}
