using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    { 
        IProductDal _productDal; 

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal; 
        }

        public IResult Add(Product product)
        {
            // magic strings
            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInValid);
            }
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> Getall()
        {
           //throw new NotImplementedException();
           // iş sınıfı başka bir sınıfı new leyemez !!!!!!!!!! 
          //  InMemoryProductDal ınMemoryProductDal = new InMemoryProductDal();    
           return new IDataResult(_productDal.GetAll());
            
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);

        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice<= min && p.UnitPrice<= max);   
        }

        public List<ProductDetailDto> GetProductDetailDtos()
        {
            return _productDal.GetProductDetails();
        }
    }
}
