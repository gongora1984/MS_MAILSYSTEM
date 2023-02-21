using MAILSYSTEM.DOMAIN.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAILSYSTEM.PRESENTATION.Abstractions;

[ApiController]
public abstract class ApiController : ControllerBase
{
    protected ApiController(ISender sender)
    {
        Sender = sender;
    }

    public ISender Sender { get; set; }

    protected IActionResult HandleFailure(Result result) =>
    result switch
    {
        { IsSuccess: true } => throw new InvalidOperationException(),
        IValidationResult validationResult =>
            BadRequest(
                CreateProblemDetails(
                    "Validation Error", StatusCodes.Status400BadRequest, result.Error, validationResult.Errors)),
        _ =>
            BadRequest(
                CreateProblemDetails(
                    "Bad Request", StatusCodes.Status400BadRequest, result.Error))
    };

    private static ProblemDetails CreateProblemDetails(
        string title,
        int status,
        Error error,
        Error[]? errors = null)
    {
        return new()
        {
            Title = title,
            Type = error.Code,
            Detail = error.Message,
            Status = status,
            Extensions = { { nameof(errors), errors } }
        };
    }
}
