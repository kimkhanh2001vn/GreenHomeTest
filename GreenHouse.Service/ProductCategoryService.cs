using GreenHouse.Data.Infrastructure;
using GreenHouse.Data.Repositories;
using GreenHouse.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.Service
{
    public interface IProductCategoryService
    {
        ProductCategory Add(ProductCategory productCategory);

        void update(ProductCategory productCategory);

        ProductCategory Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GerByParentId(int ParentId);

        ProductCategory GetById(int id);
    }
    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork unitOfWork;
        public ProductCategoryService(IProductCategoryRepository productCategoryReponsitory, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryReponsitory;
            this.unitOfWork = unitOfWork;
        }
        public ProductCategory Add(ProductCategory productCategory)
        {
           return _productCategoryRepository.Add(productCategory);
        }

        public ProductCategory Delete(int id)
        {
            return _productCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GerByParentId(int ParentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRepository.GetAll();
        }

        public ProductCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
    }
}
