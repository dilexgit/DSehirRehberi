using DEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBussiness.Abstract
{
    public interface IPhotoService
    {
        Photo GetPhoto(int id);
        List<Photo> GetPhotosByCityId(int cityId);
    }
}
