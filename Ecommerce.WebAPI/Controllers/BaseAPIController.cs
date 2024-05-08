
using AutoMapper;
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
    }
}
