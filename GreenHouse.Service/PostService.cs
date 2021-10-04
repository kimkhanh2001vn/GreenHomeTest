using GreenHouse.Data.Infrastructure;
using GreenHouse.Data.Repositories;
using GreenHouse.Model.Models;
using System.Collections.Generic;

namespace GreenHouse.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GerAllPaging(int page, int pagesize, out int totaRow);

        IEnumerable<Post> GerAllCategoryPaging(int categoryId, int page, int pagesize, out int totaRow);

        Post GetById(int id);

        IEnumerable<Post> GerAllByTagPaging(string tag, int page, int pagesize, out int totaRow);

        void SaveChanges();
    }

    public class PostService : IPostService
    {
        private IPostReponsitory _postReponsitory;
        private IUnitOfWork _unitOfWork;

        public PostService(IPostReponsitory postReponsitory, IUnitOfWork unitOfWork)
        {
            this._postReponsitory = postReponsitory;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postReponsitory.Add(post);
        }

        public void Delete(int id)
        {
            _postReponsitory.Delete(id);
        }

        public IEnumerable<Post> GerAllByTagPaging(string tag, int page, int pagesize, out int totaRow)
        {
            //TODO: Select all post by tag
            return _postReponsitory.GetAllByTag(tag, page, pagesize, out totaRow);
        }

        public IEnumerable<Post> GerAllCategoryPaging(int categoryId, int page, int pagesize, out int totaRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totaRow, page, pagesize, new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GerAllPaging(int page, int pagesize, out int totaRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.Status, out totaRow, page, pagesize);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postReponsitory.GetAll(new string[] { "PostCategory" });
        }

        public Post GetById(int id)
        {
            return _postReponsitory.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void update(Post post)
        {
            _postReponsitory.Update(post);
        }
    }
}