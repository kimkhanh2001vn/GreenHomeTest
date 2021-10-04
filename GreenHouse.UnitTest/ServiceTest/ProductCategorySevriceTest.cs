using GreenHouse.Data.Infrastructure;
using GreenHouse.Data.Repositories;
using GreenHouse.Model.Models;
using GreenHouse.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.UnitTest.ServiceTest
{
    [TestClass]
    public class ProductCategorySevriceTest
    {
        private Mock<IProductCategoryRepository> _mockReponsitory;
        private Mock<IUnitOfWork> _mockUnitOfWord;
        private IProductCategoryService _CategoryService;
        private List<ProductCategory> _listCategories;
        [TestInitialize]
        public void Initialize()
        {
            _mockReponsitory = new Mock<IProductCategoryRepository>();
            _mockUnitOfWord = new Mock<IUnitOfWork>();
            _CategoryService = new ProductCategoryService(_mockReponsitory.Object, _mockUnitOfWord.Object);
            _listCategories = new List<ProductCategory>()
            {
                new ProductCategory(){ ID = 1 , Name =" DM1" ,Status=true },
                new ProductCategory(){ ID = 2 , Name =" DM2" ,Status=true },
                new ProductCategory(){ ID = 3 , Name =" DM3" ,Status=true },
            };
        }
        [TestMethod]
        public void ProductCategory_Service_GetAll()
        {
            //setup method
            _mockReponsitory.Setup(x => x.GetAll(null)).Returns(_listCategories);
            //call action
            var result = _CategoryService.GetAll() as List<ProductCategory>;
            //compare 
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }
        [TestMethod]
        public void ProductCategory_Service_Create()
        {
            ProductCategory category = new ProductCategory();
            category.Name = "abc test";
            category.Alias = "abc-tesr";
            category.Status = true;

            _mockReponsitory.Setup(x => x.Add(category)).Returns((ProductCategory p) =>
            {
                p.ID = 1;
                return p;
            });

            var result = _CategoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
