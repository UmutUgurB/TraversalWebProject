using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Traversal.BusinessLayer.Abstract;
using Traversal.DataAccessLayer.Abstract;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public Comment TGetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Comment t)
        {
            throw new NotImplementedException();
        }
        public List<Comment> TGetDestinationById(int id)
        {
            return _commentDal.GetListByFilet(x=> x.DestinationID==id);
        }
        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
