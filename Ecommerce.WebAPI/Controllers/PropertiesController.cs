
using Ecommerce.Application.Properties.Commands;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.Properties.Queries;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{

    public class PropertiesController : BaseAPIController
    {
        public PropertiesController( IMediator mediator) : base( mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetPropreties()
        {
            var result = await _mediator.Send(new GetListOfProperties.Query());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPropertyById(long id)
        {
            var result =  await _mediator.Send(new GetPropertyById.Query { Id = id });
            return Ok(result);           
        }

        [HttpGet("category/{id}")]
        public async Task<IActionResult> GetPropertiesByCategoryId(int id)
        {
            var result = await _mediator.Send(new GetPropertyListByCategoryId.Query { Id = id });
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> CreateProperty(CreatePropertyDto property)
        {
            var result = await _mediator.Send(new CreateProperty.Command { RealEstate = property });
            return Ok(result);            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditProperty(long id, CreatePropertyDto property)
        {
            property.Id = id;
            var result = await _mediator.Send(new EditProperty.Command { RealEstate = property });
            return Ok(result);
        }

        [HttpDelete("{id}")] 
        public async Task<IActionResult> DeleteProperty(long id)
        {
            await _mediator.Send(new DeleteProperty.Command { Id = id });
            return Ok();
        }
    }
}
