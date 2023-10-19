using DEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBussiness.Abstract
{
    public interface ICityService
    {
        List<City> GetCitiesIncludePhotos();
        City? GetCityIncludePhotosById(int id);

        List<City> GetAll();
        City Get(int id);
        void Add(City city);
        void Update(City city);
        void Delete(City city);
    }
}
