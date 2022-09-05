using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    { 
        IProductDal _productDal; 

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal; 
        }

        public List<Product> Getall()
        {
           //throw new NotImplementedException();
           // iş sınıfı başka bir sınıfı new leyemez !!!!!!!!!! 
          //  InMemoryProductDal ınMemoryProductDal = new InMemoryProductDal();    
           return _productDal.GetAll();
            
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);

        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice<= min && p.UnitPrice<= max);   
        }
    }
}
