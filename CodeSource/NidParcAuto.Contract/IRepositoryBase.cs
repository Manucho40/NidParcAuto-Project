using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query;
using NidParcAuto.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NidParcAuto.Contract
{
    public interface IRepositoryBase<T> where T : class
    {
        
        Task<IEnumerable<T>> FindAll();
        Task<T> RegisterAdd(T entityObj);
        //IEnumerable<T> FindAllInheritance();
        //IEnumerable<T> FindByConditionInheritance(Expression<Func<T, bool>> expression);
        //IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        //IQueryable<T> FindByCondition2(Expression<Func<T, bool>> expression);
        //IQueryable<T> FromSqlRaw(string query, SqlParameter parameter);
        //IQueryable<T> FromSqlRaw(string query);
        //IQueryable<T> FromSqlRaw(string query, params SqlParameter[] parameter);
        //IEnumerable<T> FindByConditionInclude(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        //Task<IEnumerable<T>> FindByConditionIncludeAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        //IEnumerable<T> FindAllInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        //Task<IEnumerable<T>> FindAllIncludeAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        //Task<IEnumerable<T>> FindAllAsync();
        //Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression);
        //void Create(T entity);
        //void Update(T entity);
        //void Delete(T entity);
        //void CreateRange(IEnumerable<T> entities);
        //void UpdateRange(IEnumerable<T> entities);
        //void DeleteRange(IEnumerable<T> entities);
        //Task CreateRangeAsync(IEnumerable<T> entities);
        //void Save();
        //Task SaveAsync();
    }
}
