using MAILSYSTEM.PRESENTATION.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MAILSYSTEM.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = "ApiKey")]
[Route("api/test")]
public sealed class TestController : ApiController
{
    public TestController(ISender sender)
        : base(sender)
    {
    }

    [AllowAnonymous]
    [HttpGet("HelloWorld")]
    public IActionResult HelloWorld()
    {
        return Ok("Hello");
    }

    ////[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
    ////[Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("Another")]
    public IActionResult Another()
    {
        return Ok("Hello2");
    }
}
