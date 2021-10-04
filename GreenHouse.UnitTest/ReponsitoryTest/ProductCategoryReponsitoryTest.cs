using GreenHouse.Data.Infrastructure;
using GreenHouse.Data.Repositories;
using GreenHouse.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.UnitTest.ReponsitoryTest
{
    [TestClass]
    public class ProductCategoryReponsitoryTest
    {
        IDbFactory dbFactory;
        IUnitOfWork unitOfWork;
        IProductCategoryRepository objreponsitory;
        [TestInitialize]
        public void Inittialize()
        {
            dbFactory = new DbFactory();
            objreponsitory = new ProductCategoryRepository((DbFactory)dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void ProductCategory_Reponsitory_GetAll()
        {
            var list = objreponsitory.GetAll().ToList();
            Assert.AreEqual(2, list.Count());
        }
        [TestMethod]
        public void ProductCategory_Responsitory_Create()
        {
            ProductCategory category = new ProductCategory();
            category.Name = "Test Category";
            category.Alias = "Test-categpry";
            category.Status = true;

            var result = objreponsitory.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.ID);
        }
    }
}
