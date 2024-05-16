
using Ecommerce.Application.Users.Commands;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Application.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{
    public class UserController : BaseAPIController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _mediator.Send(new GetAllUsers.Query());
            return HandleResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserId(int id)
        {
            var result = await _mediator.Send(new GetUserById.Query { Id = id });
            return HandleResult(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateUser(CreateUserDto user)
        {
            return await _mediator.Send(new CreateUser.Command { User = user });

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<int>> EditUser(int id, EditUserDto user)
        {
            user.Id = id;
            return await _mediator.Send(new EditUser.Command { User = user });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _mediator.Send(new DeleteUser.Command { Id = id });
            return Ok();
        }

    }
}
