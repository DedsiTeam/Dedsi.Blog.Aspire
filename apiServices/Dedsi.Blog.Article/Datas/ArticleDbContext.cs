using Microsoft.EntityFrameworkCore;

namespace Dedsi.Blog.Article.Datas;

public class ArticleDbContext : DbContext
{
    public DbSet<Article> Articles { get; set; }

    public ArticleDbContext(DbContextOptions<ArticleDbContext> options) : base(options)
    {
    }
}
