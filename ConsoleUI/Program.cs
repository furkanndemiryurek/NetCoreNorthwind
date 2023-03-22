using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;

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
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryID + " " + category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetAll();

            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        //class LinqTest
        //{
        //    List<Product> _products = new List<Product>
        //    {
        //        new Product{ProductId = 1, CategoryId = 1, ProductName = "Huawei Matebook", UnitPrice = 7000},
        //        new Product{ProductId = 2, CategoryId = 1, ProductName = "Apple Macbook", UnitPrice = 17000},
        //        new Product{ProductId = 3, CategoryId = 2, ProductName = "Samsung Galaxy 9", UnitPrice = 4000},
        //        new Product{ProductId = 4, CategoryId = 2, ProductName = "Oppo A9", UnitPrice = 2700}
        //    };

        //    List<Category> _categories = new List<Category>
        //    {
        //        new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
        //        new Category{CategoryId = 2, CategoryName = "Telefon"}
        //    };
        //    private static void JoinTest(List<Product> _products, List<Category> _categories)
        //    {
        //        var result = from p in _products
        //                     join c in _categories
        //                     on p.CategoryId equals c.CategoryId
        //                     where p.UnitPrice > 3901
        //                     select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName };

        //        foreach (var product in result)
        //        {
        //            Console.WriteLine("{0} -- {1} -- {2}", product.ProductId, product.CategoryName, product.ProductName);
        //        }
        //    }

        //    private static void FindAllTest(List<Product> _products)
        //    {
        //        var result = _products.FindAll(p => p.CategoryId == 2);
        //        foreach (var product in result)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }
        //    }

        //    private static void AnyTest(List<Product> _products)
        //    {
        //        var result = _products.Any(p => p.ProductName == "Apple Macbook");
        //        var result2 = _products.Any(p => p.ProductName == "Aple Macbook");
        //        Console.WriteLine(result2);
        //    }

        //    class Product
        //    {
        //        public int ProductId { get; set; }
        //        public int CategoryId { get; set; }
        //        public string ProductName { get; set; }
        //        public decimal UnitPrice { get; set; }
        //    }

        //    class Category
        //    {
        //        public int CategoryId { get; set; }
        //        public string CategoryName { get; set; }
        //    }

        //    class ProductDto
        //    {
        //        public int ProductId { get; set; }
        //        public string CategoryName { get; set; }
        //        public string ProductName { get; set; }

        //    }
        //}
    }
}
