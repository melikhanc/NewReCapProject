using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUsersService
    {

        IDataResult<List<Users>> GetAll();
        IResult Add(Users users);

        IDataResult<List<Users>> GeyById(int id);

    }
}
