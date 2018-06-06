﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ETran.Data.Common;
using ETran.Data.Entities.Base;

namespace ETran.Data.Repository.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
       where T : Entity
    {
        private readonly ETranslationContext _context;

        public EntityBaseRepository(ETranslationContext context)
        {
            _context = context;
        }

        public virtual void Add(T entity)
        {
            DbEntityEntry dbEntityEntry = _context.Entry(entity);
            _context.Set<T>().Add(entity);
        }

        public virtual bool Commit()
        {
            var recordsCommitedCount = _context.SaveChanges();
            return (recordsCommitedCount > 0);
        }

        public virtual async Task<bool> CommitAsync()
        {
            var recordsCommitedCount = await _context.SaveChangesAsync();
            return (recordsCommitedCount > 0);
        }

        public int Count()
        {
            return _context.Set<T>().Count();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().CountAsync(predicate);
        }

        public void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = _context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entities = _context.Set<T>().Where(predicate);

            foreach (var entity in entities)
            {
                _context.Entry<T>(entity).State = EntityState.Deleted;
            }
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query.AsQueryable();
        }

        public IQueryable<T> GetAllNoneDeleted()
        {
            IQueryable<T> query = _context.Set<T>().Where(e => e.IsDeleted == false);
            return query.AsQueryable();
        }

        public T GetSingleNoneDeleted(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(t => t.IsDeleted == false).FirstOrDefault(predicate);
        }

        public async Task<T> GetSingleNoneDeletedAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(t => t.IsDeleted == false).FirstOrDefaultAsync(predicate);
        }

        public async Task<T> GetSingleNoneDeletedAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.Where(predicate).FirstOrDefaultAsync();
        }


        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.Where(predicate).FirstOrDefaultAsync();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query.Where(predicate).FirstOrDefault();
        }

        public void Update(T entity)
        {
            DbEntityEntry dbEntityEntry = _context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }
    }
}
