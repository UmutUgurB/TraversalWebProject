using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Repository;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccessLayer.EntityFramework
{
   public class EfCommentDal : GenericRepository<Comment>,ICommentDal
    {
    }
}
