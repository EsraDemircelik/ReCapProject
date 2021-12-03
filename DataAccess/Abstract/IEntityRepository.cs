
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //class referans tip
    //new():new'lenebilir olmalı

    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null );
        T Get(Expression<Func<T,bool>> filter);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);

    }
}
