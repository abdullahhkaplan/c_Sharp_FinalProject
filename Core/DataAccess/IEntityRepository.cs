﻿
using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // generic constraint
    // class: referans tip olabilir 
    // IEntity : ientity olabilir veya implement Ientity olabilir  
    // new () : new lenebilir olmalı 
    // IEntity Newlenemez çünkü interface 
    public interface IEntityRepository<T> where T : class , IEntity, new ()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        

    }
}
