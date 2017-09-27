﻿#region Using Namespaces... 
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace DataModel.GenericRepository
{
    /// <summary>
    /// Generic Repository class for Entity Operations
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class GenericRepository<TEntity> where TEntity : class
    {
        #region Private member variables...
        internal WebApiDbEntities Context;
        internal DbSet<TEntity> DbSet;
        #endregion

        #region Public Constructor... 
        /// <summary>
        /// Public Constructor,initializes privately declared local variables
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(WebApiDbEntities context)
        {
            this.Context = context;
            this.DbSet = context.Set<TEntity>();
        }
        #endregion

        #region Public member methods...
        /// <summary>
        /// generic Get method for Entities
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> Get()
        {
            IQueryable<TEntity> query = DbSet;
            return query.ToList();
        }
        #endregion
    }
}
