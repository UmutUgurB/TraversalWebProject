using Traversal.DataAccessLayer.Repository;
using Traversal.EntityLayer.Concrete;
using TraversalProject.DataAccessLayer.Abstract;

namespace Traversal.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>,IFeatureDal
    {
    }
}
