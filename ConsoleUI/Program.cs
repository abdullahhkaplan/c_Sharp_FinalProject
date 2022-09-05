using Business.Concrete;
using DataAccess.Concrete.Entityframework;

namespace ConsoleUI
{

    // SOLID 
    // O = Open closed principle 
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(10,100))
            {
                Console.WriteLine(product.ProductName);
            }

        }
    }
}