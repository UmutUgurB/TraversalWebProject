using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrete;
using TraversalProject.DataAccessLayer.Abstract;

namespace Traversal.BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TDelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetListAll()
        {
            return _destinationDal.GetListAll();
        }

        public Destination TGetTById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public void TInsert(Destination t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
