using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using UG.DAL.Contexts;
using UG.DAL.Entities;

namespace UG.Bll.Customers
{
  
    public class CustomerRepo
    {
        private readonly Context db;
        private DbSet<Customer> entities;
        public CustomerRepo(Context _db)
        {
            this.db = _db;
            entities = db.Set<Customer>();
        }

        public IQueryable<Customer> GetAll()
        {
            return entities;
        }
      


        public Customer GetBy(Expression<Func<Customer, bool>> expression)
        {
            return entities.FirstOrDefault(expression);
        }

        public void CreateEntity(Customer data)
        {
            db.Add(data);
            db.SaveChanges();
        }

        public void UpdateEntity(Customer data)
        {
            db.Update(data);
            db.SaveChanges();
        }
    }
}
