using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG.Bll.Repository.Service
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
     

       public IQueryable<TEntity> GetAll();


    }
}
