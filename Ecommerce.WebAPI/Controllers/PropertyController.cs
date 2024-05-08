
using Ecommerce.Application.Properties.Commands;
using Ecommerce.Application.Properties.Create;

using Ecommerce.Application.Properties.Queries;
using Ecommerce.Application.Property.Responses;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{

    public class PropertyController : BaseAPIController
    {
        public PropertyController( IMediator mediator) : base( mediator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<PropertyDto>>> GetPropreties()
        {
            var result = await _mediator.Send(new GetListOfProperties.Query());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyDto>> GetPropertyById(int id)
        {
            return await _mediator.Send(new GetPropertyById.Query { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateProperty(Property property)
        {
            return await _mediator.Send(new CreateProperty.Command { RealEstate = property });
            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<int>> EditProperty(int id, Property property)
        {
            property.Id = id;
            return await _mediator.Send(new EditProperty.Command { Property = property });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            await _mediator.Send(new DeleteProperty.Command { Id = id });
            return Ok();
        }
    }
}
