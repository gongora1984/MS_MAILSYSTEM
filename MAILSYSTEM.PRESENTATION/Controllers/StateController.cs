using MAILSYSTEM.APPLICATION.Persistence.States.Commands.CreateState;
using MAILSYSTEM.APPLICATION.Persistence.States.Queries.AllStates;
using MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesByAbbreviation;
using MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesById;
using MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesByName;
using MAILSYSTEM.DOMAIN.Contracts.Requests;
using MAILSYSTEM.DOMAIN.Contracts.Responses.States;
using MAILSYSTEM.DOMAIN.Shared;
using MAILSYSTEM.PRESENTATION.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAILSYSTEM.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = "ApiKey")]
////[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/States")]
public sealed class StateController : ApiController
{
    public StateController(ISender sender)
        : base(sender)
    {
    }

    [AllowAnonymous]
    [HttpPost("CreateState", Name = "Create State")]
    [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateState(
        [FromBody] RegisterStateRequest request,
        CancellationToken cancellationToken)
    {
        var command = new CreateStateCommand(request);

        Result<string> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("AllStates", Name = "All States")]
    [ProducesResponseType(typeof(AllStateResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllListItems(CancellationToken cancellationToken)
    {
        var command = new GetAllStateQuery();

        Result<AllStateResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("StateById/{id:guid}", Name = "State By Id")]
    [ProducesResponseType(typeof(StateResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetStateById(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetStateByIdQuery(id);

        Result<StateResponse> result = await Sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("StateByName/{name}", Name = "State By Name")]
    [ProducesResponseType(typeof(StateResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetStateByName(string name, CancellationToken cancellationToken)
    {
        var query = new GetStateByNameQuery(name);

        Result<StateResponse> result = await Sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("StateByAbbreviation/{abbreviation}", Name = "State By Abbreviation")]
    [ProducesResponseType(typeof(StateResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetStateByAbbreviation(string abbreviation, CancellationToken cancellationToken)
    {
        var query = new GetStateByAbbreviationQuery(abbreviation);

        Result<StateResponse> result = await Sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }
}
