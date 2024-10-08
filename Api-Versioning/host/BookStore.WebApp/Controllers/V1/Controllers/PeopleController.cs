﻿using Asp.Versioning;
using BookStore.Controllers.V1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers.V1.Controllers;

/// <summary>
/// Represents a RESTful people service.
/// </summary>
[ApiController]
[ApiVersion( "1.0" )]
[ApiVersion( "0.9", Deprecated = true )]
[Route( "api/v{version:apiVersion}/People" )]
[ControllerName("People")]
public class PeopleController : ControllerBase
{
    /// <summary>
    /// Gets a single person.
    /// </summary>
    /// <param name="id">The requested person identifier.</param>
    /// <returns>The requested person.</returns>
    /// <response code="200">The person was successfully retrieved.</response>
    /// <response code="404">The person does not exist.</response>
    [HttpGet( "{id:int}" )]
    [Produces( "application/json" )]
    [ProducesResponseType( typeof( Person ), 200 )]
    [ProducesResponseType( 404 )]
    public IActionResult Get( int id ) =>
        Ok( new Person()
            {
                Id = id,
                FirstName = "John",
                LastName = "Doe"
            }
        );
}
