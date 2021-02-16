using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {

        IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }
        public IResult Add(Users users)
        {
            _usersDal.Add(users);
            return new SuccessResult(Messages.Added);

        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Users> GeyById(int id)
        {
            return new SuccessDataResult<Users>(_usersDal.Get(g => g.Id == id));
        }

        IDataResult<List<Users>> IUsersService.GeyById(int id)
        {
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll(u => u.Id == id));
        }
    }
}
