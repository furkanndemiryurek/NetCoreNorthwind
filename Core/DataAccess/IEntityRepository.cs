using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // GENERIC CONSTRAINT -------------------- 
    // class : referans tip olmak zorunda
    // IEntity : IEntity olabilir veya IEntity'i implemente eden bir nesne olmalı                                      
    // new() : Newlenebilir olmalı. Yani interface olamaz böylece IEntity yazmasının önüne geçilir
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
