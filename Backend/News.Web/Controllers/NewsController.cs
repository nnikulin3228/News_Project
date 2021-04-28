using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using News.Objects.ViewModels;
using News.Objects.DtoModels;
using News.Core.Services.Interfaces;
using System.IO;

namespace News.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        public NewsController(INewsService news)
        {
            _newsService = news;
        }
        private readonly INewsService _newsService;
        // GET api/news
        [HttpGet]
        public ActionResult<IEnumerable<PostView>> Get()
        {
            return Ok(_newsService.GetAllNews());
        }

        [HttpPost]
        public ActionResult post([FromBody]PostDto item)
        {
            var createdItem = _newsService.CreateNew(item);
            return Ok(createdItem);
        }

        // DELETE api/delete/5
        [HttpDelete("delete/{id}")]
        public ActionResult Delete(int id)
        {
            bool result = _newsService.DeletePostById(id);
            return Ok(result);
        }
    }
}
