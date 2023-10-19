using DCore.DataAccess;
using DEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDataAccess.Abstract
{
    public interface ICityDal : IEntityRepository<City>
    {
        List<City> GetCitiesIncludePhotos();
        City? GetCityIncludePhotosById(int id);
    }
}
