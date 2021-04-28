using System;
namespace News.Objects.ViewModels
{
    public class PostView
    {
        public int Id { get; set; }
        public string HeadLine { get; set; }
        public string TextArea { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublishDate { get; set; }
    }
}