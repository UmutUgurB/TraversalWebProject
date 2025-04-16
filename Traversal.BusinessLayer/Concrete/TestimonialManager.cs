using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrete;
using TraversalProject.DataAccessLayer.Abstract;

namespace Traversal.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonialDal.GetListAll();
        }

        public Testimonial TGetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
