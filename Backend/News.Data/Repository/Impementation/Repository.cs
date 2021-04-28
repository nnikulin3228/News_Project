using News.Data.Repository.Interfaces;
using News.Objects.Models;
using News.Data.Context;
using System.Linq;

namespace News.Data.Repository.Implementation
{
    public class Repository : IRepository
    {
        private readonly AppContext _context;
        public Repository(AppContext context)
        {
            _context = context;
        }
        public void Create(Post item)
        {
            _context.Posts.Add(item);
        }

        public void Delete(Post item)
        {
            _context.Posts.Remove(item);
        }

        public IQueryable<Post> GetAll()
        {
            return _context.Posts;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Post GetPostById(int id)
        {
            return _context.Posts.FirstOrDefault(p => p.Id == id);
        }
    }
}