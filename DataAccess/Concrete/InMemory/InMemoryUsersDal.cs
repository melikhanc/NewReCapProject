using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryUsersDal : IUsersDal
    {
        List<Users> _users;
        public InMemoryUsersDal()
        {
            _users = new List<Users>
            {
                new Users{ Id=1, EMail="acs@wer.com", FirstName="Melikhan", LastName="Çelebi", Password="12345"},


            };

        }
        public void Add(Users users)
        {
            _users.Add(users);
        }

        public void Delete(Users users)
        {
            throw new NotImplementedException();
        }

        public Users Get(Expression<Func<Users, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll(Expression<Func<Users, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<UsersDetailDto> GetUsersDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
