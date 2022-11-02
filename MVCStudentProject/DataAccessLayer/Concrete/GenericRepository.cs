using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        public int Add(T entity)
        {
            using(Context context = new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                return context.SaveChanges();
            }
        }

        public int Delete(T entity)
        {
            using (Context context = new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }
        public List<T> ListAll()
        {
            using(Context context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public int Update(T entity)
        {
            using (Context context = new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
    }
}
