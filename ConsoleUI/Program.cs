﻿using Business.Concrete;
using DataAccess.Concrete.Entityframework;

namespace ConsoleUI
{

    // SOLID 
    // O = Open closed principle 
    // DTO Data Transformation Object
    // IoC
    class Program
    {
        static void Main(string[] args)
        {
            //   ProductTest();
            //  CategoryTest();
           

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetailDtos())
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
        }
    }
}