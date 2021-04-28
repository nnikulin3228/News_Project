using News.Objects.Models;
using System.Linq;

namespace News.Data.Repository.Interfaces
{
    public interface IRepository
    {
        IQueryable<Post> GetAll();
        void Create(Post item);
        void Delete(Post item);
        void Save();
        Post GetPostById(int id);
    }
}