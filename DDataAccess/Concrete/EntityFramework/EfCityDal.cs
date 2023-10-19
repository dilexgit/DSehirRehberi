using DCore.DataAccess.EntityFramework;
using DDataAccess.Abstract;
using DEntities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDataAccess.Concrete.EntityFramework
{
    public class EfCityDal : EfEntityRepositoryBase<City, DContext>, ICityDal
    {
   
        public List<City> GetCitiesIncludePhotos()
        {
            using (var context = new DContext())
            {

                var cities = context.Cities.Include(c => c.Photos).ToList();
                return cities;
            }

        }

        public City? GetCityIncludePhotosById(int id)
        {
            using (var context = new DContext())
            {
                var city = context.Cities.Include(c=>c.Photos).FirstOrDefault(c => c.Id == id);
                return city;
            }
        }
    }
}

