﻿using System.Linq.Expressions;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetById(int id);
        List<T> GetListByFilet(Expression<Func<T, bool>> filter);
    }
}
