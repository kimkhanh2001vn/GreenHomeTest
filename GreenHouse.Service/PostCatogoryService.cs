using GreenHouse.Data.Infrastructure;
using GreenHouse.Data.Repositories;
using GreenHouse.Model.Models;
using System.Collections.Generic;

namespace GreenHouse.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);

        void update(PostCategory postCategory);

        PostCategory Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GerByParentId(int ParentId);

        PostCategory GetById(int id);
    }

    public class PostCatogoryService : IPostCategoryService
    {
        private IPostCategoryReponsitory _postCategoryReponsitory;
        private IUnitOfWork _unitOfWork;

        public PostCatogoryService(IPostCategoryReponsitory postCategoryReponsitory, IUnitOfWork unitOfWork)
        {
            this._postCategoryReponsitory = postCategoryReponsitory;
            this._unitOfWork = unitOfWork;
        }

        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryReponsitory.Add(postCategory);
        }

        public PostCategory Delete(int id)
        {
            return _postCategoryReponsitory.Delete(id);
        }

        public IEnumerable<PostCategory> GerByParentId(int ParentId)
        {
            return _postCategoryReponsitory.GetMulti(x => x.ParentID == ParentId);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryReponsitory.GetAll();
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryReponsitory.GetSingleById(id);
        }

        public void update(PostCategory postCategory)
        {
            _postCategoryReponsitory.Update(postCategory);
        }
    }
}