using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrete;
using TraversalProject.DataAccessLayer.Abstract;

namespace Traversal.BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TDelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetListAll()
        {
            return _subAboutDal.GetListAll();
        }

        public SubAbout TGetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
