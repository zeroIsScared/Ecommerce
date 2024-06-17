using Ecommerce.Application.Localities.Queries;
using Ecommerce.Application.Utilities.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{
    public class LocalitiesController : BaseAPIController
    {      

            public LocalitiesController(IMediator mediator) : base(mediator)
            {
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetLocalityByDistrictId(long id)
            {
                var result = await _mediator.Send(new GetLocalityByDistrictId.Query { Id = id });
                return Ok(result);
            }

        
    }
}
