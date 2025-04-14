﻿using Traversal.DataAccessLayer.Repository;
using Traversal.EntityLayer.Concrete;
using TraversalProject.DataAccessLayer.Abstract;

namespace Traversal.DataAccessLayer.EntityFramework
{
   public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
