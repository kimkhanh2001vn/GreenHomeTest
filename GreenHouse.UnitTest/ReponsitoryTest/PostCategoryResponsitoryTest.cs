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
    public class PostCategoryResponsitoryTest
    {
        IDbFactory dbFactory;
        IUnitOfWork unitOfWork;
        IPostCategoryReponsitory objreponsitory;
        [TestInitialize]
        public void Inittialize()
        {
            dbFactory = new DbFactory();
            objreponsitory = new PostCategoryReponsitory((DbFactory)dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Responsitory_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test Category";
            category.Alias = "Test-categpry";
            category.Status = true;

            var result = objreponsitory.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ID);
            
        }
        [TestMethod]
        public void PostCategory_Reponsitory_GetAll()
        {
            var list = objreponsitory.GetAll();
            Assert.AreEqual(1, list.Count());
        }


    }
}
