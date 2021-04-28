using News.Objects.DtoModels;
using News.Objects.Models;
using News.Objects.ViewModels;
using System.Collections.Generic;

namespace News.Core.Services.Interfaces{
    public interface INewsService
    {
        Post CreateNew(PostDto item);
        IEnumerable<PostView> GetAllNews();
        bool DeletePostById(int id);
    }
}