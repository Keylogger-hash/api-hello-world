using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace api_hello_world.Controllers;


[ApiController]
[Route("[controller]")]
public class HelloWorldController: ControllerBase
{

    [HttpGet(Name ="")]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<string>> Get()
    {
        return Ok("Hello world");
    }
}