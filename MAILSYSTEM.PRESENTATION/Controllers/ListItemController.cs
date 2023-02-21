using MAILSYSTEM.APPLICATION.Persistence.ListItems.Commands;
using MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.AllListItems;
using MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemByCategory;
using MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemById;
using MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemByTag;
using MAILSYSTEM.DOMAIN.Contracts.Requests;
using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;
using MAILSYSTEM.DOMAIN.Shared;
using MAILSYSTEM.PRESENTATION.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAILSYSTEM.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = "ApiKey")]
////[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/ListItem")]
public sealed class ListItemController : ApiController
{
    public ListItemController(ISender sender)
        : base(sender)
    {
    }

    [AllowAnonymous]
    [HttpPost("CreateListItem", Name = "Create List Item")]
    [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateListItem(
        [FromBody] RegisterListItemRequest request,
        CancellationToken cancellationToken)
    {
        var command = new CreateListItemCommand(request);

        Result<string> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllListItem", Name = "All List Items")]
    [ProducesResponseType(typeof(AllListItemResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllListItems(CancellationToken cancellationToken)
    {
        var command = new GetAllListItemQuery();

        Result<AllListItemResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("ListItemById/{id:guid}", Name = "List Item By Id")]
    [ProducesResponseType(typeof(ListItemResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetListItemById(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetListItemByIdQuery(id);

        Result<ListItemResponse> result = await Sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("ListItemByCategory/{category}", Name = "List Item By Category")]
    [ProducesResponseType(typeof(AllListItemResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetListItemByCategory(string category, CancellationToken cancellationToken)
    {
        var query = new GetListItemByCategoryQuery(category);

        Result<AllListItemResponse> result = await Sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("ListItemByTag/{tag}", Name = "List Item By Tag")]
    [ProducesResponseType(typeof(AllListItemResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetListItemByTag(string tag, CancellationToken cancellationToken)
    {
        var query = new GetListItemByTagQuery(tag);

        Result<AllListItemResponse> result = await Sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }
}
