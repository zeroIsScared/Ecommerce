
using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]   
    public class BaseAPIController : ControllerBase
    {          
      
        protected readonly IMediator _mediator;

        public BaseAPIController(IMediator mediatr)
        {                    
            _mediator = mediatr;
        }

        protected ActionResult HandleResult<T>(Result<T> result)
        {
            if (result.IsSuccess && result.Value != null)
                return Ok(result.Value);
            if (result.IsSuccess && result.Value == null)
                return NotFound();
            return BadRequest(result.Error);
        }
    }
}
