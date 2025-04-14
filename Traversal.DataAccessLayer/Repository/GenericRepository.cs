﻿using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete;

namespace Traversal.DataAccessLayer.Repository
{
    public class GenericRepository<T>: IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new AppDbContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetListAll()
        {
            using var c = new AppDbContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new AppDbContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new AppDbContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
