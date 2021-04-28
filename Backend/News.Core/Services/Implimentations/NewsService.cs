using News.Core.Services.Interfaces;
using News.Objects.DtoModels;
using News.Objects.Models;
using News.Data.Repository.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using News.Objects.ViewModels;
using System.Collections.Generic;
using System.IO;

namespace News.Core.Services.Implementation
{
    public class NewsService : INewsService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        public NewsService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public Post CreateNew(PostDto item)
        {
            var dbItem = _mapper.Map<Post>(item);
            _repository.Create(dbItem);
            _repository.Save();
            return dbItem;
        }

        public bool DeletePostById(int id)
        {
            string url = $"wwwroot/{id}.jpg";
            bool isFile = File.Exists(url);
            if (isFile)
            {
                File.Delete(url);
            }
            
            var item = _repository.GetPostById(id);
            if (item == null)
            {
                return false;
            }
            _repository.Delete(item);
            _repository.Save();
            return true;
        }
        public IEnumerable<PostView> GetAllNews()
        {
            return _repository.GetAll().ProjectTo<PostView>(_mapper.ConfigurationProvider);
        }
    }
}