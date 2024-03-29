﻿using DCore.DataAccess;
using DCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DCore.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        
        void IEntityRepository<TEntity>.Add(TEntity entity)
        {
            using (var context = new TContext())
            {
               var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        void IEntityRepository<TEntity>.Update(TEntity entity)
        {
            using(var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        void IEntityRepository<TEntity>.Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        TEntity IEntityRepository<TEntity>.Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() :
               context.Set<TEntity>().Where(filter).ToList();
            }
        }


    }
}

