﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Pattern
{
    public interface IService<T> where T : class
    {
        T Find(params object[] keyValues);
        IQueryable<T> Queryable();
        IQueryable<T> SelectQuery(string query, params object[] parameters);
        void Insert(T entity);
        void InsertRange(IEnumerable<T> entities);
        void InsertOrUpdateGraph(T entity);
        void InsertGraphRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(object id);
        void Delete(T entity);
    }
}
