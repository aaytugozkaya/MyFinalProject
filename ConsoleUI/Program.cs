using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal()/*Şimdilik*/);
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName + " " + category.CategoryId);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " === " + " from Category ==> " + product.CategoryName);
                }
            }
            else 
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
