using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using NidParcAuto.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NidParcAuto.API.Models;

namespace NidParcAuto.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DbNidParcAutoContext RepositoryContext { get; set; }

        public RepositoryBase(DbNidParcAutoContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public Task <IEnumerable<T>> FindAll()
        {
            return this.RepositoryContext.Set<T>().ToListAsync();
        }

        //public IEnumerable<T> FindAllInheritance()
        //{
        //    return this.RepositoryContext.Set<T>().OfType<T>();
        //}

        //public IEnumerable<T> FindByConditionInheritance(Expression<Func<T, bool>> expression)
        //{
        //    return this.RepositoryContext.Set<T>().OfType<T>().Where(expression);
        //}

        //public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        //{
        //    return this.RepositoryContext.Set<T>().Where(expression);
        //}

        //public IQueryable<T> FindByCondition2(Expression<Func<T, bool>> expression)
        //{
        //    return this.RepositoryContext.Set<T>().Where(expression);
        //}


        //public IEnumerable<T> FindAllInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        //{
        //    var result = this.RepositoryContext.Set<T>().AsQueryable();

        //    if (include != null)
        //        result = include(result);

        //    return result;
        //}

        //public async Task<IEnumerable<T>> FindAllIncludeAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        //{
        //    var result = this.RepositoryContext.Set<T>().AsQueryable();

        //    if (include != null)
        //        result = include(result);

        //    return await result.ToListAsync();
        //}

        //public IEnumerable<T> FindByConditionInclude(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        //{

        //    IQueryable<T> queryable = this.RepositoryContext.Set<T>().Where(expression);

        //    if (includes != null)
        //    {
        //        queryable = includes(queryable);
        //    }
        //    return queryable;
        //}

        //public async Task<IEnumerable<T>> FindByConditionIncludeAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        //{

        //    IQueryable<T> queryable = this.RepositoryContext.Set<T>().Where(expression);

        //    if (includes != null)
        //    {
        //        queryable = includes(queryable);
        //    }
        //    return await queryable.ToListAsync();
        //}

        //public IQueryable<T> FromSqlRaw(string query, SqlParameter parameter)
        //{
        //    return this.RepositoryContext.Set<T>().FromSqlRaw(query, parameter);
        //}



        //public IQueryable<T> FromSqlRaw(string query, params SqlParameter[] parameter)
        //{
        //    return this.RepositoryContext.Set<T>().FromSqlRaw(query, parameter);
        //}



        //public IQueryable<T> FromSqlRaw(string query)
        //{
        //    return this.RepositoryContext.Set<T>().FromSqlRaw(query);
        //}



        //public async Task<IEnumerable<T>> FindAllAsync()
        //{
        //    return await this.RepositoryContext.Set<T>().ToListAsync();
        //}

        //public async Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression)
        //{
        //    return await this.RepositoryContext.Set<T>().Where(expression).ToListAsync();
        //}

        //public void Create(T entity)
        //{
        //    this.RepositoryContext.Set<T>().Add(entity);
        //}

        //public void Update(T entity)
        //{
        //    this.RepositoryContext.Set<T>().Update(entity);
        //}

        //public void Delete(T entity)
        //{
        //    this.RepositoryContext.Set<T>().Remove(entity);
        //}

        //public void Save()
        //{
        //    this.RepositoryContext.SaveChanges();
        //}

        //public async Task SaveAsync()
        //{
        //    await this.RepositoryContext.SaveChangesAsync();
        //}

        //public async Task CreateAsync(T entity)
        //{
        //    await this.RepositoryContext.Set<T>().AddAsync(entity);
        //}

        //public void CreateRange(IEnumerable<T> entities)
        //{
        //    this.RepositoryContext.Set<T>().AddRange(entities);
        //}

        //public void UpdateRange(IEnumerable<T> entities)
        //{
        //    this.RepositoryContext.Set<T>().UpdateRange(entities);
        //}

        //public void DeleteRange(IEnumerable<T> entities)
        //{
        //    this.RepositoryContext.Set<T>().RemoveRange(entities);
        //}

        //public async Task CreateRangeAsync(IEnumerable<T> entities)
        //{
        //    await this.RepositoryContext.Set<T>().AddRangeAsync(entities);
        //}


    }
}
