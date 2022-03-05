using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UG.Bll.Repository.Service;
using UG.DAL.Contexts;

namespace UG.Bll.Repository.Manegement
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        protected readonly Context _dbContext;

        protected DbSet<T> DbSet;

      

        public Repository(Context dbContext)
        {
            _dbContext = dbContext;
            DbSet= _dbContext.Set<T>();
        }


        public IQueryable<T> GetAll()
        {
            var Db=DbSet;   
            return Db;
        }

     
    }
}
