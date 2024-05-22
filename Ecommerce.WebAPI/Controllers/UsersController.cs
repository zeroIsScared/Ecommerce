
using Ecommerce.Application.Users.Commands;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Application.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{
    public class UsersController : BaseAPIController
    {
        public UsersController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _mediator.Send(new GetAllUsers.Query());
            return HandleResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserId(long id)
        {
            var result = await _mediator.Send(new GetUserById.Query { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDto user)
        {
             var result = await _mediator.Send(new CreateUser.Command { User = user });
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditUser( UserDto user)
        {            
            var result = await _mediator.Send(new EditUser.Command { User = user });
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(long id)
        {
            await _mediator.Send(new DeleteUser.Command {UserId = id });
            return Ok();
        }

    }
}
