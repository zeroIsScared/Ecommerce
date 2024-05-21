using Ecommerce.Application.UserFavorites.Commands;
using Ecommerce.Application.UserFavorites.Queries;
using Ecommerce.Application.Users.Commands;
using Ecommerce.Application.Users.Queries;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace Ecommerce.WebAPI.Controllers
{
    public class UserFavoritesController : BaseAPIController
    {
        public UserFavoritesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<ActionResult> AddUserFavorite(int userId, int propertyId)
        {
            await _mediator.Send(new AddUserFavorite.Command { UserId = userId, PropertyId = propertyId });
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserFavorites(int id)
        {
            var result = await _mediator.Send(new GetUserFavorites.Query { UserId = id });
            return HandleResult(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUser(int userId, int propertyId)
        {
            await _mediator.Send(new DeletePropertyFromFavorites.Command { UserId = userId, PropertyId = propertyId });
            return Ok();
        }
    }
}
