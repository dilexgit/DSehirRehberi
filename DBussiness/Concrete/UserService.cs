using DBussiness.Abstract;
using DDataAccess.Abstract;
using DEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBussiness.Concrete
{
    public class UserService : IUserService
    {
        private IUserDal _userDal;
        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        List<User> IUserService.GetAll()
        {
            return _userDal.GetList();
        }

        void IUserService.Add(User user)
        {
            _userDal.Add(user);
        }

        void IUserService.Delete(User user)
        {
            _userDal.Delete(user);
        }



        void IUserService.Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
