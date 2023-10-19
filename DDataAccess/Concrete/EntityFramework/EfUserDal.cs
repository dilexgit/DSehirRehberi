using DCore.DataAccess.EntityFramework;
using DDataAccess.Abstract;
using DEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User, DContext>,IUserDal
    {
    }
}

