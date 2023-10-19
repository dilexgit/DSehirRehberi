using DCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEntities.Concrete
{
    public class Photo:IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Url { get; set; }
        public DateTime AddedTime { get; set; }
        public bool IsMain { get; set; }
        public string Description { get; set; }
        public string PublicId { get; set; }
        public City City { get; set; }
    }
}
