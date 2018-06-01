﻿using System.Collections.Generic;
using System.Linq;

namespace LearningPortal.DAL.Interfaces
{   
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void AddRange(IList<TEntity> values);
        void Delete(int id);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void SaveChanges();
    }
}
