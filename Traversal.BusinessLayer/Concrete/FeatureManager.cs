using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrete;
using TraversalProject.DataAccessLayer.Abstract;

namespace Traversal.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TDelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetListAll()
        {
            return _featureDal.GetListAll();
        }

        public Feature TGetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
