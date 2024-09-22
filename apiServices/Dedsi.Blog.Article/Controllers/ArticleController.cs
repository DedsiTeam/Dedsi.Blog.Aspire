using Dedsi.Blog.Article.Datas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dedsi.Blog.Article.Controllers;

[ApiController]
[Route("api/Article/[controller]/[action]")]
public class ArticleController(ArticleDbContext articleDbContext) : ControllerBase
{
    [HttpGet]
    public Task<int> GetAsync()
    {
        return articleDbContext.Articles.CountAsync();
    }
}
