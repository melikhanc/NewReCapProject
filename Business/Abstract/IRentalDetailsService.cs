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

        IDataResult<List<RentalDetails>> GetRentalDetailsByCarsId(int id);

        IResult Delete(RentalDetails rentalDetails);
       
    }
}
