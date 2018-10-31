using Domain.Models;
using Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Domain.Repositories
{
    public class CommonRepository<C, T> : ICommonRepository<T>
        where C: DbContext
        where T: BaseModel
    {
        private C _dbContext;

        public CommonRepository(DbContext dbContext)
        {
            _dbContext = (C)dbContext ?? throw new ArgumentException("dbContext");
        }

        //public C Context
        //{
        //    get { return _dbContext; }
        //    set { _dbContext = value; }
        //}

        public virtual T Get(long? id)
        {
            ParameterExpression peEntity = Expression.Parameter(typeof(T), "e");
            PropertyInfo pi = typeof(T).GetProperty("Id");
            MemberExpression meIdProperty = Expression.Property(peEntity, pi);
            ConstantExpression ceId = Expression.Constant(id, typeof(long)); //TODO. Nullable or not? Check default id
            BinaryExpression beEqual = Expression.Equal(meIdProperty, ceId);
            var resultLambda = Expression.Lambda<Func<T, bool>>(beEqual, new ParameterExpression[] { peEntity });
            return _dbContext.Set<T>().SingleOrDefault(resultLambda);
        }

        public T GetBy(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).SingleOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = _dbContext.Set<T>();

            return query.AsEnumerable();
        }

        public IEnumerable<T> GetPage(int pageIndex, int pageSize)
        {
            IQueryable<T> query = _dbContext.Set<T>().OrderBy(p => p.Id).Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query.AsEnumerable();
        }

        public IEnumerable<T> GetPageByDateCreate(int pageIndex, int pageSize)
        {
            IQueryable<T> query = _dbContext.Set<T>().OrderBy(p => p.DateCreate).Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query.AsEnumerable();
        }

        public IEnumerable<T> GetPageByDateCreateDescending(int pageIndex, int pageSize)
        {
            IQueryable<T> query = _dbContext.Set<T>().OrderByDescending(p => p.DateCreate).Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query.AsEnumerable();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate);
        }

        public T Add(T entity)
        {
            return _dbContext.Set<T>().Add(entity);
        }

        public void CompleteRemove(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }

        public void Edit(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void InsertOrUpdate(T entity)
        {
            if (entity.Id == default(long?))
            {
                // New entity
                _dbContext.Set<T>().Add(entity);
            }
            else
            {
                // Existing entity
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
        }
    }
}
