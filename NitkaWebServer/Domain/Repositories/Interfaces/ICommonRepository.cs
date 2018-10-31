using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Repositories.Interfaces
{
    public interface ICommonRepository<T> where T: BaseModel
    {
        T Get(long? id);
        T GetBy(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetPage(int pageIndex, int pageSize);
        IEnumerable<T> GetPageByDateCreate(int pageIndex, int pageSize);
        IEnumerable<T> GetPageByDateCreateDescending(int pageIndex, int pageSize);
        T Add(T entity);
        void CompleteRemove(T entity);
        void Edit(T entity);
        void Save();
        void InsertOrUpdate(T entity);
    }
}
