using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        public List<Comment> TGetDestinationById(int id);
    }
}
