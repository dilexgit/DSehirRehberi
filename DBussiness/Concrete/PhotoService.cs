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
    public class PhotoService :IPhotoService
    {
        private IPhotoDal _photoDal;
        public PhotoService(IPhotoDal photoDal)
        {
            _photoDal = photoDal;
        }

        public Photo GetPhoto(int id)
        {
           var photo= _photoDal.Get(x=> x.Id == id);
            return photo;
        }

        public List<Photo> GetPhotosByCityId(int cityId)
        {
            var photos = _photoDal.GetList(x=> x.CityId == cityId);
            return photos;
        }
    }
}
