using Microsoft.EntityFrameworkCore;
using PruebaTecnicaCristianHiguitaAPP.Cross.Exception_;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCristianHiguitaAPP.Data.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal RegionesBDContext _contexto;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(RegionesBDContext contexto)
        {
            this._contexto = contexto;
            this.dbSet = _contexto.Set<TEntity>();
        }

        public async Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> getBy, params Expression<Func<TEntity, object>>[] includes)
        {
            try
            {
                var result = _contexto.Set<TEntity>().Where(getBy);

                foreach (var expression in includes)
                    result = result.Include(expression);

                return await result.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }
            
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            try
            {
                IQueryable<TEntity> query = dbSet;

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                foreach (var propiedad in includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(propiedad);
                }

                if (orderBy != null)
                {
                    return orderBy(query).ToList();
                }
                else
                {
                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }


        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _contexto.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }
        }
        public virtual TEntity GetByID(object id)
        {
            try
            {
                return dbSet.Find(id);
            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }

        }

        public virtual void Insert(TEntity entity)
        {
            try
            {
                dbSet.Add(entity);


            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }

        }

        public virtual void AddRange(List<TEntity> entity)
        {
            try
            {
                dbSet.AddRange(entity);
            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }
            
        }

        public virtual void Delete(object id)
        {
            try
            {
                TEntity entityToDelete = dbSet.Find(id);
                Delete(entityToDelete);
            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }
           
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            try
            {
                if (_contexto.Entry(entityToDelete).State == EntityState.Detached)
                {
                    dbSet.Attach(entityToDelete);
                }
                dbSet.Remove(entityToDelete);
            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }
         
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                IQueryable<TEntity> query = dbSet.Where(predicate).AsQueryable();
                foreach (TEntity obj in query)
                {
                    dbSet.Remove(obj);
                }
            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }

        }

        public virtual void Update(TEntity entityToUpdate)
        {
            try
            {
                dbSet.Attach(entityToUpdate);
                _contexto.Entry(entityToUpdate).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw new TecnicalException(ex.Message);
            }

        }
    }
}
