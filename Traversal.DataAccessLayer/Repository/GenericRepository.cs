﻿using System.Linq.Expressions;
using Traversal.DataAccessLayer.Abstract;
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

        public T GetById(int id)
        {
            using var c = new AppDbContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new AppDbContext();
            return c.Set<T>().ToList();
        }

        public List<T> GetListByFilet(Expression<Func<T, bool>> filter)
        {
            using var c = new AppDbContext();
            return c.Set<T>().Where(filter).ToList();
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
