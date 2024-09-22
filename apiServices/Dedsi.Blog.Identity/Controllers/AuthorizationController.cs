using Dedsi.Blog.Identity.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Dedsi.Blog.Identity.Controllers;

[ApiController]
[Route("api/Identity/[controller]/[action]")]
public class AuthorizationController : ControllerBase
{
    [HttpPost]
    public Task<LoginResultDto> LoginAsync(LoginInputDto input)
    {
        var resultDto = new LoginResultDto("sdjfhsadjfklhajkldf");
        return Task.FromResult(resultDto);
    }
}
