using Ecommerce.Application.Districts.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{
    public class DistrictsController : BaseAPIController
    {        
            public DistrictsController(IMediator mediator) : base(mediator)
            {
            }

            [HttpGet]
            public async Task<IActionResult> GetAllDistricts()
            {
                var result = await _mediator.Send(new GetAllDistricts.Query {});
                return Ok(result);
            }        
    }
}
