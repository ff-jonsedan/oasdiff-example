using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    [HttpPost("", Name = "CreateUser")]
    [ProducesResponseType(statusCode: 200, type: typeof(User), contentType: "application/json")]
    [Consumes(contentType:"application/json")]
    public async Task<IActionResult> CreateUser([FromBody] CreateUser input)
    {
        return Ok(new User
        {
            Id = 1,
            Name = input.Name
        });
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class CreateUser
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }    

}
