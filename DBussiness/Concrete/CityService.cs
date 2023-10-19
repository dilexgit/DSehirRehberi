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
    public class CityService : ICityService
    {
        private ICityDal _cityDal;

        public CityService(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        void ICityService.Add(City city)
        {
            _cityDal.Add(city);
        }

        void ICityService.Delete(City city)
        {
            _cityDal.Delete(city);
        }
        void ICityService.Update(City city)
        {
           _cityDal.Update(city);
        }
        List<City> ICityService.GetAll()
        {
            return _cityDal.GetList();
        }

        public City Get(int id)
        {
            return _cityDal.Get(x=>x.Id == id);
        }

        public List<City> GetCitiesIncludePhotos()
        {
            return _cityDal.GetCitiesIncludePhotos();
        }

        public City? GetCityIncludePhotosById(int id)
        {
            return _cityDal.GetCityIncludePhotosById(id);
        }
    }
}
