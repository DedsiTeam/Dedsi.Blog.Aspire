using System.ComponentModel.DataAnnotations.Schema;

namespace Dedsi.Blog.Article.Datas
{
    [Table("Articles")]
    public class Article
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
    }
}
