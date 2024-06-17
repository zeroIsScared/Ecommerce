using Ecommerce.Application.UserFavorites.Commands;
using Ecommerce.Application.UserFavorites.Queries;
using Ecommerce.Application.Utilities.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{
    public class UtilitiesController : BaseAPIController
    {
        public UtilitiesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUilitiesByCategoryId(long id)
        {
            var result = await _mediator.Send(new GetUtilityByCategoryId.Query { Id = id });
            return Ok(result);
        }
    }
}
