using Ecommerce.Application.UserFavorites.Commands;
using Ecommerce.Application.UserFavorites.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{
    public class UserFavoritesController : BaseAPIController
    {
        public UserFavoritesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<ActionResult> AddUserFavorite(long userId, long propertyId)
        {
            await _mediator.Send(new AddUserFavorite.Command { UserId = userId, PropertyId = propertyId });
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserFavorites(long id)
        {
            var result = await _mediator.Send(new GetUserFavorites.Query { UserId = id });
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUser(long userId, long propertyId)
        {
            await _mediator.Send(new DeletePropertyFromFavorites.Command { UserId = userId, PropertyId = propertyId });
            return Ok();
        }
    }
}
