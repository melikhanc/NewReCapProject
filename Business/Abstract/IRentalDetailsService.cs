using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalDetailsService
    {

        IDataResult<List<RentalDetails>> GetAll();
        IResult Add(RentalDetails rentalDetails);
    }
}
