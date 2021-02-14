using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUsersDal : EfEntityRepositoryBase<Users, NorthwindContext>, IUsersDal
    {
        public List<UsersDetailDto> GetUsersDetails()
        {
            throw new NotImplementedException();
        }
    }
}
