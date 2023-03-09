using MAILSYSTEM.APPLICATION.Persistence.Companies.Commands.CreateCompany;
using MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.AllCompanies;
using MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyByEmail;
using MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyById;
using MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyByName;
using MAILSYSTEM.DOMAIN.Contracts.Requests;
using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;
using MAILSYSTEM.DOMAIN.Shared;
using MAILSYSTEM.PRESENTATION.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAILSYSTEM.PRESENTATION.Controllers;

[Authorize(AuthenticationSchemes = "ApiKey")]
////[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},ApiKey")]
[Route("api/Company")]
public sealed class CompanyController : ApiController
{
    public CompanyController(ISender sender)
        : base(sender)
    {
    }

    [AllowAnonymous]
    [HttpPost("CreateCompany", Name = "Create Company")]
    [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateCompany(
        [FromBody] RegisterCompanyRequest request,
        CancellationToken cancellationToken)
    {
        var command = new CreateCompanyCommand(request);

        Result<string> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpGet("AllCompanies", Name = "All Companies")]
    [ProducesResponseType(typeof(AllCompaniesResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllCompanies(CancellationToken cancellationToken)
    {
        var command = new GetAllCompaniesQuery();

        Result<AllCompaniesResponse> result = await Sender.Send(command, cancellationToken);

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("CompanyById", Name = "Company By Id")]
    [ProducesResponseType(typeof(CompanyResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCompanyById(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetCompanyByIdQuery(id);

        Result<CompanyResponse> result = await Sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("CompanyByName", Name = "Company By Name")]
    [ProducesResponseType(typeof(CompanyResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCompanyByName(string name, CancellationToken cancellationToken)
    {
        var query = new GetCompanyByNameQuery(name);

        Result<CompanyResponse> result = await Sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [AllowAnonymous]
    [HttpGet("CompanyByEmail", Name = "Company By Email")]
    [ProducesResponseType(typeof(CompanyResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCompanyByEmail(string email, CancellationToken cancellationToken)
    {
        var query = new GetCompanyByEmailQuery(email);

        Result<CompanyResponse> result = await Sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }
}
