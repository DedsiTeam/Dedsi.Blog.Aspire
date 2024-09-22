namespace Dedsi.Blog.Identity.Dtos;

public record LoginInputDto(string Account,string PassWord);

public record LoginResultDto(string Token);
