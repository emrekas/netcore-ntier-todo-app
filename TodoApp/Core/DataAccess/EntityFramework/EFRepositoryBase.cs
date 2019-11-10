using Core.Entities;
using Core.IBaseRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EFRepositoryBase<TEntity, TKey, TContext> : IRepository<TEntity, TKey>
        where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
    {
        public int Add(TEntity entity)
        {
            using var context = new TContext();

            context.Set<TEntity>().Add(entity);
            return context.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            using var context = new TContext();

            context.Set<TEntity>().Remove(entity);
            return context.SaveChanges();
        }

        public int DeleteById(TKey key)
        {
            var entity = GetById(key);

            return Delete(entity);
        }

        public IEnumerable<TEntity> GetAllByExp(Expression<Func<TEntity, bool>> exp = null)
        {
            using var context = new TContext();

            return exp == null ? context.Set<TEntity>().AsNoTracking().ToList() : context.Set<TEntity>().AsNoTracking().Where(exp).ToList();
        }

        public int Update(TEntity entity)
        {
            using var context = new TContext();

            context.Set<TEntity>().Update(entity);
            return context.SaveChanges();
        }

        public TEntity GetById(TKey key)
        {
            using var context = new TContext();

            return context.Set<TEntity>().Find(key);
        }

        public TEntity GetByExp(Expression<Func<TEntity, bool>> exp)
        {
            using var context = new TContext();

            return context.Set<TEntity>().AsNoTracking().FirstOrDefault(exp);
        }
    }
}
