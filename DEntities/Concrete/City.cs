using DCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEntities.Concrete
{
    public class City:IEntity
    {
        //newlenmemesi durumunda photolar listelenirse null reference hatası alınır.
        public City()
        {
            Photos = new List<Photo>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Photo> Photos { get; set; }
        public User User { get; set; }
    }
}
