using System;
namespace News.Objects.DtoModels
{
    public class PostDto
    {
        public string HeadLine { get; set; }
        public string TextArea { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublishDate { get; set; }
    }
}